using Gym_Management_System.Data.Enums;
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

        public int TrainingProgramId { get; set; }
        public virtual TrainingProgram TrainingProgram { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public  int  Months { get; set; }
        public int UsedDays { get; set; } = 0;
        public int PackageTotalDays { get; set; } = 0;
        public SubscriptionStatus Status { get; set; } = SubscriptionStatus.Active;
        public DateTime LastCheckIn { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
