// DTOs/AttendanceReportDto.cs
namespace Gym_Management_System.DTOs
{
    public class AttendanceReportDto
    {
        public string TraineeName { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
    }
}