namespace Gym_Management_System
{
    partial class TraineeAttendenceForm
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
            TraineeAttendencGroupBox = new GroupBox();
            CardStatusBox = new TextBox();
            SubScriptionStatusLbl = new Label();
            ValidateLastCheckin = new TextBox();
            LastCheckinBox = new TextBox();
            label2 = new Label();
            CheckInBox = new TextBox();
            ValidateSubscriptionId = new TextBox();
            CreateAttendencBtn = new Button();
            TraineeNameBox = new TextBox();
            SubscriptionIdBox = new TextBox();
            TraineeNameLbl = new Label();
            label1 = new Label();
            SubscriptionIdLbl = new Label();
            TraineeAttendencGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TraineeAttendencGroupBox
            // 
            TraineeAttendencGroupBox.Controls.Add(CardStatusBox);
            TraineeAttendencGroupBox.Controls.Add(SubScriptionStatusLbl);
            TraineeAttendencGroupBox.Controls.Add(ValidateLastCheckin);
            TraineeAttendencGroupBox.Controls.Add(LastCheckinBox);
            TraineeAttendencGroupBox.Controls.Add(label2);
            TraineeAttendencGroupBox.Controls.Add(CheckInBox);
            TraineeAttendencGroupBox.Controls.Add(ValidateSubscriptionId);
            TraineeAttendencGroupBox.Controls.Add(CreateAttendencBtn);
            TraineeAttendencGroupBox.Controls.Add(TraineeNameBox);
            TraineeAttendencGroupBox.Controls.Add(SubscriptionIdBox);
            TraineeAttendencGroupBox.Controls.Add(TraineeNameLbl);
            TraineeAttendencGroupBox.Controls.Add(label1);
            TraineeAttendencGroupBox.Controls.Add(SubscriptionIdLbl);
            TraineeAttendencGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TraineeAttendencGroupBox.Location = new Point(210, 42);
            TraineeAttendencGroupBox.Name = "TraineeAttendencGroupBox";
            TraineeAttendencGroupBox.Size = new Size(549, 478);
            TraineeAttendencGroupBox.TabIndex = 0;
            TraineeAttendencGroupBox.TabStop = false;
            TraineeAttendencGroupBox.Text = "TraineeAttendence";
            // 
            // CardStatusBox
            // 
            CardStatusBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CardStatusBox.Location = new Point(180, 253);
            CardStatusBox.Name = "CardStatusBox";
            CardStatusBox.ReadOnly = true;
            CardStatusBox.Size = new Size(288, 25);
            CardStatusBox.TabIndex = 21;
            // 
            // SubScriptionStatusLbl
            // 
            SubScriptionStatusLbl.AutoSize = true;
            SubScriptionStatusLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SubScriptionStatusLbl.Location = new Point(42, 256);
            SubScriptionStatusLbl.Name = "SubScriptionStatusLbl";
            SubScriptionStatusLbl.Size = new Size(97, 19);
            SubScriptionStatusLbl.TabIndex = 20;
            SubScriptionStatusLbl.Text = "Card Status : ";
            // 
            // ValidateLastCheckin
            // 
            ValidateLastCheckin.BackColor = SystemColors.Control;
            ValidateLastCheckin.BorderStyle = BorderStyle.None;
            ValidateLastCheckin.ForeColor = Color.Red;
            ValidateLastCheckin.Location = new Point(180, 223);
            ValidateLastCheckin.Name = "ValidateLastCheckin";
            ValidateLastCheckin.ReadOnly = true;
            ValidateLastCheckin.Size = new Size(288, 22);
            ValidateLastCheckin.TabIndex = 19;
            // 
            // LastCheckinBox
            // 
            LastCheckinBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastCheckinBox.Location = new Point(180, 182);
            LastCheckinBox.Name = "LastCheckinBox";
            LastCheckinBox.ReadOnly = true;
            LastCheckinBox.Size = new Size(288, 25);
            LastCheckinBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 190);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 17;
            label2.Text = "Last Checkin : ";
            // 
            // CheckInBox
            // 
            CheckInBox.Location = new Point(180, 316);
            CheckInBox.Name = "CheckInBox";
            CheckInBox.ReadOnly = true;
            CheckInBox.Size = new Size(288, 29);
            CheckInBox.TabIndex = 16;
            // 
            // ValidateSubscriptionId
            // 
            ValidateSubscriptionId.BackColor = SystemColors.Control;
            ValidateSubscriptionId.BorderStyle = BorderStyle.None;
            ValidateSubscriptionId.ForeColor = Color.Red;
            ValidateSubscriptionId.Location = new Point(180, 72);
            ValidateSubscriptionId.Name = "ValidateSubscriptionId";
            ValidateSubscriptionId.ReadOnly = true;
            ValidateSubscriptionId.Size = new Size(288, 22);
            ValidateSubscriptionId.TabIndex = 15;
            // 
            // CreateAttendencBtn
            // 
            CreateAttendencBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateAttendencBtn.Location = new Point(228, 398);
            CreateAttendencBtn.Name = "CreateAttendencBtn";
            CreateAttendencBtn.Padding = new Padding(2);
            CreateAttendencBtn.Size = new Size(79, 32);
            CreateAttendencBtn.TabIndex = 14;
            CreateAttendencBtn.Text = "Submit";
            CreateAttendencBtn.UseVisualStyleBackColor = true;
            CreateAttendencBtn.Click += CreateAttendencBtn_Click;
            // 
            // TraineeNameBox
            // 
            TraineeNameBox.Location = new Point(180, 120);
            TraineeNameBox.Name = "TraineeNameBox";
            TraineeNameBox.ReadOnly = true;
            TraineeNameBox.Size = new Size(288, 29);
            TraineeNameBox.TabIndex = 13;
            // 
            // SubscriptionIdBox
            // 
            SubscriptionIdBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubscriptionIdBox.Location = new Point(180, 33);
            SubscriptionIdBox.Name = "SubscriptionIdBox";
            SubscriptionIdBox.Size = new Size(288, 25);
            SubscriptionIdBox.TabIndex = 12;
            SubscriptionIdBox.TextChanged += SubscriptionIdBox_TextChanged;
            // 
            // TraineeNameLbl
            // 
            TraineeNameLbl.AutoSize = true;
            TraineeNameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TraineeNameLbl.Location = new Point(42, 120);
            TraineeNameLbl.Name = "TraineeNameLbl";
            TraineeNameLbl.Size = new Size(101, 17);
            TraineeNameLbl.TabIndex = 11;
            TraineeNameLbl.Text = "Trainee Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 322);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 10;
            label1.Text = "Check In : ";
            // 
            // SubscriptionIdLbl
            // 
            SubscriptionIdLbl.AutoSize = true;
            SubscriptionIdLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubscriptionIdLbl.Location = new Point(42, 33);
            SubscriptionIdLbl.Name = "SubscriptionIdLbl";
            SubscriptionIdLbl.Size = new Size(109, 17);
            SubscriptionIdLbl.TabIndex = 9;
            SubscriptionIdLbl.Text = "Subscription Id :";
            // 
            // TraineeAttendenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 595);
            Controls.Add(TraineeAttendencGroupBox);
            Name = "TraineeAttendenceForm";
            Text = "TraineeAttendenceFor";
            Load += TraineeAttendenceForm_Load;
            TraineeAttendencGroupBox.ResumeLayout(false);
            TraineeAttendencGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox TraineeAttendencGroupBox;
        private TextBox CheckInBox;
        private TextBox ValidateSubscriptionId;
        private Button CreateAttendencBtn;
        private TextBox TraineeNameBox;
        private TextBox SubscriptionIdBox;
        private Label TraineeNameLbl;
        private Label label1;
        private Label SubscriptionIdLbl;
        private TextBox LastCheckinBox;
        private Label label2;
        private TextBox ValidateLastCheckin;
        private Label SubScriptionStatusLbl;
        private TextBox CardStatusBox;
    }
}