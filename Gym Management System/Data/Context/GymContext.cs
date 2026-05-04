<<<<<<< HEAD
﻿using Gym_Management_System.Data.Models;
=======
﻿
using Gym_Management_System.Data.Models;
>>>>>>> c75c1ed521516b3a2c01ac7d6eb35f4b68eea8a9
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Data.Context
{
    public class GymContext : DbContext
    {
<<<<<<< HEAD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=GymSystem;Integrated Security=True;TrustServerCertificate=True");
        }
=======

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-IH1846Q\\SQLEXPRESS;Initial Catalog=GymSystem; Integrated Security=True; TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-C0VV8CJS\\MSSQLSERVER29;Initial Catalog=GymSystem; Integrated Security=True; TrustServerCertificate=True");
        }

>>>>>>> c75c1ed521516b3a2c01ac7d6eb35f4b68eea8a9

        public DbSet<User> Users { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<TraineeSubscription> TraineeSubscriptions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<TrainerAttendance> TrainerAttendances { get; set; }
        public DbSet<TraineeAttendance> TraineeAttendances { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}