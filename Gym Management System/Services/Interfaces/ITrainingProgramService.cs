using Gym_Management_System.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System.Services.Interfaces
{
    public interface ITrainingProgramService
    {
        void AddTrainingProgram(TrainingProgram program);
        List<TrainingProgram> GetTrainingPrograms();
        TrainingProgram? GetTrainingPbyId(int id);
        void UpdateTrainingProgram(TrainingProgram? trainingProgram);
        void DeleteTrainingProgram(int id);
    }
}
