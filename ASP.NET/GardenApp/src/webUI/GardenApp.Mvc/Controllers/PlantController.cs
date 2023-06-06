using GardenApp.Mvc.Models;
using GardenApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace GardenApp.Mvc.Controllers
{
    public class PlantController : Controller
    {
        private readonly IPlantService plantService;
        private readonly IPlantTypeService plantTypeService;
        public PlantController(IPlantService plantService, IPlantTypeService plantTypeService)
        {
            this.plantService = plantService;
            this.plantTypeService = plantTypeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin,Editor")]
        public async Task<IActionResult> Create()
        {

            var plantTypes = getPlantTypesForSelectList();
            var model = new CreateNewPlantViewModel()
            {
                PlantTypes = plantTypes,
            };
            return View(model);
        }
        [Authorize(Roles = "Admin,Editor")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewPlantViewModel request)
        {
            if (ModelState.IsValid)
            {
                await plantService.CreatePlantAsync(request.NewPlant);
                return RedirectToAction(nameof(Index));
            }
            var plantTypes = getPlantTypesForSelectList();
            var model = new CreateNewPlantViewModel()
            {
                PlantTypes = plantTypes,
            };
            return View(model);
        }

        private IEnumerable<SelectListItem> getPlantTypesForSelectList()
        {

            var plantTypes = plantTypeService.GetPlantTypesForList();
            var selectItems = plantTypes.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return selectItems;
        }
    }
}
