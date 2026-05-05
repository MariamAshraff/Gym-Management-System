//namespace Gym_Management_System
//{
//    partial class LoginForm
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
//            UserNameLabel = new Label();
//            PasswordLabel = new Label();
//            UserNametextbox = new TextBox();
//            Passwordtextbox = new TextBox();
//            loginBtn = new Button();
//            SuspendLayout();
//            // 
//            // UserNameLabel
//            // 
//            UserNameLabel.AutoSize = true;
//            UserNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            UserNameLabel.Location = new Point(100, 49);
//            UserNameLabel.Name = "UserNameLabel";
//            UserNameLabel.Size = new Size(109, 25);
//            UserNameLabel.TabIndex = 0;
//            UserNameLabel.Text = "User Name";
//            // 
//            // PasswordLabel
//            // 
//            PasswordLabel.AutoSize = true;
//            PasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            PasswordLabel.Location = new Point(112, 146);
//            PasswordLabel.Name = "PasswordLabel";
//            PasswordLabel.Size = new Size(97, 25);
//            PasswordLabel.TabIndex = 1;
//            PasswordLabel.Text = "Password";
//            // 
//            // UserNametextbox
//            // 
//            UserNametextbox.Location = new Point(100, 87);
//            UserNametextbox.Name = "UserNametextbox";
//            UserNametextbox.Size = new Size(168, 23);
//            UserNametextbox.TabIndex = 2;
//            UserNametextbox.Tag = "";
//            UserNametextbox.Text = "Enter user name";
//            UserNametextbox.TextChanged += UserNametextbox_TextChanged;
//            // 
//            // Passwordtextbox
//            // 
//            Passwordtextbox.Location = new Point(100, 184);
//            Passwordtextbox.Name = "Passwordtextbox";
//            Passwordtextbox.Size = new Size(168, 23);
//            Passwordtextbox.TabIndex = 3;
//            Passwordtextbox.Text = "Enter password";
//            Passwordtextbox.TextChanged += Passwordtextbox_TextChanged;
//            // 
//            // loginBtn
//            // 
//            loginBtn.Location = new Point(134, 222);
//            loginBtn.Name = "loginBtn";
//            loginBtn.Size = new Size(75, 23);
//            loginBtn.TabIndex = 4;
//            loginBtn.Text = "Login";
//            loginBtn.UseVisualStyleBackColor = true;
//            loginBtn.Click += loginBtn_Click;
//            // 
//            // LoginForm
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(351, 266);
//            Controls.Add(loginBtn);
//            Controls.Add(Passwordtextbox);
//            Controls.Add(UserNametextbox);
//            Controls.Add(PasswordLabel);
//            Controls.Add(UserNameLabel);
//            Name = "LoginForm";
//            Text = "LoginForm";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label UserNameLabel;
//        private Label PasswordLabel;
//        private TextBox UserNametextbox;
//        private TextBox Passwordtextbox;
//        private Button loginBtn;
//    }
//}

//namespace Gym_Management_System
//{
//    partial class LoginForm
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            UserNameLabel = new Label();
//            PasswordLabel = new Label();
//            UserNametextbox = new TextBox();
//            Passwordtextbox = new TextBox();
//            loginBtn = new Button();
//            SuspendLayout();
//            // 
//            // UserNameLabel
//            // 
//            UserNameLabel.AutoSize = true;
//            UserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
//            UserNameLabel.ForeColor = Color.FromArgb(100, 150, 240);
//            UserNameLabel.Location = new Point(60, 45);
//            UserNameLabel.Name = "UserNameLabel";
//            UserNameLabel.Size = new Size(116, 28);
//            UserNameLabel.TabIndex = 0;
//            UserNameLabel.Text = "User Name";
//            // 
//            // PasswordLabel
//            // 
//            PasswordLabel.AutoSize = true;
//            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
//            PasswordLabel.ForeColor = Color.FromArgb(100, 150, 240);
//            PasswordLabel.Location = new Point(60, 145);
//            PasswordLabel.Name = "PasswordLabel";
//            PasswordLabel.Size = new Size(101, 28);
//            PasswordLabel.TabIndex = 1;
//            PasswordLabel.Text = "Password";
//            // 
//            // UserNametextbox
//            // 
//            UserNametextbox.BackColor = Color.FromArgb(25, 45, 75);
//            UserNametextbox.BorderStyle = BorderStyle.FixedSingle;
//            UserNametextbox.Font = new Font("Segoe UI", 12F);
//            UserNametextbox.ForeColor = Color.White;
//            UserNametextbox.Location = new Point(60, 80);
//            UserNametextbox.Name = "UserNametextbox";
//            UserNametextbox.PlaceholderText = "Enter user name";
//            UserNametextbox.Size = new Size(280, 34);
//            UserNametextbox.TabIndex = 2;
//            UserNametextbox.TextChanged += UserNametextbox_TextChanged;
//            // 
//            // Passwordtextbox
//            // 
//            Passwordtextbox.BackColor = Color.FromArgb(25, 45, 75);
//            Passwordtextbox.BorderStyle = BorderStyle.FixedSingle;
//            Passwordtextbox.Font = new Font("Segoe UI", 12F);
//            Passwordtextbox.ForeColor = Color.White;
//            Passwordtextbox.Location = new Point(60, 180);
//            Passwordtextbox.Name = "Passwordtextbox";
//            Passwordtextbox.PasswordChar = '●';
//            Passwordtextbox.PlaceholderText = "Enter password";
//            Passwordtextbox.Size = new Size(280, 34);
//            Passwordtextbox.TabIndex = 3;
//            Passwordtextbox.TextChanged += Passwordtextbox_TextChanged;
//            // 
//            // loginBtn
//            // 
//            loginBtn.BackColor = Color.FromArgb(20, 110, 210);
//            loginBtn.FlatAppearance.BorderSize = 0;
//            loginBtn.FlatStyle = FlatStyle.Flat;
//            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
//            loginBtn.ForeColor = Color.White;
//            loginBtn.Location = new Point(60, 260);
//            loginBtn.Name = "loginBtn";
//            loginBtn.Size = new Size(280, 45);
//            loginBtn.TabIndex = 4;
//            loginBtn.Text = "Login";
//            loginBtn.UseVisualStyleBackColor = false;
//            loginBtn.Click += loginBtn_Click;
//            // 
//            // LoginForm
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.FromArgb(5, 15, 35);
//            ClientSize = new Size(400, 380);
//            Controls.Add(loginBtn);
//            Controls.Add(Passwordtextbox);
//            Controls.Add(UserNametextbox);
//            Controls.Add(PasswordLabel);
//            Controls.Add(UserNameLabel);
//            FormBorderStyle = FormBorderStyle.FixedDialog;
//            MaximizeBox = false;
//            Name = "LoginForm";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Gym System - Login";
//            Load += LoginForm_Load;
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label UserNameLabel;
//        private Label PasswordLabel;
//        private TextBox UserNametextbox;
//        private TextBox Passwordtextbox;
//        private Button loginBtn;
//    }
//}

namespace Gym_Management_System
{
    partial class LoginForm
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
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNametextbox = new TextBox();
            Passwordtextbox = new TextBox();
            loginBtn = new Button();
            mainTableLayout = new TableLayoutPanel(); // جدول للتوسيط
            mainTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout (الحاوية الرئيسية للتوسيط)
            // 
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F)); // عرض منطقة تسجيل الدخول
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayout.Controls.Add(UserNameLabel, 1, 1);
            mainTableLayout.Controls.Add(UserNametextbox, 1, 2);
            mainTableLayout.Controls.Add(PasswordLabel, 1, 3);
            mainTableLayout.Controls.Add(Passwordtextbox, 1, 4);
            mainTableLayout.Controls.Add(loginBtn, 1, 6);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 8;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Label
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // TextBox
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // Label
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // TextBox
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F)); // Space
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F)); // Button
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTableLayout.Size = new Size(800, 600);
            mainTableLayout.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserNameLabel.ForeColor = Color.FromArgb(100, 150, 240);
            UserNameLabel.Location = new Point(228, 150);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(116, 28);
            UserNameLabel.Text = "User Name";
            // 
            // UserNametextbox
            // 
            UserNametextbox.BackColor = Color.FromArgb(25, 45, 75);
            UserNametextbox.BorderStyle = BorderStyle.FixedSingle;
            UserNametextbox.Font = new Font("Segoe UI", 14F); // تكبير الخط قليلاً
            UserNametextbox.ForeColor = Color.White;
            UserNametextbox.Location = new Point(228, 190);
            UserNametextbox.Name = "UserNametextbox";
            UserNametextbox.PlaceholderText = "Enter user name";
            UserNametextbox.Size = new Size(344, 39);
            UserNametextbox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PasswordLabel.ForeColor = Color.FromArgb(100, 150, 240);
            PasswordLabel.Location = new Point(228, 240);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(101, 28);
            PasswordLabel.Text = "Password";
            // 
            // Passwordtextbox
            // 
            Passwordtextbox.BackColor = Color.FromArgb(25, 45, 75);
            Passwordtextbox.BorderStyle = BorderStyle.FixedSingle;
            Passwordtextbox.Font = new Font("Segoe UI", 14F);
            Passwordtextbox.ForeColor = Color.White;
            Passwordtextbox.Location = new Point(228, 280);
            Passwordtextbox.Name = "Passwordtextbox";
            Passwordtextbox.PasswordChar = '●';
            Passwordtextbox.PlaceholderText = "Enter password";
            Passwordtextbox.Size = new Size(344, 39);
            Passwordtextbox.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(20, 110, 210);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(228, 350);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(344, 50);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 15, 35);
            ClientSize = new Size(800, 600);
            Controls.Add(mainTableLayout); // إضافة الحاوية المنظمة
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym System - Login";
            // السطرين القادمين هما المسؤولان عن ملء الشاشة عند الفتح
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNametextbox;
        private TextBox Passwordtextbox;
        private Button loginBtn;
        private TableLayoutPanel mainTableLayout; // تعريف الحاوية الجديدة
    }
}