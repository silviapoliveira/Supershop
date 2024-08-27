﻿using Microsoft.AspNetCore.Mvc;
using Supershop.Models;
using System.Diagnostics;

namespace Supershop.Controllers
{
    public class ErrorsController : Controller
    {

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
