﻿using System.ComponentModel.DataAnnotations;

namespace GardenApp.Entities
{
    public class Plant : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string ImageUrl { get; set; } = "https://loremflickr.com/320/240";
        public int? PlantTypeId { get; set; }
        public byte? Rating { get; set; }
        public PlantType? PlantType { get; set; }
    }
}