using Gym_Management_System.Data.Context;
using Gym_Management_System.Data.Models;
using Gym_Management_System.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Implementation
{
    internal class TraineeSubscriptionService:ITraineeSubscriptionService
    {
        private readonly GymContext _context;

        public TraineeSubscriptionService(GymContext context)
        {
            _context = context;
        }

        public List<TraineeSubscription> GetAll()
        {
            return _context.TraineeSubscriptions
                .ToList();
        }

        public TraineeSubscription? GetById(int id)
        {
            return _context.TraineeSubscriptions
                .FirstOrDefault(t => t.Id == id);
        }

        public void Add(TraineeSubscription trineeSubscription)
        {
            _context.TraineeSubscriptions.Add(trineeSubscription);
            _context.SaveChanges();
        }

        public void Update(TraineeSubscription trineeSubscription)
        {
            var existing = _context.TraineeSubscriptions.Find(trineeSubscription.Id);
            if (existing == null)
                return;

            existing.TraineeId = trineeSubscription.TraineeId;
            existing.TrainingProgramId = trineeSubscription.TrainingProgramId;
            existing.StartDate = trineeSubscription.StartDate;
            existing.EndDate = trineeSubscription.EndDate;
            existing.UsedDays = trineeSubscription.UsedDays;
            existing.PackageTotalDays = trineeSubscription.PackageTotalDays;
            existing.Status = trineeSubscription.Status;
            existing.IsActive = trineeSubscription.IsActive;
            existing.LastCheckIn = DateTime.Now;


            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var subscription = _context.TraineeSubscriptions.Find(id);
            if (subscription == null)
                return;

            _context.TraineeSubscriptions.Remove(subscription);
            _context.SaveChanges();
        }

        public List<TraineeSubscription> GetActivteSubscription()
        {
            return _context.TraineeSubscriptions.Where(t => t.IsActive == true).ToList();
        }
        public bool AlreadySubscribedInProgram(int programId, int traineeId)
        {
            return _context.TraineeSubscriptions.Any(p=> p.TraineeId == traineeId && p.TrainingProgramId  == programId); 
        }
    }
}
