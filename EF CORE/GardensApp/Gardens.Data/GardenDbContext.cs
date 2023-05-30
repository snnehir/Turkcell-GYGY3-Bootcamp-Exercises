using Gardens.Entitiy;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Gardens.Data
{
    public class GardenDbContext: DbContext
    {
        public DbSet<Garden> Gardens { get; set; } 
        public DbSet<Owner> Owners { get; set; }
        public DbSet<GardenNote> GardenNotes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garden>().Property(g => g.Name)
                                         .IsRequired()
                                         .HasMaxLength(20);
            // 1-to-Many relation between Garden and GardenNote
            modelBuilder.Entity<GardenNote>().HasOne(gn=>gn.Garden)
                                             .WithMany(g => g.GardenNotes)
                                             .HasForeignKey(gn => gn.GardenId)
                                             .OnDelete(DeleteBehavior.SetNull);

            // Many-to-Many relation between Garden and Owner
            modelBuilder.Entity<GardenOwner>().HasKey("GardenId", "OwnerId");

            modelBuilder.Entity<Garden>().HasMany(g => g.Owners)
                                         .WithOne(go => go.Garden)
                                         .HasForeignKey(go => go.GardenId)
                                         .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Owner>().HasMany(o => o.Gardens)
                                        .WithOne(go => go.Owner)
                                        .HasForeignKey(go => go.OwnerId)
                                        .OnDelete(DeleteBehavior.NoAction);

            // HasData -> test
            modelBuilder.Entity<Owner>().HasData(new Owner { Id = 1, FirstName = "John", LastName = "Doe" });
            modelBuilder.Entity<Garden>().HasData(new Garden { Id = 1, Name = "My Garden", GardenType ="Flower Garden"});
            modelBuilder.Entity<GardenNote>().HasData(new GardenNote { Id = 1, Note = "My beautiful flowers in May.", GardenId = 1 });
            modelBuilder.Entity<GardenOwner>().HasData(new GardenOwner { GardenId = 1, OwnerId = 1, Role = "Admin" });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Design paketi kullanmak şart değil çünkü connection direkt Data katmanında yapıldı.
            
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GardenApp;Integrated Security=True;", b => b.MigrationsAssembly("Gardens.Data"));
        }
    }
}