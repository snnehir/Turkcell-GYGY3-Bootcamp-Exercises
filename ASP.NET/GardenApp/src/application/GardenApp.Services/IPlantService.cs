using GardenApp.DataTransferObjects.Responses;

namespace GardenApp.Services
{
    public interface IPlantService
    {
        IEnumerable<PlantDisplayResponse> GetPlantDisplayResponse(); 
    }
}
