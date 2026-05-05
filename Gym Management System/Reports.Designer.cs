namespace Gym_Management_System
{
    partial class Reports
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
            panel1 = new Panel();
            btnRevenue = new Button();
            btnTrainers = new Button();
            btnExpiredSubscriptions = new Button();
            btnActiveSubscriptions = new Button();
            btnAttendance = new Button();
            lblTodayAttendance = new GroupBox();
            IblTodayAttendance = new Label();
            groupBox2 = new GroupBox();
            lblActiveSubscriptions = new Label();
            groupBox3 = new GroupBox();
            lblMonthlyRevenue = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            lblTodayAttendance.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRevenue);
            panel1.Controls.Add(btnTrainers);
            panel1.Controls.Add(btnExpiredSubscriptions);
            panel1.Controls.Add(btnActiveSubscriptions);
            panel1.Controls.Add(btnAttendance);
            panel1.Location = new Point(8, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 411);
            panel1.TabIndex = 0;
            // 
            // btnRevenue
            // 
            btnRevenue.Location = new Point(27, 324);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(127, 58);
            btnRevenue.TabIndex = 4;
            btnRevenue.Text = "ايردات الشهر";
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnTrainers
            // 
            btnTrainers.Location = new Point(27, 249);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Size = new Size(127, 58);
            btnTrainers.TabIndex = 3;
            btnTrainers.Text = "تفرير المدربين";
            btnTrainers.UseVisualStyleBackColor = true;
            btnTrainers.Click += btnTrainers_Click;
            // 
            // btnExpiredSubscriptions
            // 
            btnExpiredSubscriptions.Location = new Point(27, 172);
            btnExpiredSubscriptions.Name = "btnExpiredSubscriptions";
            btnExpiredSubscriptions.Size = new Size(127, 58);
            btnExpiredSubscriptions.TabIndex = 2;
            btnExpiredSubscriptions.Text = "الاشتراكات المنتهية";
            btnExpiredSubscriptions.UseVisualStyleBackColor = true;
            btnExpiredSubscriptions.Click += btnExpiredSubscriptions_Click;
            // 
            // btnActiveSubscriptions
            // 
            btnActiveSubscriptions.Location = new Point(27, 90);
            btnActiveSubscriptions.Name = "btnActiveSubscriptions";
            btnActiveSubscriptions.Size = new Size(127, 58);
            btnActiveSubscriptions.TabIndex = 1;
            btnActiveSubscriptions.Text = "الاشتركات الفعالة";
            btnActiveSubscriptions.UseVisualStyleBackColor = true;
            btnActiveSubscriptions.Click += btnActiveSubscriptions_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(27, 3);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(127, 58);
            btnAttendance.TabIndex = 0;
            btnAttendance.Text = "حضور اليوم";
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // lblTodayAttendance
            // 
            lblTodayAttendance.Controls.Add(IblTodayAttendance);
            lblTodayAttendance.Location = new Point(251, 27);
            lblTodayAttendance.Name = "lblTodayAttendance";
            lblTodayAttendance.Size = new Size(139, 86);
            lblTodayAttendance.TabIndex = 1;
            lblTodayAttendance.TabStop = false;
            // 
            // IblTodayAttendance
            // 
            IblTodayAttendance.AutoSize = true;
            IblTodayAttendance.Location = new Point(21, 19);
            IblTodayAttendance.Name = "IblTodayAttendance";
            IblTodayAttendance.Size = new Size(64, 15);
            IblTodayAttendance.TabIndex = 0;
            IblTodayAttendance.Text = "حضور اليوم";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblActiveSubscriptions);
            groupBox2.Location = new Point(422, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 86);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // lblActiveSubscriptions
            // 
            lblActiveSubscriptions.AutoSize = true;
            lblActiveSubscriptions.Location = new Point(25, 19);
            lblActiveSubscriptions.Name = "lblActiveSubscriptions";
            lblActiveSubscriptions.Size = new Size(80, 15);
            lblActiveSubscriptions.TabIndex = 1;
            lblActiveSubscriptions.Text = "اشتراكات فعالة";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblMonthlyRevenue);
            groupBox3.Location = new Point(619, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(150, 90);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // lblMonthlyRevenue
            // 
            lblMonthlyRevenue.AutoSize = true;
            lblMonthlyRevenue.Location = new Point(43, 16);
            lblMonthlyRevenue.Name = "lblMonthlyRevenue";
            lblMonthlyRevenue.Size = new Size(72, 15);
            lblMonthlyRevenue.TabIndex = 0;
            lblMonthlyRevenue.Text = "إيرادات الشهر";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(244, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(555, 254);
            dataGridView1.TabIndex = 4;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(lblTodayAttendance);
            Controls.Add(panel1);
            Name = "Reports";
            Text = "Reports";
            panel1.ResumeLayout(false);
            lblTodayAttendance.ResumeLayout(false);
            lblTodayAttendance.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTrainers;
        private Button btnExpiredSubscriptions;
        private Button btnActiveSubscriptions;
        private Button btnAttendance;
        private Button btnRevenue;
        private GroupBox lblTodayAttendance;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label IblTodayAttendance;
        private Label lblActiveSubscriptions;
        private Label lblMonthlyRevenue;
    }
}