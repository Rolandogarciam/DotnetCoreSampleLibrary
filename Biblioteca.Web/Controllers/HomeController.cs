using System;
using Biblioteca.Dto;
using System.Diagnostics;
using Biblioteca.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Infrastructure;
using Microsoft.Extensions.Logging;
using Biblioteca.Application.Services.Interfaces;

namespace Biblioteca.Web.Controllers
{
    /// <summary>
    /// Class fot homeController. (Controller)
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(
            ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Vista principañ
        /// </summary>
        public IActionResult Index()
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
