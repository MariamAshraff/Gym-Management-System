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
    internal class OfferService : IOfferService
    {
        private GymContext _context;
        public OfferService(GymContext gymContext)
        {
            this._context = gymContext;
        }
        public Offer? GetOfferForProgram(int TrainingProgramId)
        {
            var offer = _context.Offers.FirstOrDefault(o=> o.SubscriptionId == TrainingProgramId);
            return offer;
        }

        public List<Offer> GetOffers()
        {
            return _context.Offers.ToList();
        }
    }
}
