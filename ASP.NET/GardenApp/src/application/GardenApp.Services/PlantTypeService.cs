using GardenApp.DataTransferObjects.Responses;
using GardenApp.Infrastructure.Repositories;
using Mapster;
using MapsterMapper;

namespace GardenApp.Services
{
    public class PlantTypeService: IPlantTypeService
    {
        private readonly IPlantRepository _repository;
        private readonly IMapper _mapper;
        public PlantTypeService(IPlantRepository plantTypeRepository, IMapper mapper) {
            _mapper = mapper;
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
