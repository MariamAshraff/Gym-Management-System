using Gym_Management_System.Data.Models;

namespace Gym_Management_System.Services.Interfaces
{
    public interface IReportService
    {
        int GetTodayAttendanceCount();
        int GetActiveSubscriptionsCount();
        decimal GetMonthlyRevenue();
        List<Trainer> GetTrainersWithTrainees();
    }
}