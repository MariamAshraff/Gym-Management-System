using Gym_Management_System.Data.Context;
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

namespace Gym_Management_System
{
    public partial class LoginForm : Form
    {

        private readonly AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(new GymContext());

        }

        private void UserNametextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = _authService.Login(UserNametextbox.Text, Passwordtextbox.Text);

            //if (user != null)
            //{
            //    if (user.Role == "Admin")
            //        new AdminForm().Show();
            //    else
            //        new Form1().Show();

            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Login");
            //}

            if (user != null)
            {
                new AdminForm(user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
