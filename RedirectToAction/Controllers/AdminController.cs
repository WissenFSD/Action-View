﻿using Microsoft.AspNetCore.Mvc;

namespace RedirectToAction.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
