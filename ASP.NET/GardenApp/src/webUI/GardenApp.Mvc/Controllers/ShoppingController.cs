using GardenApp.DataTransferObjects.Responses;
using GardenApp.Mvc.Extensions;
using GardenApp.Mvc.Models;
using GardenApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GardenApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IPlantService plantService;
        private readonly IPlantTypeService plantTypeService;
        public ShoppingController(IPlantService plantService, IPlantTypeService plantTypeService)
        {
            this.plantService = plantService;
            this.plantTypeService = plantTypeService;
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

        public IActionResult IncreasePlantQuantity(int id)
        {
            // get collection
            PlantCollection plantCollection = getPlantCollectionFromSession();
            if(plantCollection != null)
            {
                var item = plantCollection.PlantItems.Any(p=>p.Plant.Id == id);
                if(item)
                {
                    plantCollection.PlantItems.FirstOrDefault(p => p.Plant.Id == id).Quantity += 1;
                    saveToSession(plantCollection);
                }
                return Json(new { message = $"Number of plant with id {id} is increased." });
            }
            return Json(new { message = $"Plant with id {id} is not found" });
        }

        public IActionResult DecreasePlantQuantity(int id)
        {
            // get collection
            PlantCollection plantCollection = getPlantCollectionFromSession();
            if (plantCollection != null)
            {
                var exists = plantCollection.PlantItems.Any(p => p.Plant.Id == id);
                if (exists)
                {
                    var item = plantCollection.PlantItems.FirstOrDefault(p => p.Plant.Id == id);
                    // remove item 
                    if (item.Quantity == 1)
                    {
                        plantCollection.PlantItems.Remove(item);
                        saveToSession(plantCollection);
                        return Json(new { message = $"Rlant with id {id} is removed." });
                    }
                    else
                    {
                        plantCollection.PlantItems.FirstOrDefault(p => p.Plant.Id == id).Quantity -= 1;
                        saveToSession(plantCollection);
                        return Json(new { message = $"Number of plant with id {id} is decreased." });
                    }
                    
                }
                
            }
            return Json(new { message = $"Plant with id {id} is not found" });
        }

        private PlantCollection getPlantCollectionFromSession()
        {
            return HttpContext.Session.GetJson<PlantCollection>("basket") ?? new PlantCollection();
        }


        private void saveToSession(PlantCollection courseCollection)
        {

            HttpContext.Session.SetJson("basket", courseCollection);

        }
        
       
    }
}
