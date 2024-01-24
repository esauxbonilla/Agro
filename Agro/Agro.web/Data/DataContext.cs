﻿using Agro.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agro.web.Data
{
    public class DataContext:DbContext
    {
        public DbSet<City> cities { get; set; }
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
