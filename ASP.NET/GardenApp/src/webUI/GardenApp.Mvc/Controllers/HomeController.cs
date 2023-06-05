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

        public IActionResult Index(int pageNo = 1)
        {
            var plants = _plantService.GetPlantDisplayResponse();

            var plantCount = plants.Count();    
            var plantPerPage = 8;
            var totalPages = Math.Ceiling((decimal)plantCount / plantPerPage);
            
            /*ViewBag.TotalPages = totalPages;
            ViewBag.PageNo = pageNo;*/

            var pagingInfo = new PagingInfo()
            {
                CurrentPage = pageNo,
                ItemsPerPage = plantPerPage,
                TotalItems = plantCount
            };

            var paginatedPlants = plants.OrderBy(p=>p.Id)
                                 .Skip((pageNo-1)*plantPerPage)
                                 .Take(plantPerPage)
                                 .ToList();
            var model = new PaginationPlantViewModel()
            {
                PagingInfo = pagingInfo,
                Plants = paginatedPlants
            };
            
            return View(model);
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