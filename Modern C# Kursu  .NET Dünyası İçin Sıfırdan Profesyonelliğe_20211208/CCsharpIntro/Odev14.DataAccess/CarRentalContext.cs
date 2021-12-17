using Microsoft.EntityFrameworkCore;
using Odev14.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev14.DataAccess
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CarRental;Trusted_Connection=true");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Araba> Arabas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent mapping
            //modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<Araba>().ToTable("Mars");

            modelBuilder.Entity<Araba>().Property(p => p.Id).HasColumnName("MarId");
            modelBuilder.Entity<Araba>().Property(p => p.ArabaModeli).HasColumnName("Model");
            modelBuilder.Entity<Araba>().Property(p => p.GunlukUcret).HasColumnName("DailyPrice");
        }
    }
}
