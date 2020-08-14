using Reza.DataLayer.Entitis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reza.Core.Services.Interfaces
{
    public interface IEducationService
    {

        IEnumerable<Education> GetAllEducation();
        Education GetEducationById(int educationId);
        void InsertEducation(Education educatio);
        void UpdateEducation(Education education);
        void DeleteEducation(Education education);
        void DeleteEducation(int educationId);
        bool EducationExists(int educationId);
        void Save();

    }
}
