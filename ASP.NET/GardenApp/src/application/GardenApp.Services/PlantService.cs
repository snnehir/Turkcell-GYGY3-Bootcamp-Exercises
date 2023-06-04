using GardenApp.DataTransferObjects.Responses;
using GardenApp.Infrastructure.Repositories;
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
        public IEnumerable<PlantDisplayResponse> GetPlantDisplayResponse()
        {
            var items = _repository.GetAll();
            var responses = items.Adapt<IEnumerable<PlantDisplayResponse>>();
            return responses;
        }
    }
}
