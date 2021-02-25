using System;
using System.Linq;
using Biblioteca.Dto;
using System.Diagnostics;
using Biblioteca.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Infrastructure;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Biblioteca.Web.Mapper.ModelToDto;
using Microsoft.AspNetCore.Mvc.Rendering;
using Biblioteca.Application.Services.Interfaces;

namespace Biblioteca.Web.Controllers
{
    /// <summary>
    /// Class for libroController. (Controller)
    /// </summary>
    public class LibroController : BaseController
    {
        private readonly IService<libroDto> service;
        private readonly IService<autorDto> autorService;
        private readonly IService<editorialDto> editorialService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="service"></param>
        public LibroController(
            ILogger<LibroController> logger,
            IService<libroDto> service,
            IService<autorDto> autorService,
            IService<editorialDto> editorialService) : base(logger)
        {
            this.service = service;
            this.autorService = autorService;
            this.editorialService = editorialService;
        }

        /// <summary>
        /// Get index view.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ICollection<libroDto> result = new List<libroDto>();
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
            var vm = new libroModel();
            vm.editoriales = this.editorialService.all().Select(x => new SelectListItem() { Text = x.nombre, Value = x.id.ToString() }).ToList();
            vm.autores = this.autorService.all().Select(x => new SelectListItem() { Text = x.nombre, Value = x.id.ToString() }).ToList();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] libroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dto = libroModelMap.map(model);
                    this.service.add(dto);
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
