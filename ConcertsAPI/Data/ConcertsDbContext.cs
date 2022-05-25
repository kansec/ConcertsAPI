using ConcertsAPI.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConcertsAPI.Data
{
    public class ConcertsDbContext : IdentityDbContext<ApiUser>
    {
        public ConcertsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Concert> Concerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArtistsConfiguration());
            modelBuilder.ApplyConfiguration(new PlacesConfiguration());
            modelBuilder.ApplyConfiguration(new ConcertsConfiguration());
        }

    }


}
