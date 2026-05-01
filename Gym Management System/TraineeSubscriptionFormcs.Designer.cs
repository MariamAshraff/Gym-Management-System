namespace Gym_Management_System
{
    partial class TraineeSubscriptionFormcs
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
            TraineeId = new Label();
            StartDateLbl = new Label();
            MonthsLbl = new Label();
            DiscountLbl = new Label();
            label4 = new Label();
            TrainingProgramlbl = new Label();
            TrainingProgramBox = new ComboBox();
            DataGroupBox = new GroupBox();
            MonthsCount = new NumericUpDown();
            StartDatePicker = new DateTimePicker();
            TraineeIdExist = new TextBox();
            TraineeIdBox = new TextBox();
            Subscribe_PayBtn = new Button();
            PaymentGBox = new GroupBox();
            radioInstaPay = new RadioButton();
            radioCreditCard = new RadioButton();
            radioCash = new RadioButton();
            PaymentMethodLbl = new Label();
            NetAmount = new TextBox();
            NetAmountLbl = new Label();
            DiscountAmount = new TextBox();
            MoneyAmount = new TextBox();
            DataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MonthsCount).BeginInit();
            PaymentGBox.SuspendLayout();
            SuspendLayout();
            // 
            // TraineeId
            // 
            TraineeId.AutoSize = true;
            TraineeId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TraineeId.Location = new Point(8, 37);
            TraineeId.Name = "TraineeId";
            TraineeId.Padding = new Padding(2);
            TraineeId.Size = new Size(81, 21);
            TraineeId.TabIndex = 0;
            TraineeId.Text = "Trainee Id: ";
            // 
            // StartDateLbl
            // 
            StartDateLbl.AutoSize = true;
            StartDateLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDateLbl.Location = new Point(8, 169);
            StartDateLbl.Name = "StartDateLbl";
            StartDateLbl.Padding = new Padding(2);
            StartDateLbl.Size = new Size(82, 21);
            StartDateLbl.TabIndex = 1;
            StartDateLbl.Text = "Start Date: ";
            // 
            // MonthsLbl
            // 
            MonthsLbl.AutoSize = true;
            MonthsLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MonthsLbl.Location = new Point(6, 230);
            MonthsLbl.Name = "MonthsLbl";
            MonthsLbl.Padding = new Padding(2);
            MonthsLbl.Size = new Size(71, 21);
            MonthsLbl.TabIndex = 2;
            MonthsLbl.Text = "Months : ";
            // 
            // DiscountLbl
            // 
            DiscountLbl.AutoSize = true;
            DiscountLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiscountLbl.Location = new Point(6, 88);
            DiscountLbl.Name = "DiscountLbl";
            DiscountLbl.Padding = new Padding(2);
            DiscountLbl.Size = new Size(79, 21);
            DiscountLbl.TabIndex = 3;
            DiscountLbl.Text = "Discount : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(139, 21);
            label4.TabIndex = 4;
            label4.Text = "Amount Of Money : ";
            // 
            // TrainingProgramlbl
            // 
            TrainingProgramlbl.AutoSize = true;
            TrainingProgramlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrainingProgramlbl.Location = new Point(6, 110);
            TrainingProgramlbl.Name = "TrainingProgramlbl";
            TrainingProgramlbl.Padding = new Padding(2);
            TrainingProgramlbl.Size = new Size(128, 21);
            TrainingProgramlbl.TabIndex = 5;
            TrainingProgramlbl.Text = "Training Program: ";
            // 
            // TrainingProgramBox
            // 
            TrainingProgramBox.FormattingEnabled = true;
            TrainingProgramBox.Location = new Point(140, 110);
            TrainingProgramBox.Name = "TrainingProgramBox";
            TrainingProgramBox.Size = new Size(228, 25);
            TrainingProgramBox.TabIndex = 6;
            TrainingProgramBox.SelectedIndexChanged += TrainingProgramBox_SelectedIndexChanged;
            // 
            // DataGroupBox
            // 
            DataGroupBox.Controls.Add(MonthsCount);
            DataGroupBox.Controls.Add(StartDatePicker);
            DataGroupBox.Controls.Add(TraineeIdExist);
            DataGroupBox.Controls.Add(TraineeIdBox);
            DataGroupBox.Controls.Add(TraineeId);
            DataGroupBox.Controls.Add(MonthsLbl);
            DataGroupBox.Controls.Add(TrainingProgramBox);
            DataGroupBox.Controls.Add(TrainingProgramlbl);
            DataGroupBox.Controls.Add(StartDateLbl);
            DataGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGroupBox.Location = new Point(33, 25);
            DataGroupBox.Name = "DataGroupBox";
            DataGroupBox.Size = new Size(601, 283);
            DataGroupBox.TabIndex = 7;
            DataGroupBox.TabStop = false;
            DataGroupBox.Text = "Trainee Subscription";
            // 
            // MonthsCount
            // 
            MonthsCount.Location = new Point(100, 226);
            MonthsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MonthsCount.Name = "MonthsCount";
            MonthsCount.Size = new Size(268, 25);
            MonthsCount.TabIndex = 10;
            MonthsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MonthsCount.ValueChanged += MonthsCount_ValueChanged;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(100, 165);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(268, 25);
            StartDatePicker.TabIndex = 9;
            // 
            // TraineeIdExist
            // 
            TraineeIdExist.BackColor = SystemColors.Control;
            TraineeIdExist.BorderStyle = BorderStyle.None;
            TraineeIdExist.ForeColor = Color.Red;
            TraineeIdExist.Location = new Point(95, 72);
            TraineeIdExist.Name = "TraineeIdExist";
            TraineeIdExist.Size = new Size(237, 18);
            TraineeIdExist.TabIndex = 8;
            // 
            // TraineeIdBox
            // 
            TraineeIdBox.Location = new Point(95, 35);
            TraineeIdBox.Name = "TraineeIdBox";
            TraineeIdBox.Size = new Size(273, 25);
            TraineeIdBox.TabIndex = 7;
            TraineeIdBox.TextChanged += TraineeIdBox_TextChanged;
            // 
            // Subscribe_PayBtn
            // 
            Subscribe_PayBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subscribe_PayBtn.Location = new Point(207, 647);
            Subscribe_PayBtn.Name = "Subscribe_PayBtn";
            Subscribe_PayBtn.Size = new Size(153, 43);
            Subscribe_PayBtn.TabIndex = 8;
            Subscribe_PayBtn.Text = "Subscribe &  Pay";
            Subscribe_PayBtn.UseVisualStyleBackColor = true;
            Subscribe_PayBtn.Click += Subscribe_PayBtn_Click;
            // 
            // PaymentGBox
            // 
            PaymentGBox.Controls.Add(radioInstaPay);
            PaymentGBox.Controls.Add(radioCreditCard);
            PaymentGBox.Controls.Add(radioCash);
            PaymentGBox.Controls.Add(PaymentMethodLbl);
            PaymentGBox.Controls.Add(NetAmount);
            PaymentGBox.Controls.Add(NetAmountLbl);
            PaymentGBox.Controls.Add(DiscountAmount);
            PaymentGBox.Controls.Add(MoneyAmount);
            PaymentGBox.Controls.Add(label4);
            PaymentGBox.Controls.Add(DiscountLbl);
            PaymentGBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentGBox.Location = new Point(41, 330);
            PaymentGBox.Name = "PaymentGBox";
            PaymentGBox.Size = new Size(593, 264);
            PaymentGBox.TabIndex = 9;
            PaymentGBox.TabStop = false;
            PaymentGBox.Text = "Subscription Payment";
            // 
            // radioInstaPay
            // 
            radioInstaPay.AutoSize = true;
            radioInstaPay.Location = new Point(166, 224);
            radioInstaPay.Name = "radioInstaPay";
            radioInstaPay.Size = new Size(78, 21);
            radioInstaPay.TabIndex = 12;
            radioInstaPay.Text = "InstaPay";
            radioInstaPay.UseVisualStyleBackColor = true;
            // 
            // radioCreditCard
            // 
            radioCreditCard.AutoSize = true;
            radioCreditCard.Location = new Point(330, 224);
            radioCreditCard.Name = "radioCreditCard";
            radioCreditCard.Size = new Size(95, 21);
            radioCreditCard.TabIndex = 11;
            radioCreditCard.Text = "Credit Card";
            radioCreditCard.UseVisualStyleBackColor = true;
            // 
            // radioCash
            // 
            radioCash.AutoSize = true;
            radioCash.Checked = true;
            radioCash.Location = new Point(53, 224);
            radioCash.Name = "radioCash";
            radioCash.Size = new Size(55, 21);
            radioCash.TabIndex = 10;
            radioCash.TabStop = true;
            radioCash.Text = "Cash";
            radioCash.UseVisualStyleBackColor = true;
            // 
            // PaymentMethodLbl
            // 
            PaymentMethodLbl.AutoSize = true;
            PaymentMethodLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentMethodLbl.Location = new Point(7, 187);
            PaymentMethodLbl.Name = "PaymentMethodLbl";
            PaymentMethodLbl.Padding = new Padding(2);
            PaymentMethodLbl.Size = new Size(130, 21);
            PaymentMethodLbl.TabIndex = 9;
            PaymentMethodLbl.Text = "Payment Method : ";
            // 
            // NetAmount
            // 
            NetAmount.Location = new Point(132, 134);
            NetAmount.Name = "NetAmount";
            NetAmount.ReadOnly = true;
            NetAmount.Size = new Size(228, 25);
            NetAmount.TabIndex = 8;
            // 
            // NetAmountLbl
            // 
            NetAmountLbl.AutoSize = true;
            NetAmountLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NetAmountLbl.Location = new Point(7, 137);
            NetAmountLbl.Name = "NetAmountLbl";
            NetAmountLbl.Padding = new Padding(2);
            NetAmountLbl.Size = new Size(127, 21);
            NetAmountLbl.TabIndex = 7;
            NetAmountLbl.Text = "Net Paid Amount: ";
            // 
            // DiscountAmount
            // 
            DiscountAmount.Location = new Point(103, 92);
            DiscountAmount.Name = "DiscountAmount";
            DiscountAmount.ReadOnly = true;
            DiscountAmount.Size = new Size(257, 25);
            DiscountAmount.TabIndex = 6;
            // 
            // MoneyAmount
            // 
            MoneyAmount.Location = new Point(151, 48);
            MoneyAmount.Name = "MoneyAmount";
            MoneyAmount.ReadOnly = true;
            MoneyAmount.Size = new Size(209, 25);
            MoneyAmount.TabIndex = 5;
            // 
            // TraineeSubscriptionFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(PaymentGBox);
            Controls.Add(Subscribe_PayBtn);
            Controls.Add(DataGroupBox);
            Name = "TraineeSubscriptionFormcs";
            Text = "TraineeSubscriptionFormcs";
            Load += TraineeSubscriptionFormcs_Load;
            DataGroupBox.ResumeLayout(false);
            DataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MonthsCount).EndInit();
            PaymentGBox.ResumeLayout(false);
            PaymentGBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TraineeId;
        private Label StartDateLbl;
        private Label MonthsLbl;
        private Label DiscountLbl;
        private Label label4;
        private Label TrainingProgramlbl;
        private ComboBox TrainingProgramBox;
        private GroupBox DataGroupBox;
        private Button Subscribe_PayBtn;
        private TextBox TraineeIdBox;
        private TextBox TraineeIdExist;
        private DateTimePicker StartDatePicker;
        private NumericUpDown MonthsCount;
        private GroupBox PaymentGBox;
        private TextBox MoneyAmount;
        private TextBox DiscountAmount;
        private TextBox NetAmount;
        private Label NetAmountLbl;
        private Label PaymentMethodLbl;
        private RadioButton radioInstaPay;
        private RadioButton radioCreditCard;
        private RadioButton radioCash;
    }
}