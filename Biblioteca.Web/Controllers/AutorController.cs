using System;
using Biblioteca.Dto;
using System.Diagnostics;
using Biblioteca.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Infrastructure;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Biblioteca.Web.Mapper.ModelToDto;
using Biblioteca.Application.Services.Interfaces;

namespace Biblioteca.Web.Controllers
{
    /// <summary>
    /// Class for autorController. (Controller)
    /// </summary>
    public class AutorController : BaseController
    {
        
        private readonly IService<autorDto> service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        public AutorController(
            ILogger<AutorController> logger,
            IService<autorDto> service) : base(logger)
        {
            this.service = service;
        }

        /// <summary>
        /// Get index view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ICollection<autorDto> result = new List<autorDto>();
            try
            {
                result = this.service.all();
            }
            catch (Exception ex)
            {
                HandleExecption(ex);
            }
            return View(result);
        }

        /// <summary>
        /// Get create view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] autorModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.service.add(autorModelMap.map(model));
                }
                catch (Exception ex)
                {
                    HandleExecption(ex);
                }

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
