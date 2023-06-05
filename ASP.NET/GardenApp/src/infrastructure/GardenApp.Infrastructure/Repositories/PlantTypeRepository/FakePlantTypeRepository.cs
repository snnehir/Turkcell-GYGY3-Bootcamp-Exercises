using GardenApp.Entities;
using System.Linq.Expressions;

namespace GardenApp.Infrastructure.Repositories.PlantTypeRepository
{
    public class FakePlantTypeRepository: IPlantTypeRepository
    {
        private List<PlantType> plantTypes;

        public FakePlantTypeRepository()
        {
            plantTypes = new()
            {
                new()
                {
                    Id = 1, Name= "Rose", Description="X"
                },
                new()
                {
                    Id = 2, Name= "Lavender", Description="X"
                },
                new()
                {
                    Id = 3, Name= "Tulip", Description="X"
                },
                new()
                {
                    Id = 4, Name= "Daisy", Description="X"
                },
                new()
                {
                    Id = 5, Name= "Orchid", Description="X"
                },

            };
        }

        public Task CreateAsync(PlantType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public PlantType? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PlantType?> GetAll()
        {
            return plantTypes;
        }

        public Task<IList<PlantType?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<PlantType> GetAllWithPredicate(Expression<Func<PlantType, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<PlantType?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PlantType entity)
        {
            throw new NotImplementedException();
        }
    }
}
