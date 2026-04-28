// DTOs/ExpiredSubscriptionDto.cs
namespace Gym_Management_System.DTOs
{
    public class ExpiredSubscriptionDto
    {
        public string TraineeName { get; set; }
        public string Phone { get; set; }
        public string SubscriptionName { get; set; }
        public DateTime EndDate { get; set; }
    }
}