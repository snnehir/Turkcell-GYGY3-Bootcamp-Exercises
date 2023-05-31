using Gardens.Application.DTOs.Requests;
using Gardens.Application.DTOs.Responses;

namespace Gardens.Application
{
    public interface IGardenService
    {
        Task<int> CreateNewGarden(CreateNewGardenRequest garden);
        Task<IEnumerable<GardenListResponse>> GetAllGardens();
    }
}
