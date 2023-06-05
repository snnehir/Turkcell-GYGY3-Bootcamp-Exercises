using GardenApp.DataTransferObjects.Responses;

namespace GardenApp.Mvc.Models
{
    public class PaginationPlantViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public IEnumerable<PlantDisplayResponse> Plants { get; set; }
    }
}
