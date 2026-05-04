using Gym_Management_System.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Data.Context
{
    public class GymContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=GymSystem;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<TraineeSubscription> TraineeSubscriptions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<TrainerAttendance> TrainerAttendances { get; set; }
        public DbSet<TraineeAttendance> TraineeAttendances { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}