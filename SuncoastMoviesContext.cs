using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{
    class SuncoastMoviesContext : DbContext
    {
        //DBSet behaves like a list, acts like a list and looks like a list
        //Database powered set
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;database=SuncoastMovies");
        }
    }
}