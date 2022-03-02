using AlgeriaConfirmedFlight.Model;
using Microsoft.EntityFrameworkCore;

namespace AlgeriaConfirmedFlight.API.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<VolComfirme> VolComfirme { get; set; }
        public DbSet<Compagnie> Compagnie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VolComfirme>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Compagnie>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
