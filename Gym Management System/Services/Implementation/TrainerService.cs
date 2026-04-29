using Gym_Management_System.Data;
using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Dtos;
using Gym_Management_System.DTOs;
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

        // في الـ Service

        public List<TrainerDisplayDto> GetAll()
        {
            return _gymContext.Trainers
                .Where(t => t.IsActive)
                .Select(t => new TrainerDisplayDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Phone = t.Phone,
                    Specialty = t.Specialty,
                    Salary = t.Salary,
                    HireDate = t.HireDate,
                    TraineeCount = t.Trainees.Count
                }).ToList();
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
