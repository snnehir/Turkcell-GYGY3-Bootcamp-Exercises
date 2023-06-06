using GardenApp.Mvc.Extensions;
using GardenApp.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace GardenApp.Mvc.ViewComponents
{
    public class BasketLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var plantCollection = HttpContext.Session.GetJson<PlantCollection>("basket");
            return View(plantCollection);
        }
    }
}
