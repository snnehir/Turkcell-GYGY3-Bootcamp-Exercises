using System.ComponentModel.DataAnnotations;

namespace GardenApp.Entities
{
    public class PlantType : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Plant> Plants { get; set; }
    }
}
