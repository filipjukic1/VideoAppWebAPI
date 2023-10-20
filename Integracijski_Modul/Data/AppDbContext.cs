using Integracijski_Modul.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Integracijski_Modul.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
