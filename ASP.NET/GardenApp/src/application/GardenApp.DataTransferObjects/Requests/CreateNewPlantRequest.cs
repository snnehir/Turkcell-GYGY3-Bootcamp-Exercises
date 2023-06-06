using System.ComponentModel.DataAnnotations;

namespace GardenApp.DataTransferObjects.Requests
{
    public class CreateNewPlantRequest
    {
        [Required(ErrorMessage = "Plant name cannot be empty")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; } = "https://loremflickr.com/320/240";
        public int? PlantTypeId { get; set; }
        public byte? Rating { get; set; }
    }
}
