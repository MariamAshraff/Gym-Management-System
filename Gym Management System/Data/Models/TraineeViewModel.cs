using Gym_Management_System.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class TraineeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public TraineeStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? TrainerId { get; set; }
        public string TrainerName { get; set; }
    }
}
