using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Dtos
{
    public class TrainerDisplayDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Specialty { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int TraineeCount { get; set; }
    }
}
