using GardenApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GardenApp.Mvc.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        private readonly IPlantTypeService plantTypeService;
        public MenuViewComponent(IPlantTypeService plantTypeService)
        {
            this.plantTypeService = plantTypeService;
        }
        public IViewComponentResult Invoke()
        {
            var plantTypes = plantTypeService.GetPlantTypesForList();
            return View(plantTypes);
        }
    }
}
