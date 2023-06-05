using GardenApp.DataTransferObjects.Responses;
using GardenApp.Mvc.Models;
using GardenApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GardenApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IPlantService plantService;
        public ShoppingController(IPlantService plantService)
        {
            this.plantService = plantService;
        }
        public IActionResult Index()
        {
            var collection = getPlantCollectionFromSession();
            return View(collection);
        }

        public IActionResult AddPlant(int id)
        {
            PlantDisplayResponse selectedPlant = plantService.GetPlant(id);
            var plantItem = new PlantItem()
            {
                Plant = selectedPlant,
                Quantity = 1
            };

            PlantCollection plantCollection = getPlantCollectionFromSession();
            plantCollection.AddNewPlant(plantItem);
            saveToSession(plantCollection);

            return Json(new { message = $"Plant with id {id} is added to your cart." });
        }

        private void saveToSession(PlantCollection plantCollection)
        {
            var serialized = JsonSerializer.Serialize<PlantCollection>(plantCollection);
            if (!string.IsNullOrWhiteSpace(serialized))
            {
                HttpContext.Session.SetString("Basket", serialized);
            }

        }

        private PlantCollection getPlantCollectionFromSession()
        {
            var serializedString = HttpContext.Session.GetString("Basket");
            if (serializedString == null)
            {
                return new PlantCollection();
            }
            var collection = JsonSerializer.Deserialize<PlantCollection>(serializedString);
            return collection;
        }
    }
}
