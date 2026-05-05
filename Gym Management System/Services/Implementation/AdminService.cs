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
    internal class AdminService : IAdminService
    {
        private readonly GymContext _context;

        public AdminService(GymContext context)
        {
            _context = context;
        }

        public void AddUser(string username, string password, string role)
        {
            var user = new User
            {
                Username = username,
                PasswordHash = password,
                Role = role
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void RemoveUser(int userId)
        {
            var user = _context.Users.Find(userId);

            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
