namespace Gym_Management_System
{
    partial class TraineesForm
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
            NameLabel = new Label();
            PhoneLabel = new Label();
            AgeLabel = new Label();
            StatusLabel = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            textAge = new TextBox();
            StatusBox = new ComboBox();
            CreatedAtLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            DataGridViewTrainees = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            TraineesDataLabel = new Label();
            TrainerLabel = new Label();
            comboBoxTrainer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTrainees).BeginInit();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(21, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(56, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name: ";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(21, 108);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(53, 20);
            PhoneLabel.TabIndex = 1;
            PhoneLabel.Text = "Phone:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(21, 164);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(39, 20);
            AgeLabel.TabIndex = 2;
            AgeLabel.Text = "Age:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(22, 255);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(52, 20);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(98, 108);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // textAge
            // 
            textAge.Location = new Point(98, 164);
            textAge.Name = "textAge";
            textAge.Size = new Size(125, 27);
            textAge.TabIndex = 6;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(115, 255);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(151, 28);
            StatusBox.TabIndex = 7;
            // 
            // CreatedAtLabel
            // 
            CreatedAtLabel.AutoSize = true;
            CreatedAtLabel.Location = new Point(12, 212);
            CreatedAtLabel.Name = "CreatedAtLabel";
            CreatedAtLabel.Size = new Size(79, 20);
            CreatedAtLabel.TabIndex = 8;
            CreatedAtLabel.Text = "CreatedAt:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // DataGridViewTrainees
            // 
            DataGridViewTrainees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTrainees.Location = new Point(498, 34);
            DataGridViewTrainees.Name = "DataGridViewTrainees";
            DataGridViewTrainees.RowHeadersWidth = 51;
            DataGridViewTrainees.Size = new Size(884, 453);
            DataGridViewTrainees.TabIndex = 10;
            DataGridViewTrainees.CellContentClick += DataGridViewTrainees_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(356, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(172, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // TraineesDataLabel
            // 
            TraineesDataLabel.AutoSize = true;
            TraineesDataLabel.Location = new Point(498, 9);
            TraineesDataLabel.Name = "TraineesDataLabel";
            TraineesDataLabel.Size = new Size(97, 20);
            TraineesDataLabel.TabIndex = 14;
            TraineesDataLabel.Text = "Trainess Data";
            // 
            // TrainerLabel
            // 
            TrainerLabel.AutoSize = true;
            TrainerLabel.Location = new Point(20, 331);
            TrainerLabel.Name = "TrainerLabel";
            TrainerLabel.Size = new Size(57, 20);
            TrainerLabel.TabIndex = 15;
            TrainerLabel.Text = "Trainer:";
            // 
            // comboBoxTrainer
            // 
            comboBoxTrainer.FormattingEnabled = true;
            comboBoxTrainer.Location = new Point(115, 331);
            comboBoxTrainer.Name = "comboBoxTrainer";
            comboBoxTrainer.Size = new Size(151, 28);
            comboBoxTrainer.TabIndex = 16;
            // 
            // TraineesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 499);
            Controls.Add(comboBoxTrainer);
            Controls.Add(TrainerLabel);
            Controls.Add(TraineesDataLabel);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(DataGridViewTrainees);
            Controls.Add(dateTimePicker1);
            Controls.Add(CreatedAtLabel);
            Controls.Add(StatusBox);
            Controls.Add(textAge);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(StatusLabel);
            Controls.Add(AgeLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(NameLabel);
            Name = "TraineesForm";
            Text = "TraineesForm";

            // ✅ Events المضافة
            this.Load += new System.EventHandler(this.TraineesForm_Load);
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            ((System.ComponentModel.ISupportInitialize)DataGridViewTrainees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label PhoneLabel;
        private Label AgeLabel;
        private Label StatusLabel;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox textAge;
        private ComboBox StatusBox;
        private Label CreatedAtLabel;
        private DateTimePicker dateTimePicker1;
        private DataGridView DataGridViewTrainees;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Label TraineesDataLabel;
        private Label TrainerLabel;
        private ComboBox comboBoxTrainer;
    }
}