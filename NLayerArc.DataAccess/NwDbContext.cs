using Microsoft.EntityFrameworkCore;
using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.DataAccess
{
    public class NwDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JG1EVTR; Database=Northwind; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; } // Database Products tablosu ile olusturmuş olduğumuz Product Sınıfı arasında bağlantı sağladık.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        //public DbSet<Personnel> Personnels { get; set; } // Database tarafında ya da model sınıfı tarafındaki entity ve property isimlendirme farkları olabilir.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("dbo"); // Veri tabanınınzdaki ilgili şemayı burdan belirtebiliriz.
        //    modelBuilder.Entity<Personnel>().ToTable("Employees"); // Veri tabanındaki hedefimiz olan asıl tabloya böyle bağlantı sağlayabiliriz. Böylece isimlendirmeden kaynaklı bağlantı sorununu çözeriz.
        //    modelBuilder.Entity<Personnel>().Property(p => p.Id).HasColumnName("EmployeeID");     //\
        //    modelBuilder.Entity<Personnel>().Property(p => p.Name).HasColumnName("FirstName");    //  ->  Tabloların kolon isimleriyle nesnenin property alanları böyle bağlanır.
        //    modelBuilder.Entity<Personnel>().Property(p => p.Surname).HasColumnName("LastName");  ///
        //}
    }
}
