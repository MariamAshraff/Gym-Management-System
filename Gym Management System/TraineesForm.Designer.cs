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
            NameLabel.Location = new Point(18, 33);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(45, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name: ";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(18, 81);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(44, 15);
            PhoneLabel.TabIndex = 1;
            PhoneLabel.Text = "Phone:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(18, 123);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(31, 15);
            AgeLabel.TabIndex = 2;
            AgeLabel.Text = "Age:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(19, 191);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 33);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(86, 81);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(110, 23);
            txtPhone.TabIndex = 5;
            // 
            // textAge
            // 
            textAge.Location = new Point(86, 123);
            textAge.Margin = new Padding(3, 2, 3, 2);
            textAge.Name = "textAge";
            textAge.Size = new Size(110, 23);
            textAge.TabIndex = 6;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(101, 191);
            StatusBox.Margin = new Padding(3, 2, 3, 2);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(133, 23);
            StatusBox.TabIndex = 7;
            // 
            // CreatedAtLabel
            // 
            CreatedAtLabel.AutoSize = true;
            CreatedAtLabel.Location = new Point(10, 159);
            CreatedAtLabel.Name = "CreatedAtLabel";
            CreatedAtLabel.Size = new Size(63, 15);
            CreatedAtLabel.TabIndex = 8;
            CreatedAtLabel.Text = "CreatedAt:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(86, 159);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // DataGridViewTrainees
            // 
            DataGridViewTrainees.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DataGridViewTrainees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTrainees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTrainees.Location = new Point(487, 26);
            DataGridViewTrainees.Margin = new Padding(3, 2, 3, 2);
            DataGridViewTrainees.Name = "DataGridViewTrainees";
            DataGridViewTrainees.RowHeadersWidth = 51;
            DataGridViewTrainees.Size = new Size(774, 340);
            DataGridViewTrainees.TabIndex = 10;
            DataGridViewTrainees.CellContentClick += DataGridViewTrainees_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 296);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(312, 296);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(150, 296);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // TraineesDataLabel
            // 
            TraineesDataLabel.AutoSize = true;
            TraineesDataLabel.Location = new Point(436, 7);
            TraineesDataLabel.Name = "TraineesDataLabel";
            TraineesDataLabel.Size = new Size(75, 15);
            TraineesDataLabel.TabIndex = 14;
            TraineesDataLabel.Text = "Trainess Data";
            // 
            // TrainerLabel
            // 
            TrainerLabel.AutoSize = true;
            TrainerLabel.Location = new Point(18, 248);
            TrainerLabel.Name = "TrainerLabel";
            TrainerLabel.Size = new Size(45, 15);
            TrainerLabel.TabIndex = 15;
            TrainerLabel.Text = "Trainer:";
            // 
            // comboBoxTrainer
            // 
            comboBoxTrainer.FormattingEnabled = true;
            comboBoxTrainer.Location = new Point(101, 248);
            comboBoxTrainer.Margin = new Padding(3, 2, 3, 2);
            comboBoxTrainer.Name = "comboBoxTrainer";
            comboBoxTrainer.Size = new Size(133, 23);
            comboBoxTrainer.TabIndex = 16;
            // 
            // TraineesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 374);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "TraineesForm";
            Text = "TraineesForm";
            Load += TraineesForm_Load;
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