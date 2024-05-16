using CodeFirstCrudExample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCrudExample.Data.Contexts
{
    public class ProjectContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=ProductCrudDb;Trusted_Connection=true;TrustServerCertificate=true");


            base.OnConfiguring(optionsBuilder);
        }
    }
}
