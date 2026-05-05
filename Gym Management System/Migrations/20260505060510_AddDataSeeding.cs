using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gym_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "HireDate", "IsActive", "Name", "Phone", "Salary", "Specialty" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Ahmed Hassan", "01000000001", 8000m, "Fitness" },
                    { 2, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mohamed Ali", "01000000002", 9000m, "Bodybuilding" },
                    { 3, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sara Ibrahim", "01000000003", 7000m, "Yoga" },
                    { 4, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mona Khaled", "01000000004", 6500m, "Zumba" },
                    { 5, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Omar Tarek", "01000000005", 9500m, "CrossFit" }
                });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "AllowedDays", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 18, "Boxing", 800m },
                    { 2, 20, "Karate", 1400m },
                    { 3, 25, "Mixed Fitness", 1800m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "PasswordHash", "Role", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_1", "Admin", "admin1" },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_2", "Admin", "admin2" },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hashed_password_3", "Admin", "admin3" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "DiscountPercentage", "EndDate", "Name", "StartDate", "SubscriptionId" },
                values: new object[,]
                {
                    { 1, 20m, new DateTime(2026, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Year Offer", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 15m, new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Shape Discount", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Age", "CreatedAt", "Name", "Phone", "Status", "TrainerId" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar Hassan", "01100000001", 1, 1 },
                    { 2, 30, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Samy", "01100000002", 1, 2 },
                    { 3, 22, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed Adel", "01100000003", 3, 3 },
                    { 4, 28, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Youssef Khaled", "01100000004", 1, 4 },
                    { 5, 35, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mahmoud Tarek", "01100000005", 1, 5 },
                    { 6, 27, new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ali Ibrahim", "01100000006", 1, 1 },
                    { 7, 24, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hassan Mostafa", "01100000007", 2, 2 },
                    { 8, 29, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karim Nabil", "01100000008", 1, 3 },
                    { 9, 31, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amr Salah", "01100000009", 3, 4 },
                    { 10, 26, new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mostafa Hany", "01100000010", 1, 5 },
                    { 11, 23, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara Ahmed", "01100000011", 1, 1 },
                    { 12, 27, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mona Ali", "01100000012", 1, 2 },
                    { 13, 21, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nour Ibrahim", "01100000013", 2, 3 },
                    { 14, 29, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aya Khaled", "01100000014", 1, 4 },
                    { 15, 33, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huda Mahmoud", "01100000015", 3, 5 },
                    { 16, 26, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yasmin Adel", "01100000016", 1, 1 },
                    { 17, 24, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salma Tarek", "01100000017", 1, 2 },
                    { 18, 28, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laila Hassan", "01100000018", 2, 3 },
                    { 19, 32, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rania Mostafa", "01100000019", 1, 4 },
                    { 20, 25, new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dina Samy", "01100000020", 1, 5 },
                    { 21, 34, new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khaled Fathy", "01100000021", 1, 1 },
                    { 22, 36, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamer Nasser", "01100000022", 3, 2 },
                    { 23, 38, new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wael Farouk", "01100000023", 1, 3 },
                    { 24, 40, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherif Adel", "01100000024", 1, 4 },
                    { 25, 42, new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hany Saad", "01100000025", 2, 5 },
                    { 26, 27, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghada Ali", "01100000026", 1, 1 },
                    { 27, 31, new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doaa Hassan", "01100000027", 1, 2 },
                    { 28, 35, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eman Khaled", "01100000028", 3, 3 },
                    { 29, 37, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sahar Ibrahim", "01100000029", 1, 4 },
                    { 30, 39, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naglaa Mostafa", "01100000030", 1, 5 },
                    { 31, 28, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fady Nabil", "01100000031", 1, 1 },
                    { 32, 33, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "George Samir", "01100000032", 2, 2 },
                    { 33, 29, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bishoy Adel", "01100000033", 1, 3 },
                    { 34, 41, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramy Naguib", "01100000034", 1, 4 },
                    { 35, 26, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mina Atef", "01100000035", 3, 5 },
                    { 36, 30, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tony Magdy", "01100000036", 1, 1 },
                    { 37, 27, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark Hanna", "01100000037", 1, 2 },
                    { 38, 34, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Sameh", "01100000038", 2, 3 },
                    { 39, 36, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew Fawzy", "01100000039", 1, 4 },
                    { 40, 32, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Adel", "01100000040", 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "TrainerAttendances",
                columns: new[] { "Id", "CheckIn", "CheckOut", "Date", "Notes", "TrainerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 1 },
                    { 2, new DateTime(2025, 5, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slightly late", 1 },
                    { 3, new DateTime(2025, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 15, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 1 },
                    { 4, new DateTime(2025, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning shift", 2 },
                    { 5, new DateTime(2025, 5, 2, 9, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 2 },
                    { 6, new DateTime(2025, 5, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 2 },
                    { 7, new DateTime(2025, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evening shift", 3 },
                    { 8, new DateTime(2025, 5, 2, 10, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 18, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 3 },
                    { 9, new DateTime(2025, 5, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Left early", 3 },
                    { 10, new DateTime(2025, 5, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 4 },
                    { 11, new DateTime(2025, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 4 },
                    { 12, new DateTime(2025, 5, 3, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Late check-in", 4 },
                    { 13, new DateTime(2025, 5, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Early shift", 5 },
                    { 14, new DateTime(2025, 5, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 5 },
                    { 15, new DateTime(2025, 5, 3, 8, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal shift", 5 }
                });

            migrationBuilder.InsertData(
                table: "TraineeSubscriptions",
                columns: new[] { "Id", "EndDate", "IsActive", "LastCheckIn", "Months", "PackageTotalDays", "StartDate", "Status", "TraineeId", "TrainingProgramId", "UsedDays" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 18 },
                    { 2, new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 2, 40 },
                    { 3, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 3, 60 },
                    { 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, 1, 30 },
                    { 5, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, 2, 55 },
                    { 6, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6, 1, 10 },
                    { 7, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, 2, 20 },
                    { 8, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, 3, 35 },
                    { 9, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9, 1, 5 },
                    { 10, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, 2, 15 },
                    { 11, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 11, 3, 25 },
                    { 12, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 12, 1, 12 },
                    { 13, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 13, 2, 22 },
                    { 14, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 14, 3, 45 },
                    { 15, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, 1, 8 },
                    { 16, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 16, 2, 10 },
                    { 17, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17, 3, 20 },
                    { 18, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18, 1, 3 },
                    { 19, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 19, 2, 5 },
                    { 20, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 20, 3, 12 },
                    { 21, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 21, 1, 0 },
                    { 22, new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 22, 2, 0 },
                    { 23, new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 23, 3, 0 },
                    { 24, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 24, 1, 0 },
                    { 25, new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25, 2, 0 },
                    { 26, new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 26, 3, 0 },
                    { 27, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 27, 1, 0 },
                    { 28, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 60, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 28, 2, 0 },
                    { 29, new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 90, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 29, 3, 0 },
                    { 30, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Method", "PaidAt", "TraineeSubscriptionId" },
                values: new object[,]
                {
                    { 1, 800m, "Cash", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 1400m, "Card", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 1800m, "Cash", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 800m, "Card", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 1400m, "Cash", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 800m, "Cash", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, 1400m, "Card", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 8, 1800m, "Cash", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, 800m, "Cash", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, 1400m, "Card", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 11, 1800m, "Cash", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 12, 800m, "Card", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 13, 1400m, "Cash", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 14, 1800m, "Card", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 15, 800m, "Cash", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 16, 1400m, "Card", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 17, 1800m, "Cash", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 18, 800m, "Cash", new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 19, 1400m, "Card", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 20, 1800m, "Cash", new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, 800m, "Card", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 22, 1400m, "Cash", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 23, 1800m, "Card", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 24, 800m, "Cash", new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 25, 1400m, "Card", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 26, 1800m, "Cash", new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 27, 800m, "Card", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 28, 1400m, "Cash", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 29, 1800m, "Card", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 30, 800m, "Cash", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 }
                });

            migrationBuilder.InsertData(
                table: "TraineeAttendances",
                columns: new[] { "Id", "CheckIn", "TraineeSubscriptionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 13, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 14, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 15, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 16, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 17, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 18, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 19, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TraineeAttendances",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TrainerAttendances",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TraineeSubscriptions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
