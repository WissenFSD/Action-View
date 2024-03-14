using Microsoft.AspNetCore.Mvc;

namespace RedirectToAction.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(bool islogin)
        {
            if (islogin)
            {
                return RedirectToAction("Index", "Admin");
            }
            
            // Örnek senaryo fail senaryosu yok. Tamamen farklı bir controller ve action'a yönlenmeye odaklandık.
            return View();

        }
    }
}
