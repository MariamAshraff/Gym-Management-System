using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class TraineeSubscription
    {
        [Key]
        public int Id { get; set; }

        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }

        public int SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int UsedDays { get; set; } = 0;

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
