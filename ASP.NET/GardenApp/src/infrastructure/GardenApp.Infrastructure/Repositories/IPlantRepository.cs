using GardenApp.Entities;

namespace GardenApp.Infrastructure.Repositories
{
    public interface IPlantRepository: IRepository<Plant>
    {
        public IEnumerable<Plant> GetPlantsByType(int plantTypeId);
        public IEnumerable<Plant> GetPlantsByName(string name);
    }
}
