//namespace Gym_Management_System
//{
//    partial class AdminForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            TopPanel = new Panel();
//            TrainersForm = new Button();
//            UsersBtn = new Button();
//            LogoutBtn = new Button();
//            ReportsBtn = new Button();
//            SidebarPanel = new Panel();
//            TraineesBtn = new Button();
//            TraineesAttendBtn = new Button();
//            Subscriptions = new Button();
//            MainPanel = new Panel();
//            panelUsers = new Panel();
//            RemoveUserBtn = new Button();
//            dgvUsers = new DataGridView();
//            AddUserBtn = new Button();
//            UserNameLabel = new Label();
//            PasswordLabel = new Label();
//            PasswordTextbox = new TextBox();
//            RoleLabel = new Label();
//            cmbRole = new ComboBox();
//            UserNameTextBox = new TextBox();
//            SidebarPanel.SuspendLayout();
//            MainPanel.SuspendLayout();
//            panelUsers.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
//            SuspendLayout();
//            // 
//            // TopPanel
//            // 
//            TopPanel.Dock = DockStyle.Top;
//            TopPanel.Location = new Point(0, 0);
//            TopPanel.Name = "TopPanel";
//            TopPanel.Size = new Size(800, 100);
//            TopPanel.TabIndex = 1;
//            //TopPanel.Paint += TopPanel_Paint;
//            // 
//            // TrainersForm
//            // 
//            TrainersForm.Location = new Point(35, 6);
//            TrainersForm.Name = "TrainersForm";
//            TrainersForm.Size = new Size(110, 23);
//            TrainersForm.TabIndex = 0;
//            TrainersForm.Text = "Trainers";
//            TrainersForm.UseVisualStyleBackColor = true;
//            TrainersForm.Click += TrainersForm_Click;
//            // 
//            // UsersBtn
//            // 
//            UsersBtn.Location = new Point(35, 46);
//            UsersBtn.Name = "UsersBtn";
//            UsersBtn.Size = new Size(110, 23);
//            UsersBtn.TabIndex = 1;
//            UsersBtn.Text = "Users";
//            UsersBtn.UseVisualStyleBackColor = true;
//            UsersBtn.Click += UsersBtn_Click;
//            // 
//            // LogoutBtn
//            // 
//            LogoutBtn.Location = new Point(35, 440);
//            LogoutBtn.Name = "LogoutBtn";
//            LogoutBtn.Size = new Size(75, 23);
//            LogoutBtn.TabIndex = 0;
//            LogoutBtn.Text = "Logout";
//            LogoutBtn.UseVisualStyleBackColor = true;
//            LogoutBtn.Click += LogoutBtn_Click;
//            // 
//            // ReportsBtn
//            // 
//            ReportsBtn.Location = new Point(35, 91);
//            ReportsBtn.Name = "ReportsBtn";
//            ReportsBtn.Size = new Size(110, 23);
//            ReportsBtn.TabIndex = 2;
//            ReportsBtn.Text = "Reports";
//            ReportsBtn.UseVisualStyleBackColor = true;
//            ReportsBtn.Click += ReportsBtn_Click;
//            // 
//            // SidebarPanel
//            // 
//            SidebarPanel.Controls.Add(TraineesBtn);
//            SidebarPanel.Controls.Add(TraineesAttendBtn);
//            SidebarPanel.Controls.Add(Subscriptions);
//            SidebarPanel.Controls.Add(LogoutBtn);
//            SidebarPanel.Controls.Add(TrainersForm);
//            SidebarPanel.Controls.Add(ReportsBtn);
//            SidebarPanel.Controls.Add(UsersBtn);
//            SidebarPanel.Dock = DockStyle.Left;
//            SidebarPanel.Location = new Point(0, 100);
//            SidebarPanel.Name = "SidebarPanel";
//            SidebarPanel.Size = new Size(200, 475);
//            SidebarPanel.TabIndex = 2;
//            // 
//            // TraineesBtn
//            // 
//            TraineesBtn.Location = new Point(35, 217);
//            TraineesBtn.Name = "TraineesBtn";
//            TraineesBtn.Size = new Size(110, 23);
//            TraineesBtn.TabIndex = 13;
//            TraineesBtn.Text = "Trainee";
//            TraineesBtn.UseVisualStyleBackColor = true;
//            TraineesBtn.Click += TraineesBtn_Click;
//            // 
//            // TraineesAttendBtn
//            // 
//            TraineesAttendBtn.Location = new Point(35, 171);
//            TraineesAttendBtn.Name = "TraineesAttendBtn";
//            TraineesAttendBtn.Size = new Size(110, 23);
//            TraineesAttendBtn.TabIndex = 12;
//            TraineesAttendBtn.Text = "Attendance";
//            TraineesAttendBtn.UseVisualStyleBackColor = true;
//            TraineesAttendBtn.Click += TraineesAttendBtn_Click;
//            // 
//            // Subscriptions
//            // 
//            Subscriptions.Location = new Point(35, 133);
//            Subscriptions.Name = "Subscriptions";
//            Subscriptions.Size = new Size(110, 23);
//            Subscriptions.TabIndex = 12;
//            Subscriptions.Text = "Subscriptions";
//            Subscriptions.UseVisualStyleBackColor = true;
//            Subscriptions.Click += Subscriptions_Click;
//            // 
//            // MainPanel
//            // 
//            MainPanel.Controls.Add(panelUsers);
//            MainPanel.Dock = DockStyle.Fill;
//            MainPanel.Location = new Point(200, 100);
//            MainPanel.Name = "MainPanel";
//            MainPanel.Size = new Size(600, 475);
//            MainPanel.TabIndex = 3;
//            // 
//            // panelUsers
//            // 
//            panelUsers.BackColor = SystemColors.ActiveCaption;
//            panelUsers.Controls.Add(RemoveUserBtn);
//            panelUsers.Controls.Add(dgvUsers);
//            panelUsers.Controls.Add(AddUserBtn);
//            panelUsers.Controls.Add(UserNameLabel);
//            panelUsers.Controls.Add(PasswordLabel);
//            panelUsers.Controls.Add(PasswordTextbox);
//            panelUsers.Controls.Add(RoleLabel);
//            panelUsers.Controls.Add(cmbRole);
//            panelUsers.Controls.Add(UserNameTextBox);
//            panelUsers.Location = new Point(9, 6);
//            panelUsers.Name = "panelUsers";
//            panelUsers.Size = new Size(579, 466);
//            panelUsers.TabIndex = 0;
//            // 
//            // RemoveUserBtn
//            // 
//            RemoveUserBtn.Location = new Point(205, 152);
//            RemoveUserBtn.Name = "RemoveUserBtn";
//            RemoveUserBtn.Size = new Size(75, 23);
//            RemoveUserBtn.TabIndex = 11;
//            RemoveUserBtn.Text = "Remove";
//            RemoveUserBtn.UseVisualStyleBackColor = true;
//            RemoveUserBtn.Click += RemoveUserBtn_Click;
//            // 
//            // dgvUsers
//            // 
//            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dgvUsers.Location = new Point(3, 211);
//            dgvUsers.MultiSelect = false;
//            dgvUsers.Name = "dgvUsers";
//            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//            dgvUsers.Size = new Size(573, 246);
//            dgvUsers.TabIndex = 10;
//            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
//            // 
//            // AddUserBtn
//            // 
//            AddUserBtn.Location = new Point(81, 152);
//            AddUserBtn.Name = "AddUserBtn";
//            AddUserBtn.Size = new Size(75, 23);
//            AddUserBtn.TabIndex = 4;
//            AddUserBtn.Text = "Add";
//            AddUserBtn.UseVisualStyleBackColor = true;
//            AddUserBtn.Click += AddUserBtn_Click;
//            // 
//            // UserNameLabel
//            // 
//            UserNameLabel.AutoSize = true;
//            UserNameLabel.Location = new Point(3, 13);
//            UserNameLabel.Name = "UserNameLabel";
//            UserNameLabel.Size = new Size(60, 15);
//            UserNameLabel.TabIndex = 3;
//            UserNameLabel.Text = "Username";
//            // 
//            // PasswordLabel
//            // 
//            PasswordLabel.AutoSize = true;
//            PasswordLabel.Location = new Point(0, 58);
//            PasswordLabel.Name = "PasswordLabel";
//            PasswordLabel.Size = new Size(57, 15);
//            PasswordLabel.TabIndex = 6;
//            PasswordLabel.Text = "Password";
//            // 
//            // PasswordTextbox
//            // 
//            PasswordTextbox.Location = new Point(81, 55);
//            PasswordTextbox.Name = "PasswordTextbox";
//            PasswordTextbox.Size = new Size(199, 23);
//            PasswordTextbox.TabIndex = 7;
//            // 
//            // RoleLabel
//            // 
//            RoleLabel.AutoSize = true;
//            RoleLabel.Location = new Point(3, 93);
//            RoleLabel.Name = "RoleLabel";
//            RoleLabel.Size = new Size(30, 15);
//            RoleLabel.TabIndex = 8;
//            RoleLabel.Text = "Role";
//            // 
//            // cmbRole
//            // 
//            cmbRole.FormattingEnabled = true;
//            cmbRole.Location = new Point(81, 94);
//            cmbRole.Name = "cmbRole";
//            cmbRole.Size = new Size(199, 23);
//            cmbRole.TabIndex = 9;
//            // 
//            // UserNameTextBox
//            // 
//            UserNameTextBox.Location = new Point(81, 10);
//            UserNameTextBox.Name = "UserNameTextBox";
//            UserNameTextBox.Size = new Size(199, 23);
//            UserNameTextBox.TabIndex = 5;
//            // 
//            // AdminForm
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 575);
//            Controls.Add(MainPanel);
//            Controls.Add(SidebarPanel);
//            Controls.Add(TopPanel);
//            Name = "AdminForm";
//            Text = "Admin Dashboard";
//            Load += AdminForm_Load;
//            SidebarPanel.ResumeLayout(false);
//            MainPanel.ResumeLayout(false);
//            panelUsers.ResumeLayout(false);
//            panelUsers.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion

//        private Panel PanelSidebar;
//        private Button DashboardBtn;
//        private Panel TopPanel;
//        private Panel panel2;
//        private Button ReportsBtn;
//        private Button LogoutBtn;
//        private Button UsersBtn;
//        private Panel SidebarPanel;
//        private Panel MainPanel;
//        private Panel panelDashboard;
//        private Panel panelUsers;
//        private Panel panelReports;
//        private TextBox UserNameTextBox;
//        private Button AddUserBtn;
//        private Label UserNameLabel;
//        private ComboBox cmbRole;
//        private Label RoleLabel;
//        private TextBox PasswordTextbox;
//        private Label PasswordLabel;
//        private DataGridView dgvUsers;
//        private Button RemoveUserBtn;
//        private Button TrainersForm;
//        private Button Subscriptions;
//        private Button TraineesAttendBtn;
//        private Button TraineesBtn;
//    }
//}

namespace Gym_Management_System
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TopPanel = new Panel();
            SidebarPanel = new Panel();
            TraineesBtn = new Button();
            TraineesAttendBtn = new Button();
            Subscriptions = new Button();
            LogoutBtn = new Button();
            TrainersForm = new Button();
            ReportsBtn = new Button();
            UsersBtn = new Button();
            MainPanel = new Panel();
            panelUsers = new Panel();
            RemoveUserBtn = new Button();
            dgvUsers = new DataGridView();
            AddUserBtn = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextbox = new TextBox();
            RoleLabel = new Label();
            cmbRole = new ComboBox();
            UserNameTextBox = new TextBox();
            SidebarPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(20, 30, 50);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Margin = new Padding(3, 4, 3, 4);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1257, 93);
            TopPanel.TabIndex = 1;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(25, 45, 75);
            SidebarPanel.Controls.Add(TraineesBtn);
            SidebarPanel.Controls.Add(TraineesAttendBtn);
            SidebarPanel.Controls.Add(Subscriptions);
            SidebarPanel.Controls.Add(LogoutBtn);
            SidebarPanel.Controls.Add(TrainersForm);
            SidebarPanel.Controls.Add(ReportsBtn);
            SidebarPanel.Controls.Add(UsersBtn);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 93);
            SidebarPanel.Margin = new Padding(3, 4, 3, 4);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Padding = new Padding(17, 27, 17, 27);
            SidebarPanel.Size = new Size(263, 840);
            SidebarPanel.TabIndex = 2;
            // 
            // TraineesBtn
            // 
            TraineesBtn.Dock = DockStyle.Top;
            TraineesBtn.FlatAppearance.BorderSize = 0;
            TraineesBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            TraineesBtn.FlatStyle = FlatStyle.Flat;
            TraineesBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TraineesBtn.ForeColor = Color.White;
            TraineesBtn.Location = new Point(17, 362);
            TraineesBtn.Margin = new Padding(3, 4, 3, 4);
            TraineesBtn.Name = "TraineesBtn";
            TraineesBtn.Size = new Size(229, 67);
            TraineesBtn.TabIndex = 13;
            TraineesBtn.Text = "👤 Trainee";
            TraineesBtn.TextAlign = ContentAlignment.MiddleLeft;
            TraineesBtn.UseVisualStyleBackColor = true;
            TraineesBtn.Click += TraineesBtn_Click;
            // 
            // TraineesAttendBtn
            // 
            TraineesAttendBtn.Dock = DockStyle.Top;
            TraineesAttendBtn.FlatAppearance.BorderSize = 0;
            TraineesAttendBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            TraineesAttendBtn.FlatStyle = FlatStyle.Flat;
            TraineesAttendBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TraineesAttendBtn.ForeColor = Color.White;
            TraineesAttendBtn.Location = new Point(17, 295);
            TraineesAttendBtn.Margin = new Padding(3, 4, 3, 4);
            TraineesAttendBtn.Name = "TraineesAttendBtn";
            TraineesAttendBtn.Size = new Size(229, 67);
            TraineesAttendBtn.TabIndex = 12;
            TraineesAttendBtn.Text = "📅 Attendance";
            TraineesAttendBtn.TextAlign = ContentAlignment.MiddleLeft;
            TraineesAttendBtn.UseVisualStyleBackColor = true;
            TraineesAttendBtn.Click += TraineesAttendBtn_Click;
            // 
            // Subscriptions
            // 
            Subscriptions.Dock = DockStyle.Top;
            Subscriptions.FlatAppearance.BorderSize = 0;
            Subscriptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            Subscriptions.FlatStyle = FlatStyle.Flat;
            Subscriptions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Subscriptions.ForeColor = Color.White;
            Subscriptions.Location = new Point(17, 228);
            Subscriptions.Margin = new Padding(3, 4, 3, 4);
            Subscriptions.Name = "Subscriptions";
            Subscriptions.Size = new Size(229, 67);
            Subscriptions.TabIndex = 12;
            Subscriptions.Text = "💳 Subscriptions";
            Subscriptions.TextAlign = ContentAlignment.MiddleLeft;
            Subscriptions.UseVisualStyleBackColor = true;
            Subscriptions.Click += Subscriptions_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(192, 0, 0);
            LogoutBtn.Dock = DockStyle.Bottom;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(17, 760);
            LogoutBtn.Margin = new Padding(3, 4, 3, 4);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(229, 53);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "🚪 Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // TrainersForm
            // 
            TrainersForm.Dock = DockStyle.Top;
            TrainersForm.FlatAppearance.BorderSize = 0;
            TrainersForm.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            TrainersForm.FlatStyle = FlatStyle.Flat;
            TrainersForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            TrainersForm.ForeColor = Color.White;
            TrainersForm.Location = new Point(17, 161);
            TrainersForm.Margin = new Padding(3, 4, 3, 4);
            TrainersForm.Name = "TrainersForm";
            TrainersForm.Size = new Size(229, 67);
            TrainersForm.TabIndex = 0;
            TrainersForm.Text = "🏋️ Trainers";
            TrainersForm.TextAlign = ContentAlignment.MiddleLeft;
            TrainersForm.UseVisualStyleBackColor = true;
            TrainersForm.Click += TrainersForm_Click;
            // 
            // ReportsBtn
            // 
            ReportsBtn.Dock = DockStyle.Top;
            ReportsBtn.FlatAppearance.BorderSize = 0;
            ReportsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            ReportsBtn.FlatStyle = FlatStyle.Flat;
            ReportsBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ReportsBtn.ForeColor = Color.White;
            ReportsBtn.Location = new Point(17, 94);
            ReportsBtn.Margin = new Padding(3, 4, 3, 4);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(229, 67);
            ReportsBtn.TabIndex = 2;
            ReportsBtn.Text = "📊 Reports";
            ReportsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ReportsBtn.UseVisualStyleBackColor = true;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // UsersBtn
            // 
            UsersBtn.Dock = DockStyle.Top;
            UsersBtn.FlatAppearance.BorderSize = 0;
            UsersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            UsersBtn.FlatStyle = FlatStyle.Flat;
            UsersBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            UsersBtn.ForeColor = Color.White;
            UsersBtn.Location = new Point(17, 27);
            UsersBtn.Margin = new Padding(3, 4, 3, 4);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Size = new Size(229, 67);
            UsersBtn.TabIndex = 1;
            UsersBtn.Text = "👥 Users";
            UsersBtn.TextAlign = ContentAlignment.MiddleLeft;
            UsersBtn.UseVisualStyleBackColor = true;
            UsersBtn.Click += UsersBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(panelUsers);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(263, 93);
            MainPanel.Margin = new Padding(3, 4, 3, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(23, 27, 23, 27);
            MainPanel.Size = new Size(994, 840);
            MainPanel.TabIndex = 3;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // panelUsers
            // 
            panelUsers.BackColor = Color.FromArgb(30, 40, 60);
            panelUsers.Controls.Add(RemoveUserBtn);
            panelUsers.Controls.Add(dgvUsers);
            panelUsers.Controls.Add(AddUserBtn);
            panelUsers.Controls.Add(UserNameLabel);
            panelUsers.Controls.Add(PasswordLabel);
            panelUsers.Controls.Add(PasswordTextbox);
            panelUsers.Controls.Add(RoleLabel);
            panelUsers.Controls.Add(cmbRole);
            panelUsers.Controls.Add(UserNameTextBox);
            panelUsers.Dock = DockStyle.Fill;
            panelUsers.Location = new Point(23, 27);
            panelUsers.Margin = new Padding(3, 4, 3, 4);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(948, 786);
            panelUsers.TabIndex = 0;
            // 
            // RemoveUserBtn
            // 
            RemoveUserBtn.BackColor = Color.FromArgb(192, 0, 0);
            RemoveUserBtn.FlatAppearance.BorderSize = 0;
            RemoveUserBtn.FlatStyle = FlatStyle.Flat;
            RemoveUserBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RemoveUserBtn.ForeColor = Color.White;
            RemoveUserBtn.Location = new Point(291, 220);
            RemoveUserBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveUserBtn.Name = "RemoveUserBtn";
            RemoveUserBtn.Size = new Size(137, 53);
            RemoveUserBtn.TabIndex = 11;
            RemoveUserBtn.Text = "Remove";
            RemoveUserBtn.UseVisualStyleBackColor = false;
            RemoveUserBtn.Click += RemoveUserBtn_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(29, 307);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(890, 446);
            dgvUsers.TabIndex = 10;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(20, 110, 210);
            AddUserBtn.FlatAppearance.BorderSize = 0;
            AddUserBtn.FlatStyle = FlatStyle.Flat;
            AddUserBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(131, 220);
            AddUserBtn.Margin = new Padding(3, 4, 3, 4);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(137, 53);
            AddUserBtn.TabIndex = 4;
            AddUserBtn.Text = "Add";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UserNameLabel.ForeColor = Color.FromArgb(100, 150, 240);
            UserNameLabel.Location = new Point(29, 33);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(89, 23);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PasswordLabel.ForeColor = Color.FromArgb(100, 150, 240);
            PasswordLabel.Location = new Point(29, 93);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(85, 23);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackColor = Color.FromArgb(25, 45, 75);
            PasswordTextbox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextbox.Font = new Font("Segoe UI", 10F);
            PasswordTextbox.ForeColor = Color.White;
            PasswordTextbox.Location = new Point(131, 91);
            PasswordTextbox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '●';
            PasswordTextbox.Size = new Size(297, 30);
            PasswordTextbox.TabIndex = 7;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RoleLabel.ForeColor = Color.FromArgb(100, 150, 240);
            RoleLabel.Location = new Point(29, 153);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(45, 23);
            RoleLabel.TabIndex = 8;
            RoleLabel.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.FromArgb(25, 45, 75);
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 10F);
            cmbRole.ForeColor = Color.White;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(131, 151);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(297, 31);
            cmbRole.TabIndex = 9;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BackColor = Color.FromArgb(25, 45, 75);
            UserNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTextBox.Font = new Font("Segoe UI", 10F);
            UserNameTextBox.ForeColor = Color.White;
            UserNameTextBox.Location = new Point(131, 31);
            UserNameTextBox.Margin = new Padding(3, 4, 3, 4);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(297, 30);
            UserNameTextBox.TabIndex = 5;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 15, 35);
            ClientSize = new Size(1257, 933);
            Controls.Add(MainPanel);
            Controls.Add(SidebarPanel);
            Controls.Add(TopPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
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

        private Panel TopPanel;
        private Button TrainersForm;
        private Button UsersBtn;
        private Button LogoutBtn;
        private Button ReportsBtn;
        private Panel SidebarPanel;
        private Button TraineesBtn;
        private Button TraineesAttendBtn;
        private Button Subscriptions;
        private Panel MainPanel;
        private Panel panelUsers;
        private Button RemoveUserBtn;
        private DataGridView dgvUsers;
        private Button AddUserBtn;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextbox;
        private Label RoleLabel;
        private ComboBox cmbRole;
        private TextBox UserNameTextBox;
    }
}