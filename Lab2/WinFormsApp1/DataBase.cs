using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WinFormsApp1
{
    internal class DataBasee : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DataBasee()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source=Univ.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City() { Id = 1, name = "Gorzow", lat = 0, lon = 0 },
                new City() { Id = 2, name = "Krakow", lat = 0, lon = 0 },
                new City() { Id = 3, name = "Gdansk", lat = 0, lon = 0 }
                );
        }


    }
}
