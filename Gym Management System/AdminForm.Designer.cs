namespace Gym_Management_System
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopPanel = new Panel();
            DashboardBtn = new Button();
            UsersBtn = new Button();
            LogoutBtn = new Button();
            ReportsBtn = new Button();
            SidebarPanel = new Panel();
            MainPanel = new Panel();
            panelUsers = new Panel();
            dgvUsers = new DataGridView();
            AddUserBtn = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextbox = new TextBox();
            RoleLabel = new Label();
            cmbRole = new ComboBox();
            UserNameTextBox = new TextBox();
            panelDashboard = new Panel();
            panelReports = new Panel();
            SidebarPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 100);
            TopPanel.TabIndex = 1;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Location = new Point(35, 27);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(75, 23);
            DashboardBtn.TabIndex = 0;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = true;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // UsersBtn
            // 
            UsersBtn.Location = new Point(35, 89);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Size = new Size(75, 23);
            UsersBtn.TabIndex = 1;
            UsersBtn.Text = "Users";
            UsersBtn.UseVisualStyleBackColor = true;
            UsersBtn.Click += UsersBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(35, 196);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(75, 23);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ReportsBtn
            // 
            ReportsBtn.Location = new Point(35, 142);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(75, 23);
            ReportsBtn.TabIndex = 2;
            ReportsBtn.Text = "Reports";
            ReportsBtn.UseVisualStyleBackColor = true;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // SidebarPanel
            // 
            SidebarPanel.Controls.Add(LogoutBtn);
            SidebarPanel.Controls.Add(DashboardBtn);
            SidebarPanel.Controls.Add(ReportsBtn);
            SidebarPanel.Controls.Add(UsersBtn);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 100);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(200, 350);
            SidebarPanel.TabIndex = 2;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(panelUsers);
            MainPanel.Controls.Add(panelDashboard);
            MainPanel.Controls.Add(panelReports);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(200, 100);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(600, 350);
            MainPanel.TabIndex = 3;
            // 
            // panelUsers
            // 
            panelUsers.BackColor = SystemColors.ActiveCaption;
            panelUsers.Controls.Add(dgvUsers);
            panelUsers.Controls.Add(AddUserBtn);
            panelUsers.Controls.Add(UserNameLabel);
            panelUsers.Controls.Add(PasswordLabel);
            panelUsers.Controls.Add(PasswordTextbox);
            panelUsers.Controls.Add(RoleLabel);
            panelUsers.Controls.Add(cmbRole);
            panelUsers.Controls.Add(UserNameTextBox);
            panelUsers.Location = new Point(9, 18);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(347, 311);
            panelUsers.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(0, 152);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(347, 159);
            dgvUsers.TabIndex = 10;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(81, 123);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(75, 23);
            AddUserBtn.TabIndex = 4;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(3, 13);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(60, 15);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(0, 58);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(81, 55);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(100, 23);
            PasswordTextbox.TabIndex = 7;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Location = new Point(3, 93);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(30, 15);
            RoleLabel.TabIndex = 8;
            RoleLabel.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(81, 94);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 9;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(81, 10);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(100, 23);
            UserNameTextBox.TabIndex = 5;
            // 
            // panelDashboard
            // 
            panelDashboard.Location = new Point(386, 18);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(89, 40);
            panelDashboard.TabIndex = 0;
            panelDashboard.Visible = false;
            // 
            // panelReports
            // 
            panelReports.Location = new Point(386, 64);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(89, 48);
            panelReports.TabIndex = 0;
            panelReports.Visible = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Controls.Add(SidebarPanel);
            Controls.Add(TopPanel);
            Name = "AdminForm";
            Text = "Admin Dashboard";
            Load += AdminForm_Load;
            SidebarPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            panelUsers.ResumeLayout(false);
            panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSidebar;
        private Button DashboardBtn;
        private Panel TopPanel;
        private Panel panel2;
        private Button ReportsBtn;
        private Button LogoutBtn;
        private Button UsersBtn;
        private Panel SidebarPanel;
        private Panel MainPanel;
        private Panel panelDashboard;
        private Panel panelUsers;
        private Panel panelReports;
        private TextBox UserNameTextBox;
        private Button AddUserBtn;
        private Label UserNameLabel;
        private ComboBox cmbRole;
        private Label RoleLabel;
        private TextBox PasswordTextbox;
        private Label PasswordLabel;
        private DataGridView dgvUsers;
    }
}