using Gardens.Application.DTOs.Requests;
using Gardens.Application.DTOs.Responses;
using Gardens.Data.Repositories;
using Gardens.Entitiy;

namespace Gardens.Application
{
    public class GardenServices : IGardenService
    {
        private readonly IGardenRepository gardenRepository;
        public GardenServices(IGardenRepository gardenRepository)
        {
            this.gardenRepository = gardenRepository;
        }

        public async Task<int> CreateNewGarden(CreateNewGardenRequest garden)
        {
            // Mapping from DTO to Entity (AutoMapper, Mapster...)
            var gardenEntity = new Garden()
            {
                Name = garden.Name,
                Detail = garden.Detail,
                GardenType = garden.GardenType
            };
            // We can get created garden's id from this object directly since it is tracked by EF.
            await gardenRepository.CreateAsync(gardenEntity);
            return gardenEntity.Id;
        }

        public async Task<IEnumerable<GardenListResponse>> GetAllGardens()
        {
            var gardens = await gardenRepository.GetAllAsync();
            var gardenDtos = gardens.Select(g => new GardenListResponse { Detail = g.Detail, GardenType = g.GardenType, Name = g.Name });
            
            return gardenDtos;
        }
    }
}
