using Gym_Management_System.Data.Context;
using Gym_Management_System.Services.Interfaces;
using Gym_Management_System.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Implementation
{
    internal class AuthService : IAuthService
    {
        private readonly GymContext _context;

        public AuthService(GymContext context)
        {
            _context = context;
        }

        //public User Register(string username, string password, string role)
        //{
        //    var user = new User
        //    {
        //        Username = username,
        //        PasswordHash = password,
        //        Role = role
        //    };

        //    _context.Users.Add(user);
        //    _context.SaveChanges();

        //    return user;
        //}

        public User Login(string username, string password)
        {
            return _context.Users
                .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
        }
    }
}
