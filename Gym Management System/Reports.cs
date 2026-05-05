using Gym_Management_System.Data.Context;
using Gym_Management_System.Services.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Reports : Form
    {
        private readonly ReportService _reportService;
        public Reports(GymContext gymContext)
        {
            _reportService = new ReportService(gymContext);
            InitializeComponent();
        }
        // تحميل الأرقام في الـ Labels فوق
        private void LoadSummaryCards()
        {
            IblTodayAttendance.Text = _reportService.GetTodayAttendanceCount().ToString();
            lblActiveSubscriptions.Text = _reportService.GetActiveSubscriptionsCount().ToString();
            lblMonthlyRevenue.Text = _reportService.GetMonthlyRevenue().ToString("N0") + " ج";
        }
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _reportService.GetAttendanceReport();

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = data;

                if (dataGridView1.Columns["TraineeName"] != null)
                    dataGridView1.Columns["TraineeName"].HeaderText = "اسم العضو";
                if (dataGridView1.Columns["Date"] != null)
                    dataGridView1.Columns["Date"].HeaderText = "تاريخ الدخول";

                IblTodayAttendance.Text = "عدد السجلات: " + data.Count;
                lblTodayAttendance.Text = "تقرير الحضور";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActiveSubscriptions_Click(object sender, EventArgs e)
        {
            try
            {
                int count = _reportService.GetActiveSubscriptionsCount();
                lblActiveSubscriptions.Text = count.ToString();

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Info", "البيان");
                dataGridView1.Columns.Add("Value", "القيمة");
                dataGridView1.Rows.Add("عدد الاشتراكات الفعالة", count);

                lblTodayAttendance.Text = "الاشتراكات الفعالة";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // button: الاشتراكات المنتهية
        private void btnExpiredSubscriptions_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _reportService.GetExpiredSubscriptions();

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = data;

                if (dataGridView1.Columns["TraineeName"] != null)
                    dataGridView1.Columns["TraineeName"].HeaderText = "اسم العضو";
                if (dataGridView1.Columns["Phone"] != null)
                    dataGridView1.Columns["Phone"].HeaderText = "الهاتف";
                if (dataGridView1.Columns["SubscriptionName"] != null)
                    dataGridView1.Columns["SubscriptionName"].HeaderText = "الاشتراك";
                if (dataGridView1.Columns["EndDate"] != null)
                    dataGridView1.Columns["EndDate"].HeaderText = "تاريخ الانتهاء";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                }

                IblTodayAttendance.Text = "عدد السجلات: " + data.Count;
                lblTodayAttendance.Text = "الاشتراكات المنتهية";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTrainers_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _reportService.GetTrainersReport();

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = data;

                if (dataGridView1.Columns["Name"] != null)
                    dataGridView1.Columns["Name"].HeaderText = "الاسم";
                if (dataGridView1.Columns["Specialty"] != null)
                    dataGridView1.Columns["Specialty"].HeaderText = "التخصص";
                if (dataGridView1.Columns["Phone"] != null)
                    dataGridView1.Columns["Phone"].HeaderText = "الهاتف";
                if (dataGridView1.Columns["Salary"] != null)
                    dataGridView1.Columns["Salary"].HeaderText = "الراتب";
                if (dataGridView1.Columns["TraineeCount"] != null)
                    dataGridView1.Columns["TraineeCount"].HeaderText = "عدد الأعضاء";
                if (dataGridView1.Columns["HireDate"] != null)
                    dataGridView1.Columns["HireDate"].HeaderText = "تاريخ التعيين";

                IblTodayAttendance.Text = "عدد السجلات: " + data.Count;
                lblTodayAttendance.Text = "تقرير المدربين";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                decimal revenue = _reportService.GetMonthlyRevenue();
                lblMonthlyRevenue.Text = revenue.ToString("N0") + " ج";

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Month", "الشهر");
                dataGridView1.Columns.Add("Revenue", "الإيراد الكلي");
                dataGridView1.Rows.Add(
                    DateTime.Today.ToString("MMMM yyyy"),
                    revenue.ToString("N0") + " ج"
                );

                lblTodayAttendance.Text = "إيرادات الشهر الحالي";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

