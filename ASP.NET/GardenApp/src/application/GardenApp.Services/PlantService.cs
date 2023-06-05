using GardenApp.DataTransferObjects.Responses;
using GardenApp.Infrastructure.Repositories.PlantRepository;
using Mapster;
using MapsterMapper;

namespace GardenApp.Services
{
    public class PlantService : IPlantService
    {
        private readonly IPlantRepository _repository;
        //private readonly IMapper _mapper;
        public PlantService(IPlantRepository plantRepository)
        {
            _repository = plantRepository;
        }

        public PlantDisplayResponse GetPlant(int id)
        {
            var plant = _repository.Get(id);
            var plantResponse = plant.Adapt<PlantDisplayResponse>();
            return plantResponse;
        }

        public IEnumerable<PlantDisplayResponse> GetPlantByPlantType(int plantTypeId)
        {
            var plants = _repository.GetPlantsByType(plantTypeId);
            var responses = plants.Adapt<IEnumerable<PlantDisplayResponse>>();
            return responses;
        }

        public IEnumerable<PlantDisplayResponse> GetPlantDisplayResponse()
        {
            var items = _repository.GetAll();
            var responses = items.Adapt<IEnumerable<PlantDisplayResponse>>();
            return responses;
        }
    }
}
