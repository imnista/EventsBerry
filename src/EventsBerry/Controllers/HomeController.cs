﻿using Microsoft.AspNetCore.Mvc;

namespace EventsBerry.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}