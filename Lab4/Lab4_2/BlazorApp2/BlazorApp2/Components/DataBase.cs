using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Components
{
    internal class DataBasee : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

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
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Gorzow" },
                new Movie() { Id = 2, Title = "Krakow" },
                new Movie() { Id = 3, Title = "Gdansk" }
                );
        }


    }
}
