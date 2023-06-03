using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    // Home+"Controller" -> convention over configuration
    public class HomeController : Controller
    {
        // Result can be anything implementing IActionResult interface (json, view, file...) (loosely-coupled)
        public IActionResult Index()
        {
            // Dynamic object that can be used in View
            ViewBag.Name = "S. Nur";
            ViewBag.Month = DateTime.Now.Month;
            // Views -> Home (controller name) -> Index.cshtml (action)
            return View();
        }

        public IActionResult Privacy()
        {
            Privacy privacy = new Privacy()
            {
                Header = "Privacy",
                Info = "Welcome to privacy page!"
            };
            return View(privacy);
        }
        
        public IActionResult Register()
        {
            return View();
        }

        // Form post request will come here
        [HttpPost]
        public IActionResult Register(UserRegisterModel userRegisterModel)
        {
            return View();
        }
    }
}
