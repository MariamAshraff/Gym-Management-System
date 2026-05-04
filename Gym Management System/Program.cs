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
<<<<<<< HEAD
           var context = new GymContext();
       var trainerService = new TrainerService(context);
          Application.Run(new Form1(trainerService));

           //  To customize application configuration such as set high DPI settings or default font,
         //    see https://aka.ms/applicationconfiguration.
//           ApplicationConfiguration.Initialize();
          //  Application.Run(new StartForm());
      //   ITrainerService trainerService = new TrainerService (context);
           // Application.Run(new Form1();
=======
            //var context = new GymContext();
            //var trainerService = new TrainerService(context);
            Application.Run((new LoginForm()));
            var context = new GymContext();
            var trainerService = new TrainerService(context);
            //Application.Run(new TraineeSubscriptionFormcs
            //    (new TraineeSubscriptionService(context),
            //     new TrainingProgramService(context),
            //     new TraineesService(context),
            //     new OfferService(context),
            //     new PaymentService(context),
            //     new Service(context)));
            //Application.Run(new TraineeAttendenceForm(
              //  new TraineeAttendenceService(context),
                //new TraineeSubscriptionService(context),
                //new TraineesService(context)));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //            ApplicationConfiguration.Initialize();
            //  Application.Run(new StartForm());
            //ITraineesService traineesService = new TraineesService(context);
            //Application.Run(new TraineesForm(traineesService));
            //ITrainerService trainersService = new TrainerService(context);
            //Application.Run(new Form1(trainersService));
>>>>>>> c75c1ed521516b3a2c01ac7d6eb35f4b68eea8a9


        }
    }
}