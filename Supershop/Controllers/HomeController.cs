﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Supershop.Models;
using System.Diagnostics;

namespace Supershop.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
