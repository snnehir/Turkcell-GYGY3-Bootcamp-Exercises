using GardenApp.Mvc.Models;
using GardenApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GardenApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlantService _plantService;
        public HomeController(ILogger<HomeController> logger, IPlantService plantService)
        {
            _logger = logger;
            _plantService = plantService;
        }

        public IActionResult Index()
        {
            var plantTypes = _plantService.GetPlantDisplayResponse();

            return View(plantTypes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}