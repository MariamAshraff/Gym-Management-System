using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(15)]
        public string Phone { get; set; }

        [Required, MaxLength(100)]
        public string Specialty { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime HireDate { get; set; } = DateTime.Now;

        public virtual ICollection<Trainee> Trainees { get; set; }
        //public virtual ICollection<TrainerAttendance> TrainerAttendances { get; set; }
    }
}
