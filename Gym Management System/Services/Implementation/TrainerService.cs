using Gym_Management_System.Data;
using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gym_Management_System.Services.Implementation
{
    internal class TrainerService : ITrainerService
    {
        private readonly GymContext _gymContext;

        public TrainerService(GymContext gymContext)
        {
            _gymContext = gymContext;
        }

        public List<Trainer> GetAll()
        {
            return _gymContext.Trainers
                .Where(t => t.IsActive)
                .Include(t => t.Trainees)
                .ToList();
        }

        public Trainer GetById(int id)
        {
            return _gymContext.Trainers
                .Include(t => t.Trainees)
                .FirstOrDefault(t => t.Id == id);
        }

        public void Add(Trainer trainer)
        {
            _gymContext.Trainers.Add(trainer);
            _gymContext.SaveChanges();
        }

        public void Update(Trainer trainer)
        {
            _gymContext.Trainers.Update(trainer);
            _gymContext.SaveChanges();
        }

        public void Deactivate(int id)
        {
            var trainer = _gymContext.Trainers.Find(id);
            if (trainer != null)
            {
                trainer.IsActive = false;
                _gymContext.SaveChanges();
            }
        }

        public int GetTraineeCount(int trainerId)
        {
            return _gymContext.Trainees
                .Count(s => s.TrainerId == trainerId); 
        }
    }
}
