using GardenApp.Entities;

namespace GardenApp.Infrastructure.Data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(GardenAppDbContext context)
        {
            seedPlantTypeIfNotExists(context);
            seedPlantIfNotExists(context);
            seedUserIfNotExists(context);
        }

        private static void seedPlantIfNotExists(GardenAppDbContext context)
        {
            if (!context.Plants.Any())
            {
                var plants = new List<Plant>()
                {
                    new Plant() {Name = "Climbing Rose", Description = "X", PlantTypeId = 1, Rating = 5,
                                 Price = 50, ImageUrl = "https://loremflickr.com/320/240"},
                    new Plant() {Name = "Shatsa Daisy", Description = "Y", PlantTypeId = 3, Rating = 4,
                                 Price = 50, ImageUrl = "https://loremflickr.com/320/240"},
                    new Plant() {Name = "Arabian Tulips", Description = "Z", PlantTypeId = 2, Rating = 5,
                                 Price = 50, ImageUrl = "https://loremflickr.com/320/240"},
                    new Plant() {Name = "Triumph Tulip", Description = "T", PlantTypeId = 2, Rating = 3,
                                 Price = 50, ImageUrl = "https://loremflickr.com/320/240"},
                    new Plant() {Name = "Polyantha Rose", Description = "K", PlantTypeId = 1, Rating = 4,
                                 Price = 50, ImageUrl = "https://loremflickr.com/320/240"},
                };
                context.Plants.AddRange(plants);
                context.SaveChanges();
            }
        }

        private static void seedPlantTypeIfNotExists(GardenAppDbContext context)
        {
            if (!context.PlantTypes.Any())
            {
                var plantTypes = new List<PlantType>()
                {
                    new PlantType() {Name = "Rose", Description = "X"},
                    new PlantType() {Name = "Tulip", Description = "Y"},
                    new PlantType() {Name = "Daisy", Description = "Z"},
                };
                context.PlantTypes.AddRange(plantTypes);
                context.SaveChanges();
            }
        }

        private static void seedUserIfNotExists(GardenAppDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>()
                {
                    new User() {FullName = "John Doe", Username = "john21", Password = "123456", IsActive = true, Role = "Client", Email = "john@mail.com"},
                    new User() {FullName = "Bill Wurtz", Username = "bill_wurtz", Password = "abcd", IsActive = true, Role = "Admin", Email = "bill@mail.com"},
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
    }
}
