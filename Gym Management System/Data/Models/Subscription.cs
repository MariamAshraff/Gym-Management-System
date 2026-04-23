using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Data.Models
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } //Basic Monthly , Gold 3 Months ,Elite Year


        [Range(1, 3650)]
        public int AllowedDays { get; set; }

        //[Range(1, 3650)]
        //public int DurationDays { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
