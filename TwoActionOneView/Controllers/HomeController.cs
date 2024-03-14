using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TwoActionOneView.Models;

namespace TwoActionOneView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Bir action view adı vererek istediği view'i çalıştırabilir.
            return View("Wissen");
        }
        public IActionResult Index2()
        {
            // İki action aynı view'i dönebilir.

            return View("Wissen");
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