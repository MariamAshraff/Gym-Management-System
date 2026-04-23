using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public int TraineeSubscriptionId { get; set; }
        public virtual TraineeSubscription TraineeSubscription { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        public DateTime PaidAt { get; set; } = DateTime.Now;

        [Required, MaxLength(20)]
        public string Method { get; set; } // Cash - Card
    }
}
