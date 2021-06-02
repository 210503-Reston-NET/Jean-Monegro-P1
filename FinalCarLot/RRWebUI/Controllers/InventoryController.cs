﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RRWebUI.Models;
using System.Diagnostics;

namespace RRWebUI.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public InventoryController(ILogger<HomeController> logger)
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}