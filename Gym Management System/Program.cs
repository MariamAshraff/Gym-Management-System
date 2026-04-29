// Updated upstream
using Gym_Management_System.Data.Context;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ كده بتمرر الـ Service صح
            var context = new GymContext();
            var trainerService = new TrainerService(context);
            Application.Run(new Form1(trainerService));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
          //  Application.Run(new StartForm());
          //  ITraineesService traineesService = new TraineesService();
           // Application.Run(new TraineesForm(traineesService));


        }
    }
}