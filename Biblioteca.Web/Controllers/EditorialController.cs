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
    /// Class for editorialController. (Controller)
    /// </summary>
    public class EditorialController : BaseController
    {

        private readonly IService<editorialDto> service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="service"></param>
        public EditorialController(
            ILogger<EditorialController> logger,
            IService<editorialDto> service) : base(logger)
        {
            this.service = service;
        }

        /// <summary>
        /// Get index view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ICollection<editorialDto> result = new List<editorialDto>();
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
        public IActionResult Create([Bind] editorialModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.service.add(editorialModelMap.map(model));
                }
                catch (Exception ex)
                {
                    HandleExecption(ex);
                }

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
