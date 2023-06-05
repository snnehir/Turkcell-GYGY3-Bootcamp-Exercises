using GardenApp.Entities;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories.PlantRepository
{
    public class FakePlantRepository : IPlantRepository
    {
        private List<Plant> _plants;
        public FakePlantRepository()
        {
            _plants = new()
            {
                new() { Id=1, Name="Rambling Rose", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/75869.webp"},
                new() { Id=2, Name="Chinese Ground Orchid", Description="Description X", Price=55, Rating=5,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/EAs5D6cA9fTCYNKXJAaxYNDSALtiB1tudMk5DalZ.webp"},
                new() { Id=3, Name="Triumph Tulip", Description="Description X", Price=60, Rating=5,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/xocpBzmkPiZL2BHmU0TnsRXOQddm4QGVha4CmLXR.webp"},
                new() { Id=4, Name="Lavender", Description="Description X", Price=50, Rating=3, PlantTypeId = 2,
                    ImageUrl= "https://www.gardenia.net/storage/app/public/uploads/images/cropped/mgpZjtsr1qrqOvYx7pk8ngT1BynIJq573q3zy7T0.webp"},
                new() { Id=5, Name="Climbing Rose", Description="Description X", Price=50, Rating=5, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/Aloha.webp"},
                new() { Id=6, Name="Single Late Tulips", Description="Description X", Price=60, Rating=4, PlantTypeId = 3,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/33369.webp"},
                new() { Id=7, Name="Hybrid Musk Rose", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/71444Optimized.webp"},
                new() { Id=8, Name="Hardy Orchid", Description="Description X", Price=55, Rating=5, PlantTypeId = 5,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/MGUX1J7fmudUAI48tWRXUhfgafpEo3B1xlZT24NF.webp"},
                new() { Id=9, Name="Arabian Mystery Tulip", Description="Description X", Price=60, Rating=5, PlantTypeId = 3,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/13545838_m.webp"},
                new() { Id=10, Name="Shatsa Daisy", Description="Description X", Price=50, Rating=4, PlantTypeId = 4,
                    ImageUrl= "https://www.gardenia.net/storage/app/public/uploads/images/cropped/ifQzXAPhAheb7Pr8OcHlTBdgian0AEJYmFXEj99w.webp"},
                new() { Id=11, Name="Hybrid Tea Rose", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/shutterstock_129044549Optimized.webp"},
                new() { Id=12, Name="Rambling Rose 2", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/75869.webp"},
                new() { Id=13, Name="Triumph Tulip 2", Description="Description X", Price=60, Rating=5,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/xocpBzmkPiZL2BHmU0TnsRXOQddm4QGVha4CmLXR.webp"},
                new() { Id=14, Name="Lavender 2", Description="Description X", Price=50, Rating=3, PlantTypeId = 2,
                    ImageUrl= "https://www.gardenia.net/storage/app/public/uploads/images/cropped/mgpZjtsr1qrqOvYx7pk8ngT1BynIJq573q3zy7T0.webp"},
                new() { Id=15, Name="Climbing Rose 2", Description="Description X", Price=50, Rating=5, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/Aloha.webp"},
                new() { Id=16, Name="Single Late Tulips 2", Description="Description X", Price=60, Rating=4, PlantTypeId = 3,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/33369.webp"},
                new() { Id=17, Name="Hybrid Musk Rose 2", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/71444Optimized.webp"},
                new() { Id=18, Name="Hybrid Tea Rose", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/shutterstock_129044549Optimized.webp"},
                new() { Id=19, Name="Polyantha Rose", Description="Description X", Price=50, Rating=4, PlantTypeId = 1,
                    ImageUrl = "https://www.gardenia.net/storage/app/public/uploads/images/cropped/Gruss%20an%20AachenOptimized.webp"},

            };

        }

        public Task CreateAsync(Plant entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Plant? Get(int id)
        {
            return _plants.FirstOrDefault(p => p.Id == id);
        }

        public IList<Plant?> GetAll()
        {
            return _plants;
        }

        public Task<IList<Plant?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Plant> GetAllWithPredicate(Expression<Func<Plant, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Plant?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plant> GetPlantsByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plant> GetPlantsByType(int plantTypeId)
        {
            return _plants.Where(p=>p.PlantTypeId == plantTypeId).AsEnumerable();
        }

        public Task UpdateAsync(Plant entity)
        {
            throw new NotImplementedException();
        }
    }
}
