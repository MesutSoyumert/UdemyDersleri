using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class CalismaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MESUTS-NB\\SQLEXPRESS;Database=Calisma;Trusted_Connection=true");
        }

        public DbSet<Working_Table_1> Working_Table_1s { get; set; }
    }
}
