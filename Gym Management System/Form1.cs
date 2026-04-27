using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Interfaces;

namespace Gym_Management_System
{
    public partial class Form1 : Form
    {
        private readonly ITrainerService _trainerService;
        private int _selectedId = 0;

        // الكونستركتور الأساسي الذي يستخدم الـ Dependency Injection
        public Form1(ITrainerService trainerService)
        {
            InitializeComponent();
            _trainerService = trainerService;
        }



        // ==================== Events ====================
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTrainers();
        }


        // ==================== Grid Logic ====================

        private void LoadTrainers()
        {
            // بنروح نجيب القائمة المحدثة من الداتابيز
            var list = _trainerService.GetAll();

            dgvTrainers.DataSource = null;
            dgvTrainers.AutoGenerateColumns = true; // عشان الأعمدة تظهر لوحدها
            dgvTrainers.DataSource = list;
        }




        // ==================== Buttons Logic ====================
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. تجميع البيانات من التكست بوكس في كائن Trainer
                var newTrainer = new Trainer
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Specialty = txtSpecialty.Text.Trim(),
                    Salary = decimal.Parse(txtSalary.Text),
                    IsActive = chkIsActive.Checked,
                    HireDate = DateTime.Now // تاريخ التعيين هو اللحظة الحالية
                };

                // 2. استدعاء السيرفس لحفظ البيانات في القاعدة
                _trainerService.Add(newTrainer);

                // 3. رسالة نجاح وتنظيف الفورم
                MessageBox.Show("تم حفظ المدرب في قاعدة البيانات بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();     // ميثود بتمسح التكست بوكس
                LoadTrainers();  // ميثود بتحدث الجدول عشان تشوف اللي أضفته فوراً
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الإضافة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("الرجاء اختيار مدرب من الجدول للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValid()) return;

            var trainer = _trainerService.GetById(_selectedId);
            if (trainer != null)
            {
                trainer.Name = txtName.Text.Trim();
                trainer.Phone = txtPhone.Text.Trim();
                trainer.Specialty = txtSpecialty.Text.Trim();
                trainer.Salary = decimal.Parse(txtSalary.Text);
                trainer.IsActive = chkIsActive.Checked;

                _trainerService.Update(trainer);
                MessageBox.Show("تم التعديل بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadTrainers();
            }
        }

        private void btnDeactivate_Click_1(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("اختار مدرب الأول من الجدول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من إيقاف تفعيل هذا المدرب؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _trainerService.Deactivate(_selectedId);
                MessageBox.Show("تم إيقاف التفعيل بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadTrainers();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }



        // ==================== Helpers ====================

        private void ClearForm()
        {
            _selectedId = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtSpecialty.Clear();
            txtSalary.Clear();
            chkIsActive.Checked = true;
            txtName.Focus();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowError("اكتب اسم المدرب", txtName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                ShowError("اكتب رقم الموبايل", txtPhone);
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text, out _))
            {
                ShowError("الراتب لازم يكون رقم", txtSalary);
                return false;
            }

            return true;
        }

        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void dgvTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // سحب السطر الحالي
                DataGridViewRow row = dgvTrainers.Rows[e.RowIndex];

                // سحب الكائن المرتبط بالسطر (المدرب)
                var trainer = row.DataBoundItem as Trainer;

                if (trainer != null)
                {
                    // ملء الحقول بالبيانات لكي يعمل الـ Update والـ Delete
                    _selectedId = trainer.Id;
                    txtName.Text = trainer.Name;
                    txtPhone.Text = trainer.Phone;
                    txtSpecialty.Text = trainer.Specialty;
                    txtSalary.Text = trainer.Salary.ToString();
                    chkIsActive.Checked = trainer.IsActive;

                    // تغيير لون السطر المختار ليعرف المستخدم أنه تم الاختيار
                    row.Selected = true;
                }
            }
        }
    }
}
        