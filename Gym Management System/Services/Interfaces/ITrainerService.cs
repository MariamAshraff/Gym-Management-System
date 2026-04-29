using Gym_Management_System.Data.Models;
using Gym_Management_System.Dtos;
using Gym_Management_System.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Interfaces
{
    public interface ITrainerService
    {
       public List<TrainerDisplayDto> GetAll();
        public Trainer GetById(int id);
        public void Add(Trainer trainer);
        public void Update(Trainer trainer);
        public void Deactivate(int id);

        // --- Reports ---
        public int GetTraineeCount(int trainerId);
    }
}
