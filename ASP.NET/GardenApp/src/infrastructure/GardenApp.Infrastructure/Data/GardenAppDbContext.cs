using GardenApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace GardenApp.Infrastructure.Data
{
    public class GardenAppDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantType> PlantTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public GardenAppDbContext(DbContextOptions<GardenAppDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1-to-Many
            modelBuilder.Entity<Plant>().HasOne(p => p.PlantType)
                                        .WithMany(p => p.Plants)
                                        .HasForeignKey(p => p.PlantTypeId)
                                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>().HasIndex(u => u.Username)
                                       .IsUnique();
        }
    }
}
