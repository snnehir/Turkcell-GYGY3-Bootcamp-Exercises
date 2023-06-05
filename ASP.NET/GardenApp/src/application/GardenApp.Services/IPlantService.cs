using GardenApp.DataTransferObjects.Responses;

namespace GardenApp.Services
{
    public interface IPlantService
    {
        IEnumerable<PlantDisplayResponse> GetPlantDisplayResponse();
        IEnumerable<PlantDisplayResponse> GetPlantByPlantType(int plantTypeId);
        PlantDisplayResponse GetPlant(int id);
    }
}
