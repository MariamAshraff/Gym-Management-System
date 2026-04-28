using Gym_Management_System.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Interfaces
{
    public interface ITraineesService
    {
     
        List<TraineeViewModel> GetAll();

        void Add(Trainee trainee);

        void Update(Trainee trainee);

        void Delete(int id);

        List<Trainer> GetAllTrainers();
    }
}
