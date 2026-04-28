using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        
namespace Gym_Management_System.Services.Implementation
{
    public class TraineesService : ITraineesService
    {
       
        private GymContext db = new GymContext();
        public List<TraineeViewModel> GetAll()
        {
            try
            {
                

                return db.Trainees
                    .Include(t => t.Trainer)
                    .Select(t => new TraineeViewModel
                    {
                        Id = t.Id,
                        Name = t.Name,
                        Phone = t.Phone,
                        Age = t.Age,
                        Status = t.Status,
                        CreatedAt = t.CreatedAt,
                        TrainerId = t.TrainerId,
                        TrainerName = t.Trainer != null ? t.Trainer.Name : "No Trainer"
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new List<TraineeViewModel>();
            }
        }
        public Trainee GetById(int id)
        {
            return db.Trainees
                .Include(t => t.Trainer)
                .FirstOrDefault(t => t.Id == id);
        }
        public void Add(Trainee trainee)
        {
            trainee.CreatedAt = DateTime.Now;

            db.Trainees.Add(trainee);
            db.SaveChanges();
        }
        public List<Trainer> GetAllTrainers()
        {
            return db.Trainers.ToList();
        }

        public void Update(Trainee trainee)
        {
            var existing = db.Trainees.Find(trainee.Id);

            if (existing != null)
            {
                existing.Name = trainee.Name;
                existing.Phone = trainee.Phone;
                existing.Age = trainee.Age;
                existing.Status = trainee.Status;
                existing.TrainerId = trainee.TrainerId;

                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var trainee = db.Trainees.Find(id);

            if (trainee != null)
            {
                db.Trainees.Remove(trainee);
                db.SaveChanges();
            }
        }
    }
}
