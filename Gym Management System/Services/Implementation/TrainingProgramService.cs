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
    internal class TrainingProgramService : ITrainingProgramService
    {
        private GymContext _context;
        public TrainingProgramService(GymContext gymContext)
        {
            this._context = gymContext;
        }
        public void AddTrainingProgram(TrainingProgram program)
        {
            if(program != null)
            {
                _context.TrainingPrograms.Add(program);
            }
        }
        public void DeleteTrainingProgram(int id)
        {
            var Tprogram = _context.TrainingPrograms.FirstOrDefault(p => p.Id == id);
            if (Tprogram != null)
            {
                _context.TrainingPrograms.Remove(Tprogram);
            }
        }

        public TrainingProgram? GetTrainingPbyId(int id)
        {
            return _context.TrainingPrograms.FirstOrDefault(p => p.Id == id);
                
        }

        public List<TrainingProgram> GetTrainingPrograms()
        {
            return _context.TrainingPrograms.ToList();
        }

        public void UpdateTrainingProgram(TrainingProgram? trainingProgram)
        {
            var tProgram =trainingProgram != null?
                _context.TrainingPrograms.FirstOrDefault(p => p.Id == trainingProgram!.Id):null;
            if(tProgram != null)
            {
                tProgram.Price = trainingProgram.Price;
                tProgram.Name = trainingProgram.Name;
                tProgram.AllowedDays = trainingProgram.AllowedDays;
                _context.Entry(tProgram).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }
    }
}
