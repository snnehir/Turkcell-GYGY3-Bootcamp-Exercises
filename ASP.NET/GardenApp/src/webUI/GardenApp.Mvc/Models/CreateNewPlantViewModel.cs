using GardenApp.DataTransferObjects.Requests;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GardenApp.Mvc.Models
{
    public class CreateNewPlantViewModel
    {
        public CreateNewPlantRequest NewPlant { get; set; }
        public IEnumerable<SelectListItem>? PlantTypes { get; set; }
    }
}
