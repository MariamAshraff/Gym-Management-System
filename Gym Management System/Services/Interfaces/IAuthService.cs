using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Management_System.Data.Models;

namespace Gym_Management_System.Services.Interfaces
{
    internal interface IAuthService
    {
        //User Register(string username, string password, string role);
        User Login(string username, string password);
    }
}
