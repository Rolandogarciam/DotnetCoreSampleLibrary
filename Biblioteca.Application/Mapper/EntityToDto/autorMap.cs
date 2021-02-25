using System;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;

namespace Biblioteca.Application.Mapper.EntityToDto
{
    /// <summary>
    /// Class for autorMap (Adapter).
    /// </summary>
    public static class autorMap
    {
        /// <summary>
        /// Allows mapping from autor to autorDto.
        /// </summary>
        public static autorDto map(autor entity) =>
            new autorDto
            {
                id = (int)entity.id,
                nombre = entity.nombre,
                apellido = entity.apellido
            };
    }
}
