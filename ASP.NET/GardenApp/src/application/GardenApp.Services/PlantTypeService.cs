using GardenApp.DataTransferObjects.Responses;
using GardenApp.Infrastructure.Repositories.PlantRepository;
using GardenApp.Infrastructure.Repositories.PlantTypeRepository;
using Mapster;
using MapsterMapper;

namespace GardenApp.Services
{
    public class PlantTypeService: IPlantTypeService
    {
        private readonly IPlantTypeRepository _repository;
        public PlantTypeService(IPlantTypeRepository plantTypeRepository) {
            _repository = plantTypeRepository;
        }
        public IEnumerable<PlantTypeDisplayResponse> GetPlantTypesForList()
        {
            var items = _repository.GetAll();
            var responses = items.Adapt<IEnumerable<PlantTypeDisplayResponse>>();
            return responses;
        }

    }
}
