using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Implementation;
using Gym_Management_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gym_Management_System
{
    public partial class AdminForm : Form
    {
        private User _currentUser;

        private readonly AdminService _adminService;

        private ITraineesService traineesService;
        public AdminForm(User user)
        {
            InitializeComponent();
            _adminService = new AdminService(new GymContext());
            _currentUser = user;
            traineesService = new TraineesService(new GymContext());


        }


        //======//===[1]====Form OnLoading Method
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeRoleComboBox();
            //ShowPanel(panelUsers); //
            panelUsers.Visible = false;

            LoadUsers();
            ApplyPermissions();
        }

        //=======[2]=====IniTialize ComboBox (User Role)
        private void InitializeRoleComboBox()
        {
            cmbRole.Items.Clear();

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Receptionist");

            cmbRole.SelectedIndex = 0;
        }
        //Panel Navigator
        private void ShowPanel(Panel panel)
        {
            //panelDashboard.Visible = false;
            panelUsers.Visible = false;
            //panelReports.Visible = false;

            panel.Visible = true;
        }

        private void TrainersForm_Click(object sender, EventArgs e)
        {
            //var trainerService = new TrainerService(new GymContext());
            //Form1 trainersForm = new Form1(trainerService);

            //trainersForm.Show();
            var trainerService = new TrainerService(new GymContext());
            Form1 trainersForm = new Form1(trainerService);

            trainersForm.TopLevel = false;
            trainersForm.FormBorderStyle = FormBorderStyle.None;

            ShowPanel1(trainersForm);
            trainersForm.Show();

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ShowPanel1(panelUsers);

           // ShowPanel(panelUsers);

        }

        //This will be updated to view reports Form for admin only
        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            //var reports = new Reports(new GymContext());
            ////Form1 trainersForm = new Form1(trainerService);

            //reports.Show();
            panelUsers.Visible = false;

            // 2. إنشاء نسخة من فورم التقارير
            var reportsForm = new Reports(new GymContext());

            // 3. ضبط خصائص الفورم ليتمكن من الدخول داخل البانل
            reportsForm.TopLevel = false;          // مهم جداً لكي لا يفتح كنافذة مستقلة
            reportsForm.FormBorderStyle = FormBorderStyle.None; // لإزالة الحواف وشريط العنوان
            reportsForm.Dock = DockStyle.Fill;     // لكي يملأ مساحة البانل بالكامل

            // 4. تنظيف البانل الرئيسي من أي محتوى قديم وإضافة فورم التقارير
            MainPanel.Controls.Clear();            // "MainPanel" هو البانل الذي تريدين العرض فيه
            MainPanel.Controls.Add(reportsForm);

            // 5. إظهار الفورم
            reportsForm.Show();

            // إذا كان لديكِ بانل مخصص للتقارير مثل panelUsers، تأكدي من إظهاره
            MainPanel.Visible = true;

        }
        private void ShowPanel1(Control controlToShow)
        {
            // 1. مسح كل شيء موجود داخل البانل الرئيسي حالياً (سواء فورم تقارير أو بانل مستخدمين)
            MainPanel.Controls.Clear();

            // 2. ضبط العنصر الجديد ليمتد ويملأ البانل بالكامل
            controlToShow.Dock = DockStyle.Fill;

            // 3. إضافة العنصر (البانل أو الفورم) للبانل الرئيسي
            MainPanel.Controls.Add(controlToShow);

            // 4. التأكد من أنه مرئي
            controlToShow.Visible = true;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            _adminService.AddUser(
            UserNameTextBox.Text,
            PasswordTextbox.Text,
            cmbRole.Text
        );

            MessageBox.Show("User Added Successfully");
            LoadUsers();
            ClearFields();
        }
        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var idValue = dgvUsers.SelectedRows[0].Cells["Id"].Value;

                if (idValue != null)
                {
                    int id = Convert.ToInt32(idValue);

                    _adminService.RemoveUser(id);

                    MessageBox.Show("User Deleted Successfully");

                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user first");
            }
        }

        //Loading Users 
        private void LoadUsers()
        {
            using (var context = new GymContext())
            {
                dgvUsers.DataSource = context.Users
                    .Select(u => new
                    {
                        u.Id,
                        u.Username,
                        u.Role
                    })
                    .ToList();
            }
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();

        }
        private void ClearFields()
        {
            UserNameTextBox.Clear();
            PasswordTextbox.Clear();
            cmbRole.SelectedIndex = 0;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Subscriptions_Click(object sender, EventArgs e)
        {
            //var context = new GymContext();

            //var traineeSubscriptionService = new TraineeSubscriptionService(context);
            //var trainingProgramService = new TrainingProgramService(context);
            //var traineesService = new TraineesService(context);
            //var offerService = new OfferService(context);
            //var paymentService = new PaymentService(context);

            //IService service = new Service(context);

            //var form = new TraineeSubscriptionFormcs(
            //    traineeSubscriptionService,
            //    trainingProgramService,
            //    traineesService,
            //    offerService,
            //    paymentService,
            //    service
            //);

            //form.Show();
            var context = new GymContext();
            // ... (نفس تعريف الخدمات الموجود عندك) ...
            var traineeSubscriptionService = new TraineeSubscriptionService(context);
            var trainingProgramService = new TrainingProgramService(context);
            var traineesService = new TraineesService(context);
            var offerService = new OfferService(context);
            var paymentService = new PaymentService(context);
            IService service = new Service(context);

            var form = new TraineeSubscriptionFormcs(traineeSubscriptionService, trainingProgramService, traineesService, offerService, paymentService, service);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            ShowPanel1(form);
            form.Show();
        }

        private void TraineesAttendBtn_Click(object sender, EventArgs e)
        {
            //var context = new GymContext();

            //var traineeSubscriptionService = new TraineeSubscriptionService(context);
            //var traineesService = new TraineesService(context);
            //var traineeAttendenceService = new TraineeAttendenceService(context);

            //var form = new TraineeAttendenceForm(
            //    traineeAttendenceService,
            //    traineeSubscriptionService,
            //    traineesService
            //);

            //form.ShowDialog();
            var context = new GymContext();

            var traineeSubscriptionService = new TraineeSubscriptionService(context);
            var traineesService = new TraineesService(context);
            var traineeAttendenceService = new TraineeAttendenceService(context);

            var form = new TraineeAttendenceForm(
                traineeAttendenceService,
                traineeSubscriptionService,
                traineesService
            );

            // التعديلات الجديدة للعرض داخل البانل:
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            // استدعاء ميثود التبديل التي قمنا بإنشائها
            ShowPanel1(form);

            form.Show();

        }

        private void TraineesBtn_Click(object sender, EventArgs e)
        {
            //var form = new TraineesForm(traineesService);
            //form.ShowDialog();
            var form = new TraineesForm(traineesService);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            ShowPanel1(form);
            form.Show();

        }
        private void ApplyPermissions()
        {
            if (_currentUser.Role != "Admin")
            {
                // Buttons

                UsersBtn.Visible = false;
                MainPanel.Visible = false;

                // Sections
                ReportsBtn.Visible = false;

                // Forms buttons
                TrainersForm.Visible = false;
            }

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
