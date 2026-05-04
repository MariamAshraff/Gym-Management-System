using Gym_Management_System.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Interfaces
{
    public interface IPaymetnService
    {
        List<Payment> GetPayments();
        void Add(Payment payment);
        List<Payment> GetPayments(string PaymentMehtod);
    }
}
