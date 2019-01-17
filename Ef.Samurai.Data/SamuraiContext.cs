using Microsoft.EntityFrameworkCore;
using EfSamurai.Domain; 
using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Data
{
    class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quotes> QuotesDbSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EfSamurai;");

        }

    }
}
