using System;
using Biblioteca.Dto;
using Biblioteca.Web.Models;

namespace Biblioteca.Web.Mapper.ModelToDto
{
    /// <summary>
    /// Class for editorialModelMap.
    /// </summary>
    public static class editorialModelMap
    {
        /// <summary>
        /// Allows mapping from editorialModel to editorialDto
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static editorialDto map(editorialModel model) =>
            new editorialDto
            { 
                nombre = model.nombre,
                sede = model.sede
            };
    }
}
