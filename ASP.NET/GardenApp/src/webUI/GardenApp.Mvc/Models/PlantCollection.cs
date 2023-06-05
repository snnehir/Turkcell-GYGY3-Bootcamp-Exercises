using GardenApp.DataTransferObjects.Responses;

namespace GardenApp.Mvc.Models
{
    public class PlantCollection
    {
        public List<PlantItem> PlantItems { get; set; } = new List<PlantItem>();
        public void ClearAll() => PlantItems.Clear();
        public decimal TotalPrice() => PlantItems.Sum(p => (decimal)p.Plant.Price * p.Quantity);
    
        public int TotalPlantsCount() => PlantItems.Sum(p=>p.Quantity);

        public void AddNewPlant(PlantItem plantItem)
        {
            var exists = PlantItems.Any(p => p.Plant.Id == plantItem.Plant.Id);
            if(exists)
            {
                var existingPlant = PlantItems.FirstOrDefault(p=>p.Plant.Id == plantItem.Plant.Id);
                existingPlant.Quantity += plantItem.Quantity;
            }
            else
            {
                PlantItems.Add(plantItem);
            }
        }
    }
    public class PlantItem
    {
        public PlantDisplayResponse Plant { get; set; }
        public int Quantity { get; set; }
        public bool? Coupon { get; set; }
    }
}
