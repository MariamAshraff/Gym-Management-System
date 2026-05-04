using Gym_Management_System.Data.Context;
using Gym_Management_System.Services.Interfaces;

using Gym_Management_System.Services.Implementation;
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
using Gym_Management_System.Data.Models;

namespace Gym_Management_System
{
    public partial class AdminForm : Form
    {
        private User _currentUser;

        private readonly AdminService _adminService;

        public AdminForm(User user)
        {
            InitializeComponent();
            _adminService = new AdminService(new GymContext());
            _currentUser = user;

        }


        //======//===[1]====Form OnLoading Method
        private void AdminForm_Load(object sender, EventArgs e)
        {
            InitializeRoleComboBox();
            ShowPanel(panelUsers); //

            LoadUsers();

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
            panelDashboard.Visible = false;
            panelUsers.Visible = false;
            panelReports.Visible = false;

            panel.Visible = true;
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(panelDashboard);

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(panelUsers);

        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(panelReports);

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
    }
}
