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
    public class PaymentService:IPaymetnService
    {
        private GymContext _context;
        public PaymentService(GymContext context)
        {
            this._context = context;            
        }

        public void Add(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public List<Payment> GetPayments()
        {
            return _context.Payments.ToList();
        }

        public List<Payment> GetPayments(string PaymentMehtod)
        {
            return _context.Payments.Where(p=>p.Method.Contains(PaymentMehtod)).ToList();
        }
    }
}
