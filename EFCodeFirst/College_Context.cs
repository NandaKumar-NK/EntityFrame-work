using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class College_Context:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-KR3SF32I\\SQLEXPRESS; " +
               "initial catalog = College; integrated security=SSPI; " +
               "TrustServerCertificate=True;");
        }
    }
  
}
