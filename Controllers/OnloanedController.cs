﻿using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class OnloanedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
