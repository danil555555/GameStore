﻿using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
