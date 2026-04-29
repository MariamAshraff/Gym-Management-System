// DTOs/TrainerReportDto.cs
namespace Gym_Management_System.DTOs
{
    public class TrainerReportDto
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public int TraineeCount { get; set; }
        public DateTime HireDate { get; set; }
    }
}