namespace Gym_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(175, 180);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Not Active";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(74, 179);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 9;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 180);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(63, 153);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Salary";
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(63, 117);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(100, 23);
            txtSpecialty.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Specialization";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(63, 77);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.Location = new Point(63, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDeactivate);
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(12, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 62);
            panel1.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(250, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnDeactivate
            // 
            btnDeactivate.ForeColor = Color.Red;
            btnDeactivate.Location = new Point(169, 10);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(75, 23);
            btnDeactivate.TabIndex = 2;
            btnDeactivate.Text = "Delete";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ForeColor = Color.Orange;
            BtnUpdate.Location = new Point(88, 10);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 23);
            BtnUpdate.TabIndex = 1;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(3, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // dgvTrainers
            // 
            dgvTrainers.BackgroundColor = SystemColors.ActiveCaption;
            dgvTrainers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainers.Location = new Point(380, 25);
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.Size = new Size(388, 251);
            dgvTrainers.TabIndex = 9;
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTrainers);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Trainer";
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
