using _09_InherıtanceIECore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InherıtanceIECore.Context
{
    internal class AppDBContext:DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("(Data Source=DESKTOP-785CG1C;Initial Catalog=Inherıtance;Integrated Security=True;TrustServerCertificate=True\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models");
        }

    }
}
