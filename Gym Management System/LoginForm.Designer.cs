namespace Gym_Management_System
{
    partial class LoginForm
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
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNametextbox = new TextBox();
            Passwordtextbox = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(100, 49);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(109, 25);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "User Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(112, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(97, 25);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            // 
            // UserNametextbox
            // 
            UserNametextbox.Location = new Point(100, 87);
            UserNametextbox.Name = "UserNametextbox";
            UserNametextbox.Size = new Size(168, 23);
            UserNametextbox.TabIndex = 2;
            UserNametextbox.Tag = "";
            UserNametextbox.Text = "Enter user name";
            UserNametextbox.TextChanged += UserNametextbox_TextChanged;
            // 
            // Passwordtextbox
            // 
            Passwordtextbox.Location = new Point(100, 184);
            Passwordtextbox.Name = "Passwordtextbox";
            Passwordtextbox.Size = new Size(168, 23);
            Passwordtextbox.TabIndex = 3;
            Passwordtextbox.Text = "Enter password";
            Passwordtextbox.TextChanged += Passwordtextbox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(134, 222);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 266);
            Controls.Add(loginBtn);
            Controls.Add(Passwordtextbox);
            Controls.Add(UserNametextbox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNametextbox;
        private TextBox Passwordtextbox;
        private Button loginBtn;
    }
}