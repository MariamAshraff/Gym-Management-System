using Gym_Management_System.Data.Enums;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class TraineeSubscriptionFormcs : Form
    {
        private TableLayoutPanel table;
        private ITraineeSubscriptionService _TSService;
        private ITrainingProgramService _TPService;
        private ITraineesService _TraineeService;
        private IOfferService _offerService;
        private IPaymetnService _paymentService;
        private IService _service;
        private bool isLoaded = false;
        public TraineeSubscriptionFormcs
            (ITraineeSubscriptionService TSubscriptionService, ITrainingProgramService tPService,
             ITraineesService traineeService, IOfferService offerService,
             IPaymetnService paymetnService, IService service)
        {
            InitializeComponent();
            _TSService = TSubscriptionService;
            _TPService = tPService;
            _TraineeService = traineeService;
            _offerService = offerService;
            _paymentService = paymetnService;
            _service = service;

            this.AutoScroll = true;

            TraineeIdExist.Text = "";

        }

        private void TraineeSubscriptionFormcs_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            table = new TableLayoutPanel();

            table.Dock = DockStyle.Fill;
            table.ColumnCount = 3;
            table.RowCount = 3;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // Rows
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 40F)); // Top spacing
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Content
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Bottom spacing

            this.Controls.Add(table);

            // Place each control in its own row
            table.Controls.Add(DataGroupBox, 1, 0);
            table.Controls.Add(PaymentGBox, 1, 1);
            table.Controls.Add(Subscribe_PayBtn, 1, 2);

            // Center them
            DataGroupBox.Anchor = AnchorStyles.None;
            PaymentGBox.Anchor = AnchorStyles.None;
            Subscribe_PayBtn.Anchor = AnchorStyles.None;

            var trainingPrograms = _TPService.GetTrainingPrograms();
            TrainingProgramBox.DataSource = trainingPrograms.ToList();
            TrainingProgramBox.DisplayMember = "Name";
            TrainingProgramBox.ValueMember = "Id";

            LoadData();

            isLoaded = true;
        }

        private void Subscribe_PayBtn_Click(object sender, EventArgs e)
        {
            TraineeIdExist.Text = "";
            #region Adding Subscription
            var Trainee = _TraineeService.GetTrainee(int.Parse(TraineeIdBox.Text == "" ? "0" : TraineeIdBox.Text));
            if (Trainee == null)
            {
                TraineeIdExist.Text = "There is no trainees with this Id";
                return;
            }
            var SelectTrainingProgram = _TPService.GetTrainingPbyId(Convert.ToInt32(TrainingProgramBox.SelectedValue));
            var startDate = StartDatePicker.Value;
            var Months = Convert.ToInt32(MonthsCount.Value);
            var EndDate = startDate.Date.AddMonths(Months);

            var NewSubscription = new TraineeSubscription()
            {
                StartDate = startDate,
                EndDate = startDate.Date.AddMonths(Months),
                Months = Months,
                IsActive = true,
                PackageTotalDays = SelectTrainingProgram!.AllowedDays * Months,
                Status = SubscriptionStatus.Active,
                TrainingProgramId = SelectTrainingProgram.Id,
                TraineeId = Convert.ToInt32(TraineeIdBox.Text),
            };

            _TSService.Add(NewSubscription);
            #endregion

            #region Adding Payment
            var offer = _offerService.GetOfferForProgram(SelectTrainingProgram.Id);
            MoneyAmount.Text = $"{SelectTrainingProgram.Price * Months}";
            DiscountAmount.Text = offer == null ? "0" : $"{offer.DiscountPercentage}";
            var NetAmountValue = Convert.ToDecimal(NetAmount.Text);
            NetAmount.Text = offer == null ? MoneyAmount.Text : $"{NetAmountValue}";
            string PaymentMthod = "";
            if (radioCash.Checked)
                PaymentMthod = "Cash";
            else if (radioInstaPay.Checked)
                PaymentMthod = "InstaPay";
            else
                PaymentMthod = "Credit Card";

            _paymentService.Add(new Payment
            {
                Amount = NetAmountValue,
                Method = PaymentMthod,
                PaidAt = DateTime.Now,
                TraineeSubscriptionId = NewSubscription.Id
            });
            MessageBox.Show("Subscirbed and paid", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion




        }

        private void TraineeIdBox_TextChanged(object sender, EventArgs e)
        {
            string filtered = new string(TraineeIdBox.Text.Where(char.IsDigit).ToArray());

            if (TraineeIdBox.Text != filtered)
            {
                int cursor = TraineeIdBox.SelectionStart;
                TraineeIdBox.Text = filtered;
                TraineeIdBox.SelectionStart = Math.Max(0, cursor - 1);
            }
        }
        private void UpdateData()
        {
            var selectedProgramId = Convert.ToInt32(TrainingProgramBox.SelectedValue);
            var selectedTraineeId = Convert.ToInt32(TraineeIdBox.Text);
            var selectedProgram = _TPService.GetTrainingPbyId(selectedProgramId);
            var offer = _offerService.GetOfferForProgram(selectedProgram!.Id);
            if(_TSService.AlreadySubscribedInProgram(selectedProgramId , selectedTraineeId))
            {
                TraineeIdExist.Text = "Trainee already subscribed to this program";
                Subscribe_PayBtn.Enabled = false;
            }
            MoneyAmount.Text = $"{selectedProgram!.Price * MonthsCount.Value}";
            DiscountAmount.Text = offer == null ? "0" : $"{offer.DiscountPercentage}";
            if (offer == null)
            {
                NetAmount.Text = MoneyAmount.Text;
            }
            else
            {
                var _netAmount = selectedProgram.Price* (1- (offer.DiscountPercentage / 100) )
                                * MonthsCount.Value;
                NetAmount.Text =_netAmount.ToString();
            }
        }
        private void LoadData()
        {
            var TrainingProgram = _TPService.GetTrainingPrograms().FirstOrDefault();
            if (TrainingProgram == null)
                return;
            var offer = _offerService.GetOfferForProgram(TrainingProgram.Id);
            MoneyAmount.Text = TrainingProgram.Price.ToString();
            DiscountAmount.Text = offer == null ? "0" : $"{offer.DiscountPercentage}";
            if (offer != null)
                NetAmount.Text = (TrainingProgram.Price * MonthsCount.Value *
                (1 - (offer.DiscountPercentage / 100))).ToString();
            else
                NetAmount.Text = MoneyAmount.Text;
        }

        private void MonthsCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void TrainingProgramBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
                return;
            UpdateData();
        }
    }
}
