using Gym_Management_System.Data;
using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;
using Gym_Management_System.DTOs;
using Gym_Management_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Services.Implementation
{
    public class ReportService : IReportService
    {
        private readonly GymContext _gymContext;

        public ReportService(GymContext gymContext)
        {
            _gymContext = gymContext;
        }

        // حضور النهارده
        public int GetTodayAttendanceCount()
        {
            return _gymContext.TraineeAttendances
                .Count(a => a.CheckIn.Date == DateTime.Today);
        }

        // اشتراكات شغالة دلوقتي
        public int GetActiveSubscriptionsCount()
        {
            return _gymContext.TraineeSubscriptions
                .Count(ts => ts.EndDate >= DateTime.Today);
        }

        // إيرادات الشهر الحالي
        public decimal GetMonthlyRevenue()
        {
            var firstDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            return _gymContext.TraineeSubscriptions
                .Where(ts => ts.StartDate >= firstDay)
                .Include(ts => ts.TrainingProgram)
                .Sum(ts => ts.TrainingProgram.Price);
        }

        // تقرير المدربين وعدد أعضائهم
        public List<TrainerReportDto> GetTrainersReport()
        {
            return _gymContext.Trainers
                .Where(t => t.IsActive)
                .Select(t => new TrainerReportDto
                {
                    Name = t.Name,
                    Specialty = t.Specialty,
                    Phone = t.Phone,
                    Salary = t.Salary,
                    TraineeCount = t.Trainees.Count,
                    HireDate = t.HireDate
                }).ToList();
        }

        // تقرير الاشتراكات المنتهية
        public List<ExpiredSubscriptionDto> GetExpiredSubscriptions()
        {
            return _gymContext.TraineeSubscriptions
                .Where(ts => ts.EndDate < DateTime.Today)
                .Include(ts => ts.Trainee)
                .Include(ts => ts.TrainingProgram)
                .Select(ts => new ExpiredSubscriptionDto
                {
                    TraineeName = ts.Trainee.Name,
                    Phone = ts.Trainee.Phone,
                    SubscriptionName = ts.TrainingProgram.Name,
                    EndDate = ts.EndDate
                }).ToList();
        }

        // تقرير حضور الأعضاء
        public List<AttendanceReportDto> GetAttendanceReport()
        {
            return _gymContext.TraineeAttendances
                .Include(a => a.TraineeSubscription.Trainee)
                .OrderByDescending(a => a.CheckIn)
                .Take(50)
                .Select(a => new AttendanceReportDto
                {
                    TraineeName = a.TraineeSubscription.Trainee.Name,
                    Date = a.CheckIn,
                })
                .ToList();
        }

        public List<Trainer> GetTrainersWithTrainees()
        {
            return _gymContext.Trainers
                .Include(t => t.Trainees)
                .Where(t => t.IsActive)
                .ToList();
        }
    }
}