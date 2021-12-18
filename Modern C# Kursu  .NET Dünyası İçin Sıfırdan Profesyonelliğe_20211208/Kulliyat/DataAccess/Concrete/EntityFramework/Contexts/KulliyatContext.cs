using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class KulliyatContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MESUTS-NB\\SQLEXPRESS;Database=Kulliyat;Trusted_Connection=true");
        }

        public DbSet<Author> Authors { get; set; }

    }
}
