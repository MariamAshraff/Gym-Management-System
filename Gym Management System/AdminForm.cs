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
            var trainerService = new TrainerService(new GymContext());
            Form1 trainersForm = new Form1(trainerService);

            trainersForm.Show();

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(panelUsers);

        }

        //This will be updated to view reports Form for admin only
        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            var trainerService = new TrainerService(new GymContext());
            Form1 trainersForm = new Form1(trainerService);

            trainersForm.Show();

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
            var context = new GymContext();

            var traineeSubscriptionService = new TraineeSubscriptionService(context);
            var trainingProgramService = new TrainingProgramService(context);
            var traineesService = new TraineesService(context);
            var offerService = new OfferService(context);
            var paymentService = new PaymentService(context);

            IService service = new Service(context);

            var form = new TraineeSubscriptionFormcs(
                traineeSubscriptionService,
                trainingProgramService,
                traineesService,
                offerService,
                paymentService,
                service
            );

            form.Show();
        }

        private void TraineesAttendBtn_Click(object sender, EventArgs e)
        {
            var context = new GymContext();

            var traineeSubscriptionService = new TraineeSubscriptionService(context);
            var traineesService = new TraineesService(context);
            var traineeAttendenceService = new TraineeAttendenceService(context);

            var form = new TraineeAttendenceForm(
                traineeAttendenceService,
                traineeSubscriptionService,
                traineesService
            );

            form.ShowDialog();

        }

        private void TraineesBtn_Click(object sender, EventArgs e)
        {
            var form = new TraineesForm(traineesService);
            form.ShowDialog();

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

    }
}
