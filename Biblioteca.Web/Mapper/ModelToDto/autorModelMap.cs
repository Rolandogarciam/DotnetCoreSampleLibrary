using System;
using Biblioteca.Dto;
using Biblioteca.Web.Models;

namespace Biblioteca.Web.Mapper.ModelToDto
{
    /// <summary>
    /// Class for autorModelMap.
    /// </summary>
    public static class autorModelMap
    {
        /// <summary>
        /// Allows mapping from autorModel to autorDto
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static autorDto map(autorModel model) =>
            new autorDto
            {
                nombre = model.nombre,
                apellido = model.apellido
            };
    }
}
