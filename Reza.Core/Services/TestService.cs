using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Reza.Core.Generator;
using Reza.Core.Services.Interfaces;
using Reza.DataLayer.Context;
using Reza.DataLayer.Entitis;

namespace Reza.Core.Services
{
    public class TestService : ITestService
    {
        private RezaContext _context;

        public TestService(RezaContext context)
        {
            _context = context;
        }
        public void Add(TestModel test, IFormFile img)
        {


            test.ImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(img.FileName);

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/testimages",test.ImageName);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                img.CopyTo(stream);
            }


            _context.TestModels.Add(test);
            _context.SaveChanges();
        }

        public void Delete(TestModel test)
        {
            _context.TestModels.Remove(test);
            _context.SaveChanges();
        }

        public void Edit(TestModel test, IFormFile img)
        {
            test.ImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(img.FileName);

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/testimages", test.ImageName);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                img.CopyTo(stream);
            }
            _context.TestModels.Update(test);
            _context.SaveChanges();
        }

        public List<TestModel> GetAll()
        {
            return _context.TestModels.ToList();
        }

        public TestModel GetById(int id)
        {
            return _context.TestModels.Find(id);
        }
    }
}
