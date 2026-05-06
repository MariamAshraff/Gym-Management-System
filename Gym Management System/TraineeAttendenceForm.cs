using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Implementation;
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
    public partial class TraineeAttendenceForm : Form
    {
        private TableLayoutPanel table;
        private ITraineeAttendenceService _attendenceService;
        private ITraineeSubscriptionService _subscriptionService;
        private ITraineesService _traineesService;
        private bool FormElligibleToAddAttendence = false;
        public TraineeAttendenceForm(ITraineeAttendenceService service,
            ITraineeSubscriptionService subscriptionService, ITraineesService traineesService)
        {
            this._attendenceService = service;
            this._subscriptionService = subscriptionService;
            this._traineesService = traineesService;
            InitializeComponent();
        }

        private void TraineeAttendenceForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            table = new TableLayoutPanel();

            table.Dock = DockStyle.Fill;
            table.ColumnCount = 3;
            table.RowCount = 3;

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));

            // Rows
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F)); // Top spacing
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Content
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Bottom spacing

            this.Controls.Add(table);
            table.Controls.Add(TraineeAttendencGroupBox, 1, 1);
            CheckInBox.Text = $"{DateTime.Now}";
        }

        private void SubscriptionIdBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }


        void SetValidation()
        {
            ValidateSubscriptionId.Text = "There is No Subscriptions With this Id";
        }
        void ClearValidation()
        {
            ValidateSubscriptionId.Text = "";
            ValidateLastCheckin.Text = "";
        }

        private void CreateAttendencBtn_Click(object sender, EventArgs e)
        {
            if (FormElligibleToAddAttendence)
            {
                _attendenceService.AddAttendence(Convert.ToInt32(SubscriptionIdBox.Text));
                MessageBox.Show("Attendence Added For Today!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValidateForm();
            }
            else
                SetValidation();
        }
        void ValidateSubscriptionIdInput()
        {
            string filtered = new string(SubscriptionIdBox.Text.Where(char.IsDigit).ToArray());

            if (SubscriptionIdBox.Text != filtered)
            {
                int cursor = SubscriptionIdBox.SelectionStart;
                SubscriptionIdBox.Text = filtered;
                SubscriptionIdBox.SelectionStart = Math.Max(0, cursor - 1);
            }
        }
        void ValidateForm()
        {
            ValidateSubscriptionIdInput();
            ClearValidation();
            CreateAttendencBtn.Enabled = true;
            if (SubscriptionIdBox.Text == "")
                return;
            var subscription = _subscriptionService.GetById(Convert.ToInt32(SubscriptionIdBox.Text));
            if (subscription != null)
            {
                var trainee = _traineesService.GetTrainee(subscription.TraineeId);
                TraineeNameBox.Text = trainee!.Name;
                LastCheckinBox.Text = subscription.LastCheckIn.ToString();
                if (subscription.IsActive)
                {
                    CardStatusBox.BackColor = Color.Green;
                    CardStatusBox.Text = "Active";
                }
                else
                {
                    CardStatusBox.BackColor = Color.Red;
                    CardStatusBox.Text = "Frozen | Expired";
                    CreateAttendencBtn.Enabled = false;
                }
                if (subscription.UsedDays == 0)
                {
                    ValidateLastCheckin.Text = "First Time CheckIn";
                    FormElligibleToAddAttendence = true;
                }
                else if (subscription.LastCheckIn.Day == DateTime.UtcNow.Day)
                {
                    ValidateLastCheckin.Text = "Already CheckedIn Today";
                    CreateAttendencBtn.Enabled = false;
                }
                else
                {
                    LastCheckinBox.Text = subscription.LastCheckIn.ToString();
                    FormElligibleToAddAttendence = true;
                }
            }
            else
                SetValidation();

        }
    }
}
