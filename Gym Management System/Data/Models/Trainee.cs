using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Management_System.Data.Enums;

namespace Gym_Management_System.Data.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(15)]
        public string Phone { get; set; }

        [Range(10, 100)]
        public int Age { get; set; }

       public TraineeStatus Status { get; set; } = TraineeStatus.Active;


        public int? TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

       
        //public virtual ICollection<TraineeSubscription> TraineeSubscriptions { get; set; }

    }
}
