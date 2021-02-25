using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Biblioteca.Web.Controllers
{
    /// <summary>
    /// Class for baseController. (Controller)
    /// </summary>
    public class BaseController : Controller
    {

        /// <summary>
        /// Logging
        /// </summary>
        protected readonly ILogger logger;
        
        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="logger"></param>
        public BaseController(ILogger logger) => this.logger = logger;

        /// <summary>
        /// handles exceptions
        /// </summary>
        /// <param name="ex"></param>
        public void HandleExecption(Exception ex) 
        {
            this.logger.LogError($"{ex.Message} ---> Inner Execption {ex.InnerException?.Message}");
        }
    }
}
