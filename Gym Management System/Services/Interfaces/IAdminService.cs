using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Interfaces
{
    internal interface IAdminService
    {
        void AddUser(string username, string password, string role);

    }
}
