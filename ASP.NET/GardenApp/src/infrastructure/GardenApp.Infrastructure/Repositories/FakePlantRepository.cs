using GardenApp.Entities;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories
{
    public class FakePlantRepository: IPlantRepository
    {
        private List<Plant> _plants;
        public FakePlantRepository()
        {
            _plants = new()
            {
                new() { Id=1, Name="Rose", Description="Description X", Price=50, Rating=4},
                new() { Id=2, Name="Lilac", Description="Description X", Price=55, Rating=5},
                new() { Id=3, Name="Tulip", Description="Description X", Price=60, Rating=4},
                new() { Id=4, Name="Violet", Description="Description X", Price=50, Rating=4},

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Plant entity)
        {
            throw new NotImplementedException();
        }
    }
}
