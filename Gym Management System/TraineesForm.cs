using Gym_Management_System.Data.Enums;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class TraineesForm : Form
    {
        private readonly ITraineesService _traineesService;

        public TraineesForm(ITraineesService traineesService)
        {
            InitializeComponent();
            _traineesService = traineesService;
        }
        // form style 
        private void ApplyTheme()
        {
            // === FORM ===
            this.BackColor = Color.FromArgb(13, 27, 42);

            // === LABELS ===
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(123, 175, 212);
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }

                // === TEXTBOXES ===
                if (ctrl is TextBox txt)
                {
                    txt.BackColor = Color.FromArgb(26, 58, 92);
                    txt.ForeColor = Color.FromArgb(204, 228, 255);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.Font = new Font("Segoe UI", 10);
                }

                // === COMBOBOXES ===
                if (ctrl is ComboBox cmb)
                {
                    cmb.BackColor = Color.FromArgb(26, 58, 92);
                    cmb.ForeColor = Color.FromArgb(204, 228, 255);
                    cmb.Font = new Font("Segoe UI", 10);
                    cmb.FlatStyle = FlatStyle.Flat;
                }

                // === BUTTONS ===
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                    btn.Size = new Size(100, 36);

                    if (btn.Name == "btnAdd")
                        btn.BackColor = Color.FromArgb(21, 101, 192);

                    else if (btn.Name == "btnEdit")
                        btn.BackColor = Color.FromArgb(25, 118, 210);

                    else if (btn.Name == "btnDelete")
                        btn.BackColor = Color.FromArgb(13, 71, 161);
                }
            }

            // === DATAGRIDVIEW ===
            DataGridViewTrainees.BackgroundColor = Color.FromArgb(10, 25, 41);
            DataGridViewTrainees.GridColor = Color.FromArgb(26, 58, 92);
            DataGridViewTrainees.BorderStyle = BorderStyle.None;
            DataGridViewTrainees.RowHeadersVisible = false;
            DataGridViewTrainees.AllowUserToAddRows = false;
            DataGridViewTrainees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewTrainees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Column Headers
            DataGridViewTrainees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 101, 192);
            DataGridViewTrainees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridViewTrainees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DataGridViewTrainees.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            DataGridViewTrainees.ColumnHeadersHeight = 40;
            DataGridViewTrainees.EnableHeadersVisualStyles = false;

            // Rows
            DataGridViewTrainees.DefaultCellStyle.BackColor = Color.FromArgb(17, 34, 51);
            DataGridViewTrainees.DefaultCellStyle.ForeColor = Color.FromArgb(204, 228, 255);
            DataGridViewTrainees.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DataGridViewTrainees.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            DataGridViewTrainees.DefaultCellStyle.SelectionBackColor = Color.FromArgb(21, 101, 192);
            DataGridViewTrainees.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridViewTrainees.RowTemplate.Height = 36;

            // Alternating rows
            DataGridViewTrainees.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(13, 27, 42);
            DataGridViewTrainees.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(204, 228, 255);
        }

        // Load Status Enum
        private void LoadStatus()
        {
            StatusBox.DataSource = Enum.GetValues(typeof(TraineeStatus));
        }

        // Load Data


        private void LoadData()
        {
            var data = _traineesService.GetAll();

            DataGridViewTrainees.DataSource = null; // ← مهم جداً
            DataGridViewTrainees.DataSource = data;

            if (DataGridViewTrainees.Columns.Contains("Id"))
                DataGridViewTrainees.Columns["Id"].Visible = false;

            if (DataGridViewTrainees.Columns.Contains("TrainerId"))
                DataGridViewTrainees.Columns["TrainerId"].Visible = false;
        }
        // Form Load
        private void TraineesForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            LoadData();
            LoadStatus();
            LoadTrainers();
        }
        private void LoadTrainers()
        {
            var trainers = _traineesService.GetAllTrainers();

            comboBoxTrainer.DataSource = trainers;
            comboBoxTrainer.DisplayMember = "Name";
            comboBoxTrainer.ValueMember = "Id";
            comboBoxTrainer.SelectedIndex = -1;
        }
        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  VALIDATIONS
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone is required");
                return;
            }

            if (!int.TryParse(textAge.Text, out int age))
            {
                MessageBox.Show("Age must be a number");
                return;
            }

            if (age < 10 || age > 100)
            {
                MessageBox.Show("Age must be between 10 and 100");
                return;
            }

            if (StatusBox.SelectedItem == null)
            {
                MessageBox.Show("Please select status");
                return;
            }

            if (comboBoxTrainer.SelectedValue == null)
            {
                MessageBox.Show("Please select a trainer");
                return;
            }

            // ✔ ADD
            var trainee = new Trainee
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Age = age,
                Status = (TraineeStatus)StatusBox.SelectedItem,
                CreatedAt = DateTime.Now,
                TrainerId = (int)comboBoxTrainer.SelectedValue
            };

            _traineesService.Add(trainee);

            LoadData();
            ClearFields();
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewTrainees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trainee first");
                return;
            }

            int id = (int)DataGridViewTrainees.SelectedRows[0].Cells["Id"].Value;

            _traineesService.Delete(id);

            LoadData();
            ClearFields();
        }

        // EDIT
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DataGridViewTrainees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trainee first");
                return;
            }

            if (!int.TryParse(textAge.Text, out int age))
            {
                MessageBox.Show("Age must be a number");
                return;
            }

            var trainee = new Trainee
            {
                Id = (int)DataGridViewTrainees.SelectedRows[0].Cells["Id"].Value,
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Age = age,
                Status = StatusBox.SelectedItem != null
                    ? (TraineeStatus)StatusBox.SelectedItem
                    : TraineeStatus.Active,
                TrainerId = comboBoxTrainer.SelectedValue != null
                    ? (int)comboBoxTrainer.SelectedValue
                    : null
            };

            _traineesService.Update(trainee);

            LoadData();
            ClearFields();
        }


        

        // CLEAR
        private void ClearFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            textAge.Clear();
            StatusBox.SelectedIndex = -1;
            comboBoxTrainer.SelectedIndex = -1;
            DataGridViewTrainees.ClearSelection();
        }
        // CELL CLICK

        private void DataGridViewTrainees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTrainees.CurrentRow != null)
            {
                txtName.Text = DataGridViewTrainees.CurrentRow.Cells["Name"].Value?.ToString();
                txtPhone.Text = DataGridViewTrainees.CurrentRow.Cells["Phone"].Value?.ToString();
                textAge.Text = DataGridViewTrainees.CurrentRow.Cells["Age"].Value?.ToString();

                var statusValue = DataGridViewTrainees.CurrentRow.Cells["Status"].Value?.ToString();
                if (Enum.TryParse(typeof(TraineeStatus), statusValue, out var result))
                    StatusBox.SelectedItem = result;

                // Trainer
                var trainerId = DataGridViewTrainees.CurrentRow.Cells["TrainerId"].Value;
                if (trainerId != null)
                    comboBoxTrainer.SelectedValue = trainerId;
            }
        }
    }
}