using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class TrainerAttendance
    {
        [Key]
        public int Id { get; set; }

        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;

        public DateTime CheckIn { get; set; }

        public DateTime? CheckOut { get; set; }

        [MaxLength(200)]
        public string? Notes { get; set; }
    }
}
