using Microsoft.EntityFrameworkCore;
using Reza.DataLayer.Entitis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reza.DataLayer.Context
{
   public class RezaContext:DbContext
    {
        public RezaContext(DbContextOptions<RezaContext> options) : base(options)
        {

        }

        public DbSet<Education> Educations { get; set; }
        public DbSet<TestModel> TestModels { get; set; }

    }
}
