using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class TraineeAttendance
    {
        public int Id { get; set; }

        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }

        public DateTime Date { get; set; }
        public DateTime CheckIn { get; set; }
    }
}
