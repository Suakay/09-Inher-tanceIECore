using _11_DataAnalition.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnalition.Context
{
    internal class AppDBContext
    {

        internal class AppDBContext : DbContext
        {
            public DbSet<Book>{get;set;}
            public DbSet<Customer> Customers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-785CG1C;Initial Catalog=Inherıtance;Integrated Security=True;TrustServerCertificate=True");
            }
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //COLUMN
            ModelBuilder.Entity<Book>()
                .Property(base=>base.Title)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(50)")
                .HasColumnOrder(2);
            //DatabaseGenared
            //  ModelBuilder.Entity<Contact>()
            //.Prperty(p.=>p.AuthorFK)
            //.HASF

            ModelBuilder.Entity<Order>()
                .HasKey(0=>o.OrderNumber);

            //Key
            ModelBuilder.Entity<Order>()
                .HasKey(o=>o.OrderNumber);  ,
            //Composite keys
            //modelBuilder.Entity<order>()
            //.HasKey(o.=>new{o.CustomerAbbreviation,o.OrderNumber}];

            //
            base.OnModelCreating(ModelBuilder);
            //NotMapped-Entity
            ModelBuilder.Ignore<AuditLog>();
            //NOTmAPPED-PROPERTY

            ModelBuilder.Entity<Contact>()
                .Ignore(char=> char.FullName);
            //Required
            ModelBuilder.Entity<Book>()
                .Propert(b => b.Title)
                .IsRequired();
            //Table Attribute
            ModelBuilder.Entity<Book>()
                .Propert(b => b.Name);
                .hasf



        }

    }
}
