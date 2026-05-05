using Gym_Management_System.Data.Enums;
using Gym_Management_System.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Data.Context
{
    public class GymContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=GymSystem; Integrated Security=True; TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=LAPTOP-C0VV8CJS\\MSSQLSERVER29;Initial Catalog=GymSystem; Integrated Security=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin1",
                    PasswordHash = "hashed_password_1",
                    Role = "Admin",
                    CreatedAt = new DateTime(2026, 1, 1)
                },
                new User
                {
                    Id = 2,
                    Username = "admin2",
                    PasswordHash = "hashed_password_2",
                    Role = "Admin",
                    CreatedAt = new DateTime(2026, 1, 1)
                },
                new User
                {
                    Id = 3,
                    Username = "admin3",
                    PasswordHash = "hashed_password_3",
                    Role = "Admin",
                    CreatedAt = new DateTime(2026, 1, 1)
                }
            );
            modelBuilder.Entity<Trainer>().HasData(
                new Trainer
                {
                    Id = 1,
                    Name = "Ahmed Hassan",
                    Phone = "01000000001",
                    Specialty = "Fitness",
                    Salary = 8000,
                    IsActive = true,
                    HireDate = new DateTime(2025, 1, 1)
                },
                new Trainer
                {
                    Id = 2,
                    Name = "Mohamed Ali",
                    Phone = "01000000002",
                    Specialty = "Bodybuilding",
                    Salary = 9000,
                    IsActive = true,
                    HireDate = new DateTime(2025, 2, 1)
                },
                new Trainer
                {
                    Id = 3,
                    Name = "Sara Ibrahim",
                    Phone = "01000000003",
                    Specialty = "Yoga",
                    Salary = 7000,
                    IsActive = true,
                    HireDate = new DateTime(2025, 3, 1)
                },
                new Trainer
                {
                    Id = 4,
                    Name = "Mona Khaled",
                    Phone = "01000000004",
                    Specialty = "Zumba",
                    Salary = 6500,
                    IsActive = true,
                    HireDate = new DateTime(2025, 4, 1)
                },
                new Trainer
                {
                    Id = 5,
                    Name = "Omar Tarek",
                    Phone = "01000000005",
                    Specialty = "CrossFit",
                    Salary = 9500,
                    IsActive = true,
                    HireDate = new DateTime(2025, 5, 1)
                }
            );
            modelBuilder.Entity<Trainee>().HasData(
                new Trainee { Id = 1, Name = "Omar Hassan", Phone = "01100000001", Age = 25, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 1, 2) },
                new Trainee { Id = 2, Name = "Ahmed Samy", Phone = "01100000002", Age = 30, Status = SubscriptionStatus.Active, TrainerId = 2, CreatedAt = new DateTime(2025, 1, 3) },
                new Trainee { Id = 3, Name = "Mohamed Adel", Phone = "01100000003", Age = 22, Status = SubscriptionStatus.Expired, TrainerId = 3, CreatedAt = new DateTime(2025, 1, 4) },
                new Trainee { Id = 4, Name = "Youssef Khaled", Phone = "01100000004", Age = 28, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 1, 5) },
                new Trainee { Id = 5, Name = "Mahmoud Tarek", Phone = "01100000005", Age = 35, Status = SubscriptionStatus.Active, TrainerId = 5, CreatedAt = new DateTime(2025, 1, 6) },

                new Trainee { Id = 6, Name = "Ali Ibrahim", Phone = "01100000006", Age = 27, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 1, 7) },
                new Trainee { Id = 7, Name = "Hassan Mostafa", Phone = "01100000007", Age = 24, Status = SubscriptionStatus.Frozen, TrainerId = 2, CreatedAt = new DateTime(2025, 1, 8) },
                new Trainee { Id = 8, Name = "Karim Nabil", Phone = "01100000008", Age = 29, Status = SubscriptionStatus.Active, TrainerId = 3, CreatedAt = new DateTime(2025, 1, 9) },
                new Trainee { Id = 9, Name = "Amr Salah", Phone = "01100000009", Age = 31, Status = SubscriptionStatus.Expired, TrainerId = 4, CreatedAt = new DateTime(2025, 1, 10) },
                new Trainee { Id = 10, Name = "Mostafa Hany", Phone = "01100000010", Age = 26, Status = SubscriptionStatus.Active, TrainerId = 5, CreatedAt = new DateTime(2025, 1, 11) },

                new Trainee { Id = 11, Name = "Sara Ahmed", Phone = "01100000011", Age = 23, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 1, 12) },
                new Trainee { Id = 12, Name = "Mona Ali", Phone = "01100000012", Age = 27, Status = SubscriptionStatus.Active, TrainerId = 2, CreatedAt = new DateTime(2025, 1, 13) },
                new Trainee { Id = 13, Name = "Nour Ibrahim", Phone = "01100000013", Age = 21, Status = SubscriptionStatus.Frozen, TrainerId = 3, CreatedAt = new DateTime(2025, 1, 14) },
                new Trainee { Id = 14, Name = "Aya Khaled", Phone = "01100000014", Age = 29, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 1, 15) },
                new Trainee { Id = 15, Name = "Huda Mahmoud", Phone = "01100000015", Age = 33, Status = SubscriptionStatus.Expired, TrainerId = 5, CreatedAt = new DateTime(2025, 1, 16) },

                new Trainee { Id = 16, Name = "Yasmin Adel", Phone = "01100000016", Age = 26, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 1, 17) },
                new Trainee { Id = 17, Name = "Salma Tarek", Phone = "01100000017", Age = 24, Status = SubscriptionStatus.Active, TrainerId = 2, CreatedAt = new DateTime(2025, 1, 18) },
                new Trainee { Id = 18, Name = "Laila Hassan", Phone = "01100000018", Age = 28, Status = SubscriptionStatus.Frozen, TrainerId = 3, CreatedAt = new DateTime(2025, 1, 19) },
                new Trainee { Id = 19, Name = "Rania Mostafa", Phone = "01100000019", Age = 32, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 1, 20) },
                new Trainee { Id = 20, Name = "Dina Samy", Phone = "01100000020", Age = 25, Status = SubscriptionStatus.Active, TrainerId = 5, CreatedAt = new DateTime(2025, 1, 21) },

                new Trainee { Id = 21, Name = "Khaled Fathy", Phone = "01100000021", Age = 34, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 1, 22) },
                new Trainee { Id = 22, Name = "Tamer Nasser", Phone = "01100000022", Age = 36, Status = SubscriptionStatus.Expired, TrainerId = 2, CreatedAt = new DateTime(2025, 1, 23) },
                new Trainee { Id = 23, Name = "Wael Farouk", Phone = "01100000023", Age = 38, Status = SubscriptionStatus.Active, TrainerId = 3, CreatedAt = new DateTime(2025, 1, 24) },
                new Trainee { Id = 24, Name = "Sherif Adel", Phone = "01100000024", Age = 40, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 1, 25) },
                new Trainee { Id = 25, Name = "Hany Saad", Phone = "01100000025", Age = 42, Status = SubscriptionStatus.Frozen, TrainerId = 5, CreatedAt = new DateTime(2025, 1, 26) },

                new Trainee { Id = 26, Name = "Ghada Ali", Phone = "01100000026", Age = 27, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 1, 27) },
                new Trainee { Id = 27, Name = "Doaa Hassan", Phone = "01100000027", Age = 31, Status = SubscriptionStatus.Active, TrainerId = 2, CreatedAt = new DateTime(2025, 1, 28) },
                new Trainee { Id = 28, Name = "Eman Khaled", Phone = "01100000028", Age = 35, Status = SubscriptionStatus.Expired, TrainerId = 3, CreatedAt = new DateTime(2025, 1, 29) },
                new Trainee { Id = 29, Name = "Sahar Ibrahim", Phone = "01100000029", Age = 37, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 1, 30) },
                new Trainee { Id = 30, Name = "Naglaa Mostafa", Phone = "01100000030", Age = 39, Status = SubscriptionStatus.Active, TrainerId = 5, CreatedAt = new DateTime(2025, 1, 31) },

                new Trainee { Id = 31, Name = "Fady Nabil", Phone = "01100000031", Age = 28, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 2, 1) },
                new Trainee { Id = 32, Name = "George Samir", Phone = "01100000032", Age = 33, Status = SubscriptionStatus.Frozen, TrainerId = 2, CreatedAt = new DateTime(2025, 2, 2) },
                new Trainee { Id = 33, Name = "Bishoy Adel", Phone = "01100000033", Age = 29, Status = SubscriptionStatus.Active, TrainerId = 3, CreatedAt = new DateTime(2025, 2, 3) },
                new Trainee { Id = 34, Name = "Ramy Naguib", Phone = "01100000034", Age = 41, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 2, 4) },
                new Trainee { Id = 35, Name = "Mina Atef", Phone = "01100000035", Age = 26, Status = SubscriptionStatus.Expired, TrainerId = 5, CreatedAt = new DateTime(2025, 2, 5) },

                new Trainee { Id = 36, Name = "Tony Magdy", Phone = "01100000036", Age = 30, Status = SubscriptionStatus.Active, TrainerId = 1, CreatedAt = new DateTime(2025, 2, 6) },
                new Trainee { Id = 37, Name = "Mark Hanna", Phone = "01100000037", Age = 27, Status = SubscriptionStatus.Active, TrainerId = 2, CreatedAt = new DateTime(2025, 2, 7) },
                new Trainee { Id = 38, Name = "Peter Sameh", Phone = "01100000038", Age = 34, Status = SubscriptionStatus.Frozen, TrainerId = 3, CreatedAt = new DateTime(2025, 2, 8) },
                new Trainee { Id = 39, Name = "Andrew Fawzy", Phone = "01100000039", Age = 36, Status = SubscriptionStatus.Active, TrainerId = 4, CreatedAt = new DateTime(2025, 2, 9) },
                new Trainee { Id = 40, Name = "Michael Adel", Phone = "01100000040", Age = 32, Status = SubscriptionStatus.Active, TrainerId = 5, CreatedAt = new DateTime(2025, 2, 10) }
                );
            modelBuilder.Entity<Offer>().HasData(
                new Offer
                {
                    Id = 1,
                    Name = "New Year Offer",
                    DiscountPercentage = 20,
                    StartDate = new DateTime(2026, 1, 1),
                    EndDate = new DateTime(2026, 1, 31),
                    SubscriptionId = 1
                },
                new Offer
                {
                    Id = 2,
                    Name = "Summer Shape Discount",
                    DiscountPercentage = 15,
                    StartDate = new DateTime(2026, 6, 1),
                    EndDate = new DateTime(2026, 6, 30),
                    SubscriptionId = 2
                }
            );
            modelBuilder.Entity<TrainingProgram>().HasData(
                 new TrainingProgram
                 {
                     Id = 1,
                     Name = "Boxing",
                     AllowedDays = 18,
                     Price = 800
                 },
                 new TrainingProgram
                 {
                     Id = 2,
                     Name = "Karate",
                     AllowedDays = 20,
                     Price = 1400
                 },
                 new TrainingProgram
                 {
                     Id = 3,
                     Name = "Mixed Fitness",
                     AllowedDays = 25,
                     Price = 1800
                 }
             );
            modelBuilder.Entity<TraineeSubscription>().HasData(
                new TraineeSubscription { Id = 1, TraineeId = 1, TrainingProgramId = 1, StartDate = new DateTime(2025, 1, 1), EndDate = new DateTime(2025, 2, 1), Months = 1, PackageTotalDays = 30, UsedDays = 18, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 1, 20), IsActive = true },
                new TraineeSubscription { Id = 2, TraineeId = 2, TrainingProgramId = 2, StartDate = new DateTime(2025, 1, 3), EndDate = new DateTime(2025, 3, 3), Months = 2, PackageTotalDays = 60, UsedDays = 40, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 2, 20), IsActive = true },
                new TraineeSubscription { Id = 3, TraineeId = 3, TrainingProgramId = 3, StartDate = new DateTime(2025, 1, 5), EndDate = new DateTime(2025, 4, 5), Months = 3, PackageTotalDays = 90, UsedDays = 60, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 3, 1), IsActive = true },

                new TraineeSubscription { Id = 4, TraineeId = 4, TrainingProgramId = 1, StartDate = new DateTime(2024, 12, 1), EndDate = new DateTime(2025, 1, 1), Months = 1, PackageTotalDays = 30, UsedDays = 30, Status = SubscriptionStatus.Expired, LastCheckIn = new DateTime(2024, 12, 30), IsActive = false },
                new TraineeSubscription { Id = 5, TraineeId = 5, TrainingProgramId = 2, StartDate = new DateTime(2024, 11, 15), EndDate = new DateTime(2025, 1, 15), Months = 2, PackageTotalDays = 60, UsedDays = 55, Status = SubscriptionStatus.Expired, LastCheckIn = new DateTime(2025, 1, 10), IsActive = false },

                new TraineeSubscription { Id = 6, TraineeId = 6, TrainingProgramId = 1, StartDate = new DateTime(2025, 2, 1), EndDate = new DateTime(2025, 3, 1), Months = 1, PackageTotalDays = 30, UsedDays = 10, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 2, 18), IsActive = true },
                new TraineeSubscription { Id = 7, TraineeId = 7, TrainingProgramId = 2, StartDate = new DateTime(2025, 2, 5), EndDate = new DateTime(2025, 4, 5), Months = 2, PackageTotalDays = 60, UsedDays = 20, Status = SubscriptionStatus.Frozen, LastCheckIn = new DateTime(2025, 2, 25), IsActive = true },
                new TraineeSubscription { Id = 8, TraineeId = 8, TrainingProgramId = 3, StartDate = new DateTime(2025, 2, 10), EndDate = new DateTime(2025, 5, 10), Months = 3, PackageTotalDays = 90, UsedDays = 35, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 3, 5), IsActive = true },

                new TraineeSubscription { Id = 9, TraineeId = 9, TrainingProgramId = 1, StartDate = new DateTime(2025, 3, 1), EndDate = new DateTime(2025, 4, 1), Months = 1, PackageTotalDays = 30, UsedDays = 5, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 3, 10), IsActive = true },
                new TraineeSubscription { Id = 10, TraineeId = 10, TrainingProgramId = 2, StartDate = new DateTime(2025, 3, 3), EndDate = new DateTime(2025, 5, 3), Months = 2, PackageTotalDays = 60, UsedDays = 15, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 3, 20), IsActive = true },

                new TraineeSubscription { Id = 11, TraineeId = 11, TrainingProgramId = 3, StartDate = new DateTime(2025, 3, 5), EndDate = new DateTime(2025, 6, 5), Months = 3, PackageTotalDays = 90, UsedDays = 25, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 1), IsActive = true },
                new TraineeSubscription { Id = 12, TraineeId = 12, TrainingProgramId = 1, StartDate = new DateTime(2025, 3, 10), EndDate = new DateTime(2025, 4, 10), Months = 1, PackageTotalDays = 30, UsedDays = 12, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 3, 25), IsActive = true },

                new TraineeSubscription { Id = 13, TraineeId = 13, TrainingProgramId = 2, StartDate = new DateTime(2025, 3, 15), EndDate = new DateTime(2025, 5, 15), Months = 2, PackageTotalDays = 60, UsedDays = 22, Status = SubscriptionStatus.Frozen, LastCheckIn = new DateTime(2025, 4, 2), IsActive = true },
                new TraineeSubscription { Id = 14, TraineeId = 14, TrainingProgramId = 3, StartDate = new DateTime(2025, 3, 20), EndDate = new DateTime(2025, 6, 20), Months = 3, PackageTotalDays = 90, UsedDays = 45, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 10), IsActive = true },

                new TraineeSubscription { Id = 15, TraineeId = 15, TrainingProgramId = 1, StartDate = new DateTime(2025, 4, 1), EndDate = new DateTime(2025, 5, 1), Months = 1, PackageTotalDays = 30, UsedDays = 8, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 15), IsActive = true },

                new TraineeSubscription { Id = 16, TraineeId = 16, TrainingProgramId = 2, StartDate = new DateTime(2025, 4, 5), EndDate = new DateTime(2025, 6, 5), Months = 2, PackageTotalDays = 60, UsedDays = 10, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 18), IsActive = true },
                new TraineeSubscription { Id = 17, TraineeId = 17, TrainingProgramId = 3, StartDate = new DateTime(2025, 4, 10), EndDate = new DateTime(2025, 7, 10), Months = 3, PackageTotalDays = 90, UsedDays = 20, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 25), IsActive = true },

                new TraineeSubscription { Id = 18, TraineeId = 18, TrainingProgramId = 1, StartDate = new DateTime(2025, 4, 15), EndDate = new DateTime(2025, 5, 15), Months = 1, PackageTotalDays = 30, UsedDays = 3, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 20), IsActive = true },

                new TraineeSubscription { Id = 19, TraineeId = 19, TrainingProgramId = 2, StartDate = new DateTime(2025, 4, 20), EndDate = new DateTime(2025, 6, 20), Months = 2, PackageTotalDays = 60, UsedDays = 5, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 4, 28), IsActive = true },

                new TraineeSubscription { Id = 20, TraineeId = 20, TrainingProgramId = 3, StartDate = new DateTime(2025, 4, 25), EndDate = new DateTime(2025, 7, 25), Months = 3, PackageTotalDays = 90, UsedDays = 12, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 1), IsActive = true },

                new TraineeSubscription { Id = 21, TraineeId = 21, TrainingProgramId = 1, StartDate = new DateTime(2025, 5, 1), EndDate = new DateTime(2025, 6, 1), Months = 1, PackageTotalDays = 30, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 2), IsActive = true },

                new TraineeSubscription { Id = 22, TraineeId = 22, TrainingProgramId = 2, StartDate = new DateTime(2025, 5, 3), EndDate = new DateTime(2025, 7, 3), Months = 2, PackageTotalDays = 60, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 3), IsActive = true },

                new TraineeSubscription { Id = 23, TraineeId = 23, TrainingProgramId = 3, StartDate = new DateTime(2025, 5, 5), EndDate = new DateTime(2025, 8, 5), Months = 3, PackageTotalDays = 90, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 5), IsActive = true },

                new TraineeSubscription { Id = 24, TraineeId = 24, TrainingProgramId = 1, StartDate = new DateTime(2025, 5, 6), EndDate = new DateTime(2025, 6, 6), Months = 1, PackageTotalDays = 30, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 6), IsActive = true },

                new TraineeSubscription { Id = 25, TraineeId = 25, TrainingProgramId = 2, StartDate = new DateTime(2025, 5, 7), EndDate = new DateTime(2025, 7, 7), Months = 2, PackageTotalDays = 60, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 7), IsActive = true },

                new TraineeSubscription { Id = 26, TraineeId = 26, TrainingProgramId = 3, StartDate = new DateTime(2025, 5, 8), EndDate = new DateTime(2025, 8, 8), Months = 3, PackageTotalDays = 90, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 8), IsActive = true },

                new TraineeSubscription { Id = 27, TraineeId = 27, TrainingProgramId = 1, StartDate = new DateTime(2025, 5, 9), EndDate = new DateTime(2025, 6, 9), Months = 1, PackageTotalDays = 30, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 9), IsActive = true },

                new TraineeSubscription { Id = 28, TraineeId = 28, TrainingProgramId = 2, StartDate = new DateTime(2025, 5, 10), EndDate = new DateTime(2025, 7, 10), Months = 2, PackageTotalDays = 60, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 10), IsActive = true },

                new TraineeSubscription { Id = 29, TraineeId = 29, TrainingProgramId = 3, StartDate = new DateTime(2025, 5, 11), EndDate = new DateTime(2025, 8, 11), Months = 3, PackageTotalDays = 90, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 11), IsActive = true },

                new TraineeSubscription { Id = 30, TraineeId = 30, TrainingProgramId = 1, StartDate = new DateTime(2025, 5, 12), EndDate = new DateTime(2025, 6, 12), Months = 1, PackageTotalDays = 30, UsedDays = 0, Status = SubscriptionStatus.Active, LastCheckIn = new DateTime(2025, 5, 12), IsActive = true }
            );
            modelBuilder.Entity<Payment>().HasData(

                new Payment { Id = 1, TraineeSubscriptionId = 1, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 1, 1) },
                new Payment { Id = 2, TraineeSubscriptionId = 2, Amount = 1400, Method = "Card", PaidAt = new DateTime(2025, 1, 3) },
                new Payment { Id = 3, TraineeSubscriptionId = 3, Amount = 1800, Method = "Cash", PaidAt = new DateTime(2025, 1, 5) },

                new Payment { Id = 4, TraineeSubscriptionId = 4, Amount = 800, Method = "Card", PaidAt = new DateTime(2024, 12, 1) },
                new Payment { Id = 5, TraineeSubscriptionId = 5, Amount = 1400, Method = "Cash", PaidAt = new DateTime(2024, 11, 15) },

                new Payment { Id = 6, TraineeSubscriptionId = 6, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 2, 1) },
                new Payment { Id = 7, TraineeSubscriptionId = 7, Amount = 1400, Method = "Card", PaidAt = new DateTime(2025, 2, 5) },
                new Payment { Id = 8, TraineeSubscriptionId = 8, Amount = 1800, Method = "Cash", PaidAt = new DateTime(2025, 2, 10) },

                new Payment { Id = 9, TraineeSubscriptionId = 9, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 3, 1) },
                new Payment { Id = 10, TraineeSubscriptionId = 10, Amount = 1400, Method = "Card", PaidAt = new DateTime(2025, 3, 3) },

                new Payment { Id = 11, TraineeSubscriptionId = 11, Amount = 1800, Method = "Cash", PaidAt = new DateTime(2025, 3, 5) },
                new Payment { Id = 12, TraineeSubscriptionId = 12, Amount = 800, Method = "Card", PaidAt = new DateTime(2025, 3, 10) },

                new Payment { Id = 13, TraineeSubscriptionId = 13, Amount = 1400, Method = "Cash", PaidAt = new DateTime(2025, 3, 15) },
                new Payment { Id = 14, TraineeSubscriptionId = 14, Amount = 1800, Method = "Card", PaidAt = new DateTime(2025, 3, 20) },

                new Payment { Id = 15, TraineeSubscriptionId = 15, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 4, 1) },
                new Payment { Id = 16, TraineeSubscriptionId = 16, Amount = 1400, Method = "Card", PaidAt = new DateTime(2025, 4, 5) },
                new Payment { Id = 17, TraineeSubscriptionId = 17, Amount = 1800, Method = "Cash", PaidAt = new DateTime(2025, 4, 10) },

                new Payment { Id = 18, TraineeSubscriptionId = 18, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 4, 15) },
                new Payment { Id = 19, TraineeSubscriptionId = 19, Amount = 1400, Method = "Card", PaidAt = new DateTime(2025, 4, 20) },
                new Payment { Id = 20, TraineeSubscriptionId = 20, Amount = 1800, Method = "Cash", PaidAt = new DateTime(2025, 4, 25) },

                new Payment { Id = 21, TraineeSubscriptionId = 21, Amount = 800, Method = "Card", PaidAt = new DateTime(2025, 5, 1) },
                new Payment { Id = 22, TraineeSubscriptionId = 22, Amount = 1400, Method = "Cash", PaidAt = new DateTime(2025, 5, 3) },
                new Payment { Id = 23, TraineeSubscriptionId = 23, Amount = 1800, Method = "Card", PaidAt = new DateTime(2025, 5, 5) },

                new Payment { Id = 24, TraineeSubscriptionId = 24, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 5, 6) },
                new Payment { Id = 25, TraineeSubscriptionId = 25, Amount = 1400, Method = "Card", PaidAt = new DateTime(2025, 5, 7) },
                new Payment { Id = 26, TraineeSubscriptionId = 26, Amount = 1800, Method = "Cash", PaidAt = new DateTime(2025, 5, 8) },

                new Payment { Id = 27, TraineeSubscriptionId = 27, Amount = 800, Method = "Card", PaidAt = new DateTime(2025, 5, 9) },
                new Payment { Id = 28, TraineeSubscriptionId = 28, Amount = 1400, Method = "Cash", PaidAt = new DateTime(2025, 5, 10) },
                new Payment { Id = 29, TraineeSubscriptionId = 29, Amount = 1800, Method = "Card", PaidAt = new DateTime(2025, 5, 11) },
                new Payment { Id = 30, TraineeSubscriptionId = 30, Amount = 800, Method = "Cash", PaidAt = new DateTime(2025, 5, 12) }
            );
            modelBuilder.Entity<TraineeAttendance>().HasData(

                new TraineeAttendance { Id = 1, TraineeSubscriptionId = 1, CheckIn = new DateTime(2025, 1, 2) },
                new TraineeAttendance { Id = 2, TraineeSubscriptionId = 1, CheckIn = new DateTime(2025, 1, 5) },
                new TraineeAttendance { Id = 3, TraineeSubscriptionId = 1, CheckIn = new DateTime(2025, 1, 9) },

                new TraineeAttendance { Id = 4, TraineeSubscriptionId = 2, CheckIn = new DateTime(2025, 1, 4) },
                new TraineeAttendance { Id = 5, TraineeSubscriptionId = 2, CheckIn = new DateTime(2025, 1, 8) },
                new TraineeAttendance { Id = 6, TraineeSubscriptionId = 2, CheckIn = new DateTime(2025, 1, 12) },

                new TraineeAttendance { Id = 7, TraineeSubscriptionId = 3, CheckIn = new DateTime(2025, 1, 6) },
                new TraineeAttendance { Id = 8, TraineeSubscriptionId = 3, CheckIn = new DateTime(2025, 1, 10) },
                new TraineeAttendance { Id = 9, TraineeSubscriptionId = 3, CheckIn = new DateTime(2025, 1, 15) },

                new TraineeAttendance { Id = 10, TraineeSubscriptionId = 4, CheckIn = new DateTime(2024, 12, 2) },
                new TraineeAttendance { Id = 11, TraineeSubscriptionId = 4, CheckIn = new DateTime(2024, 12, 10) },

                new TraineeAttendance { Id = 12, TraineeSubscriptionId = 5, CheckIn = new DateTime(2024, 11, 20) },
                new TraineeAttendance { Id = 13, TraineeSubscriptionId = 5, CheckIn = new DateTime(2024, 12, 5) },

                new TraineeAttendance { Id = 14, TraineeSubscriptionId = 6, CheckIn = new DateTime(2025, 2, 2) },
                new TraineeAttendance { Id = 15, TraineeSubscriptionId = 6, CheckIn = new DateTime(2025, 2, 6) },

                new TraineeAttendance { Id = 16, TraineeSubscriptionId = 7, CheckIn = new DateTime(2025, 2, 6) },
                new TraineeAttendance { Id = 17, TraineeSubscriptionId = 7, CheckIn = new DateTime(2025, 2, 12) },

                new TraineeAttendance { Id = 18, TraineeSubscriptionId = 8, CheckIn = new DateTime(2025, 2, 11) },
                new TraineeAttendance { Id = 19, TraineeSubscriptionId = 8, CheckIn = new DateTime(2025, 2, 15) }
            );
            modelBuilder.Entity<TrainerAttendance>().HasData(

                new TrainerAttendance { Id = 1, TrainerId = 1, Date = new DateTime(2025, 5, 1), CheckIn = new DateTime(2025, 5, 1, 8, 0, 0), CheckOut = new DateTime(2025, 5, 1, 16, 0, 0), Notes = "Normal shift" },
                new TrainerAttendance { Id = 2, TrainerId = 1, Date = new DateTime(2025, 5, 2), CheckIn = new DateTime(2025, 5, 2, 8, 15, 0), CheckOut = new DateTime(2025, 5, 2, 16, 30, 0), Notes = "Slightly late" },
                new TrainerAttendance { Id = 3, TrainerId = 1, Date = new DateTime(2025, 5, 3), CheckIn = new DateTime(2025, 5, 3, 8, 0, 0), CheckOut = new DateTime(2025, 5, 3, 15, 45, 0), Notes = "Normal shift" },

                new TrainerAttendance { Id = 4, TrainerId = 2, Date = new DateTime(2025, 5, 1), CheckIn = new DateTime(2025, 5, 1, 9, 0, 0), CheckOut = new DateTime(2025, 5, 1, 17, 0, 0), Notes = "Morning shift" },
                new TrainerAttendance { Id = 5, TrainerId = 2, Date = new DateTime(2025, 5, 2), CheckIn = new DateTime(2025, 5, 2, 9, 10, 0), CheckOut = new DateTime(2025, 5, 2, 17, 20, 0), Notes = "Normal shift" },
                new TrainerAttendance { Id = 6, TrainerId = 2, Date = new DateTime(2025, 5, 3), CheckIn = new DateTime(2025, 5, 3, 9, 0, 0), CheckOut = new DateTime(2025, 5, 3, 17, 0, 0), Notes = "Normal shift" },

                new TrainerAttendance { Id = 7, TrainerId = 3, Date = new DateTime(2025, 5, 1), CheckIn = new DateTime(2025, 5, 1, 10, 0, 0), CheckOut = new DateTime(2025, 5, 1, 18, 0, 0), Notes = "Evening shift" },
                new TrainerAttendance { Id = 8, TrainerId = 3, Date = new DateTime(2025, 5, 2), CheckIn = new DateTime(2025, 5, 2, 10, 5, 0), CheckOut = new DateTime(2025, 5, 2, 18, 10, 0), Notes = "Normal shift" },
                new TrainerAttendance { Id = 9, TrainerId = 3, Date = new DateTime(2025, 5, 3), CheckIn = new DateTime(2025, 5, 3, 10, 0, 0), CheckOut = new DateTime(2025, 5, 3, 17, 50, 0), Notes = "Left early" },

                new TrainerAttendance { Id = 10, TrainerId = 4, Date = new DateTime(2025, 5, 1), CheckIn = new DateTime(2025, 5, 1, 8, 30, 0), CheckOut = new DateTime(2025, 5, 1, 16, 30, 0), Notes = "Normal shift" },
                new TrainerAttendance { Id = 11, TrainerId = 4, Date = new DateTime(2025, 5, 2), CheckIn = new DateTime(2025, 5, 2, 8, 0, 0), CheckOut = new DateTime(2025, 5, 2, 16, 0, 0), Notes = "Normal shift" },
                new TrainerAttendance { Id = 12, TrainerId = 4, Date = new DateTime(2025, 5, 3), CheckIn = new DateTime(2025, 5, 3, 8, 45, 0), CheckOut = new DateTime(2025, 5, 3, 16, 20, 0), Notes = "Late check-in" },

                new TrainerAttendance { Id = 13, TrainerId = 5, Date = new DateTime(2025, 5, 1), CheckIn = new DateTime(2025, 5, 1, 7, 45, 0), CheckOut = new DateTime(2025, 5, 1, 15, 45, 0), Notes = "Early shift" },
                new TrainerAttendance { Id = 14, TrainerId = 5, Date = new DateTime(2025, 5, 2), CheckIn = new DateTime(2025, 5, 2, 8, 0, 0), CheckOut = new DateTime(2025, 5, 2, 16, 0, 0), Notes = "Normal shift" },
                new TrainerAttendance { Id = 15, TrainerId = 5, Date = new DateTime(2025, 5, 3), CheckIn = new DateTime(2025, 5, 3, 8, 10, 0), CheckOut = new DateTime(2025, 5, 3, 16, 10, 0), Notes = "Normal shift" }
            );
        }



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