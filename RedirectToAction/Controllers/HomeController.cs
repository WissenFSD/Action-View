using Microsoft.AspNetCore.Mvc;
using RedirectToAction.Models;
using System.Diagnostics;

namespace RedirectToAction.Controllers
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
             return View();
        }
        public IActionResult RedirectIndex()
        {
            //RedirectToAction ile bir actiondan başka bir action'a yönlendirme yapabiliriz.
            return RedirectToAction("Index");   
            

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