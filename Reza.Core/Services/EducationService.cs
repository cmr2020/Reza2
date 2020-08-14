using Reza.Core.Services.Interfaces;
using Reza.DataLayer.Context;
using Reza.DataLayer.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reza.Core.Services
{
    public class EducationService : IEducationService
    {
        private RezaContext _context;

        public EducationService(RezaContext context)
        {
            _context = context;
        }
        public IEnumerable<Education> GetAllEducation()
        {
           return _context.Educations.ToList();
        }

        public Education GetEducationById(int educationId)
        {
            return _context.Educations.Find(educationId);
        }

        public void InsertEducation(Education educatio)
        {
           _context.Educations.Add(educatio);
            _context.SaveChanges();
        }

        public void UpdateEducation(Education education)
        {
            _context.Update(education);
            _context.SaveChanges();
        }

        public void DeleteEducation(Education education)
        {
            _context.Remove(education);
            _context.SaveChanges();
        }

        public void DeleteEducation(int educationId)
        {
            var GetById = GetEducationById(educationId);
            DeleteEducation(GetById);
        }

        public bool EducationExists(int educationId)
        {
            return _context.Educations.Any(e => e.Id == educationId);
        }

       
        public void Save()
        {
            _context.SaveChanges();
        }

      
    }
}
