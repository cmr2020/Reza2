using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Reza.DataLayer.Entitis;

namespace Reza.Core.Services.Interfaces
{
   public interface ITestService
   {
       void Add(TestModel test, IFormFile img);
       void Edit(TestModel test, IFormFile img);
       void Delete(TestModel test);
       List<TestModel> GetAll();
       TestModel GetById(int id);
   }
}
