using _09_EFInheritance2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_EFInheritance2.Context
{
    internal class AppDBContext:DbContext
    {
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-785CG1C;Initial Catalog=Inherıtance;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
