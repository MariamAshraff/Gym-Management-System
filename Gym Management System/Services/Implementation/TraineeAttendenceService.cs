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
    public class TraineeAttendenceService : ITraineeAttendenceService
    {
        private GymContext _context;
        public TraineeAttendenceService(GymContext gymContext)
        {
            this._context = gymContext;
        }
        public bool AddAttendence(int SubscriptionId)
        {
            var subscription = _context.TraineeSubscriptions
                .FirstOrDefault(p=>p.Id == SubscriptionId && p.IsActive);
            if (subscription == null)
                return false;
            if (subscription.UsedDays == subscription.PackageTotalDays)
            {
                subscription.IsActive = false;
                return false;
            }
               
            else
            {
                subscription.UsedDays++;
                subscription.LastCheckIn = DateTime.UtcNow;
                _context.TraineeAttendances.Add(new TraineeAttendance
                {
                    CheckIn = DateTime.UtcNow,
                    TraineeSubscriptionId = SubscriptionId
                });
                _context.SaveChanges();
                return true;
            }
            

        }

        public List<TraineeAttendance> GetAllAttendees()
        {
            return _context.TraineeAttendances.ToList();
        }

        public List<TraineeAttendance> GetTraineeAttendances(int subscriptionId)
        {
            return _context.TraineeAttendances.Where(p=>p.Id == subscriptionId).ToList();
        }
        
    }
}
