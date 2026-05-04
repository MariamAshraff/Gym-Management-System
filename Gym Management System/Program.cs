// Updated upstream
using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;

using Gym_Management_System.Services.Implementation; // تأكد إذا كان المسار Implementation أو Services
using Gym_Management_System.Services.Interfaces;
using Gym_Management_System.Views;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Seeding Admin automatically before program run
            using (var context = new GymContext())
            {
                if (!context.Users.Any())
                {
                    context.Users.Add(new User
                    {
                        Username = "admin",
                        PasswordHash = "123",
                        Role = "Admin"
                    });

                    context.SaveChanges();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ كده بتمرر الـ Service صح
            //var context = new GymContext();
            //var trainerService = new TrainerService(context);
            Application.Run((new LoginForm()));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
          //  Application.Run(new StartForm());
          //  ITraineesService traineesService = new TraineesService();
           // Application.Run(new TraineesForm(traineesService));


        }
    }
}