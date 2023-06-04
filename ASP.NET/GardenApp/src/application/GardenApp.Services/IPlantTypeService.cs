using GardenApp.DataTransferObjects.Responses;

namespace GardenApp.Services
{
    public interface IPlantTypeService
    {
        public IEnumerable<PlantTypeDisplayResponse> GetPlantTypesForList();
    }
}
