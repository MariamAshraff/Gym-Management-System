//namespace Gym_Management_System
//{
//    partial class Form1
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
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
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            groupBox1 = new GroupBox();
//            checkBox2 = new CheckBox();
//            chkIsActive = new CheckBox();
//            label5 = new Label();
//            txtSalary = new TextBox();
//            label4 = new Label();
//            txtSpecialty = new TextBox();
//            label3 = new Label();
//            label2 = new Label();
//            txtPhone = new TextBox();
//            txtName = new TextBox();
//            label1 = new Label();
//            panel1 = new Panel();
//            btnClear = new Button();
//            btnDeactivate = new Button();
//            BtnUpdate = new Button();
//            btnAdd = new Button();
//            dgvTrainers = new DataGridView();
//            groupBox1.SuspendLayout();
//            panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
//            SuspendLayout();
//            // 
//            // groupBox1
//            // 
//            groupBox1.Controls.Add(checkBox2);
//            groupBox1.Controls.Add(chkIsActive);
//            groupBox1.Controls.Add(label5);
//            groupBox1.Controls.Add(txtSalary);
//            groupBox1.Controls.Add(label4);
//            groupBox1.Controls.Add(txtSpecialty);
//            groupBox1.Controls.Add(label3);
//            groupBox1.Controls.Add(label2);
//            groupBox1.Controls.Add(txtPhone);
//            groupBox1.Controls.Add(txtName);
//            groupBox1.Controls.Add(label1);
//            groupBox1.Location = new Point(14, 41);
//            groupBox1.Margin = new Padding(3, 4, 3, 4);
//            groupBox1.Name = "groupBox1";
//            groupBox1.Padding = new Padding(3, 4, 3, 4);
//            groupBox1.Size = new Size(334, 271);
//            groupBox1.TabIndex = 0;
//            groupBox1.TabStop = false;
//            groupBox1.Text = "groupBox1";
//            // 
//            // checkBox2
//            // 
//            checkBox2.AutoSize = true;
//            checkBox2.Location = new Point(200, 240);
//            checkBox2.Margin = new Padding(3, 4, 3, 4);
//            checkBox2.Name = "checkBox2";
//            checkBox2.Size = new Size(101, 24);
//            checkBox2.TabIndex = 10;
//            checkBox2.Text = "Not Active";
//            checkBox2.UseVisualStyleBackColor = true;
//            // 
//            // chkIsActive
//            // 
//            chkIsActive.AutoSize = true;
//            chkIsActive.Location = new Point(85, 239);
//            chkIsActive.Margin = new Padding(3, 4, 3, 4);
//            chkIsActive.Name = "chkIsActive";
//            chkIsActive.Size = new Size(72, 24);
//            chkIsActive.TabIndex = 9;
//            chkIsActive.Text = "Active";
//            chkIsActive.UseVisualStyleBackColor = true;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Location = new Point(25, 240);
//            label5.Name = "label5";
//            label5.Size = new Size(50, 20);
//            label5.TabIndex = 8;
//            label5.Text = "label5";
//            // 
//            // txtSalary
//            // 
//            txtSalary.Location = new Point(72, 204);
//            txtSalary.Margin = new Padding(3, 4, 3, 4);
//            txtSalary.Name = "txtSalary";
//            txtSalary.Size = new Size(114, 27);
//            txtSalary.TabIndex = 7;
//            // 
//            // label4
//            // 
//            label4.AutoSize = true;
//            label4.Location = new Point(14, 208);
//            label4.Name = "label4";
//            label4.Size = new Size(49, 20);
//            label4.TabIndex = 6;
//            label4.Text = "Salary";
//            // 
//            // txtSpecialty
//            // 
//            txtSpecialty.Location = new Point(72, 156);
//            txtSpecialty.Margin = new Padding(3, 4, 3, 4);
//            txtSpecialty.Name = "txtSpecialty";
//            txtSpecialty.Size = new Size(114, 27);
//            txtSpecialty.TabIndex = 5;
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Location = new Point(10, 167);
//            label3.Name = "label3";
//            label3.Size = new Size(102, 20);
//            label3.TabIndex = 4;
//            label3.Text = "Specialization";
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Location = new Point(7, 113);
//            label2.Name = "label2";
//            label2.Size = new Size(50, 20);
//            label2.TabIndex = 3;
//            label2.Text = "Phone";
//            // 
//            // txtPhone
//            // 
//            txtPhone.Location = new Point(72, 103);
//            txtPhone.Margin = new Padding(3, 4, 3, 4);
//            txtPhone.Name = "txtPhone";
//            txtPhone.Size = new Size(114, 27);
//            txtPhone.TabIndex = 2;
//            // 
//            // txtName
//            // 
//            txtName.BackColor = SystemColors.Window;
//            txtName.Location = new Point(72, 64);
//            txtName.Margin = new Padding(3, 4, 3, 4);
//            txtName.Name = "txtName";
//            txtName.Size = new Size(114, 27);
//            txtName.TabIndex = 1;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Location = new Point(7, 68);
//            label1.Name = "label1";
//            label1.Size = new Size(49, 20);
//            label1.TabIndex = 0;
//            label1.Text = "Name";
//            // 
//            // panel1
//            // 
//            panel1.Controls.Add(btnClear);
//            panel1.Controls.Add(btnDeactivate);
//            panel1.Controls.Add(BtnUpdate);
//            panel1.Controls.Add(btnAdd);
//            panel1.Location = new Point(14, 336);
//            panel1.Margin = new Padding(3, 4, 3, 4);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(437, 83);
//            panel1.TabIndex = 8;
//            // 
//            // btnClear
//            // 
//            btnClear.Location = new Point(286, 13);
//            btnClear.Margin = new Padding(3, 4, 3, 4);
//            btnClear.Name = "btnClear";
//            btnClear.Size = new Size(86, 31);
//            btnClear.TabIndex = 3;
//            btnClear.Text = "Clear";
//            btnClear.UseVisualStyleBackColor = true;
//            btnClear.Click += btnClear_Click_1;
//            // 
//            // btnDeactivate
//            // 
//            btnDeactivate.ForeColor = Color.Red;
//            btnDeactivate.Location = new Point(193, 13);
//            btnDeactivate.Margin = new Padding(3, 4, 3, 4);
//            btnDeactivate.Name = "btnDeactivate";
//            btnDeactivate.Size = new Size(86, 31);
//            btnDeactivate.TabIndex = 2;
//            btnDeactivate.Text = "Delete";
//            btnDeactivate.UseVisualStyleBackColor = true;
//            btnDeactivate.Click += btnDeactivate_Click_1;
//            // 
//            // BtnUpdate
//            // 
//            BtnUpdate.ForeColor = Color.Orange;
//            BtnUpdate.Location = new Point(101, 13);
//            BtnUpdate.Margin = new Padding(3, 4, 3, 4);
//            BtnUpdate.Name = "BtnUpdate";
//            BtnUpdate.Size = new Size(86, 31);
//            BtnUpdate.TabIndex = 1;
//            BtnUpdate.Text = "Update";
//            BtnUpdate.UseVisualStyleBackColor = true;
//            BtnUpdate.Click += BtnUpdate_Click_1;
//            // 
//            // btnAdd
//            // 
//            btnAdd.BackColor = Color.Transparent;
//            btnAdd.ForeColor = Color.Green;
//            btnAdd.Location = new Point(3, 13);
//            btnAdd.Margin = new Padding(3, 4, 3, 4);
//            btnAdd.Name = "btnAdd";
//            btnAdd.Size = new Size(86, 31);
//            btnAdd.TabIndex = 0;
//            btnAdd.Text = "Add";
//            btnAdd.UseVisualStyleBackColor = false;
//            btnAdd.Click += btnAdd_Click_1;
//            // 
//            // dgvTrainers
//            // 
//            dgvTrainers.BackgroundColor = SystemColors.ActiveCaption;
//            dgvTrainers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
//            dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dgvTrainers.Location = new Point(434, 33);
//            dgvTrainers.Margin = new Padding(3, 4, 3, 4);
//            dgvTrainers.Name = "dgvTrainers";
//            dgvTrainers.RowHeadersWidth = 51;
//            dgvTrainers.Size = new Size(443, 335);
//            dgvTrainers.TabIndex = 9;
//            dgvTrainers.CellDoubleClick += dgvTrainers_CellClick;
//            // 
//            // Form1
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.SteelBlue;
//            ClientSize = new Size(914, 600);
//            Controls.Add(dgvTrainers);
//            Controls.Add(panel1);
//            Controls.Add(groupBox1);
//            Margin = new Padding(3, 4, 3, 4);
//            Name = "Form1";
//            Text = "Trainer";
//            Load += Form1_Load;
//            groupBox1.ResumeLayout(false);
//            groupBox1.PerformLayout();
//            panel1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion

//        private GroupBox groupBox1;
//        private Label label2;
//        private TextBox txtPhone;
//        private TextBox txtName;
//        private Label label1;
//        private Label label3;
//        private TextBox txtSpecialty;
//        private Label label4;
//        private TextBox txtSalary;
//        private Panel panel1;
//        private Button btnAdd;
//        private Button BtnUpdate;
//        private Button btnClear;
//        private Button btnDeactivate;
//        private DataGridView dgvTrainers;
//        private CheckBox checkBox2;
//        private CheckBox chkIsActive;
//        private Label label5;
//    }
//}

namespace Gym_Management_System
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            chkIsActive = new CheckBox();
            label5 = new Label();
            txtSalary = new TextBox();
            label4 = new Label();
            txtSpecialty = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnClear = new Button();
            btnDeactivate = new Button();
            BtnUpdate = new Button();
            btnAdd = new Button();
            dgvTrainers = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSpecialty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(20, 20);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(360, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trainer Data";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(220, 260);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Not Active";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 9F);
            chkIsActive.ForeColor = Color.White;
            chkIsActive.Location = new Point(120, 260);
            chkIsActive.Margin = new Padding(3, 4, 3, 4);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(72, 24);
            chkIsActive.TabIndex = 9;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(100, 150, 240);
            label5.Location = new Point(15, 260);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 8;
            label5.Text = "Status:";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.FromArgb(25, 45, 75);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.ForeColor = Color.White;
            txtSalary.Location = new Point(145, 210);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(180, 30);
            txtSalary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(100, 150, 240);
            label4.Location = new Point(15, 215);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 6;
            label4.Text = "Salary:";
            // 
            // txtSpecialty
            // 
            txtSpecialty.BackColor = Color.FromArgb(25, 45, 75);
            txtSpecialty.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialty.ForeColor = Color.White;
            txtSpecialty.Location = new Point(145, 160);
            txtSpecialty.Margin = new Padding(3, 4, 3, 4);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(180, 30);
            txtSpecialty.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(100, 150, 240);
            label3.Location = new Point(15, 165);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 4;
            label3.Text = "Specialization:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(100, 150, 240);
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 3;
            label2.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(25, 45, 75);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(145, 110);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(25, 45, 75);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(145, 60);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 30);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(100, 150, 240);
            label1.Location = new Point(15, 65);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(20, 350);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 80);
            panel1.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(345, 15);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 45);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(15, 60, 150);
            btnDeactivate.FlatAppearance.BorderSize = 0;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(230, 15);
            btnDeactivate.Margin = new Padding(3, 4, 3, 4);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(105, 45);
            btnDeactivate.TabIndex = 2;
            btnDeactivate.Text = "Delete";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(20, 110, 210);
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(115, 15);
            BtnUpdate.Margin = new Padding(3, 4, 3, 4);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(105, 45);
            BtnUpdate.TabIndex = 1;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(20, 110, 210);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 15);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // dgvTrainers
            // 
            dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainers.BackgroundColor = Color.FromArgb(10, 25, 45);
            dgvTrainers.BorderStyle = BorderStyle.None;
            dgvTrainers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 110, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrainers.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 40, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 80, 150);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTrainers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTrainers.EnableHeadersVisualStyles = false;
            dgvTrainers.GridColor = Color.FromArgb(30, 60, 95);
            dgvTrainers.Location = new Point(400, 30);
            dgvTrainers.Margin = new Padding(3, 4, 3, 4);
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.RowHeadersWidth = 51;
            dgvTrainers.RowTemplate.Height = 35;
            dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new Size(600, 400);
            dgvTrainers.TabIndex = 9;
<<<<<<< HEAD
            dgvTrainers.CellContentClick += dgvTrainers_CellContentClick;
            dgvTrainers.CellDoubleClick += dgvTrainers_CellDoubleClick;
=======
            dgvTrainers.CellDoubleClick += dgvTrainers_CellClick;
>>>>>>> c75c1ed521516b3a2c01ac7d6eb35f4b68eea8a9
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 15, 35);
            ClientSize = new Size(1020, 480);
            Controls.Add(dgvTrainers);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Management System - Trainer Management";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private TextBox txtSpecialty;
        private Label label4;
        private TextBox txtSalary;
        private Panel panel1;
        private Button btnAdd;
        private Button BtnUpdate;
        private Button btnClear;
        private Button btnDeactivate;
        private DataGridView dgvTrainers;
        private CheckBox checkBox2;
        private CheckBox chkIsActive;
        private Label label5;
    }
}