using System;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;

namespace Biblioteca.Application.Mapper.DtoToEntity
{
    /// <summary>
    /// Class for mapper autorDto to autor.
    /// </summary>
    public static class autorDtoMap
    {
        /// <summary>
        /// Allows mapping from autorDtor to autor.
        /// </summary>
        public static autor map(autorDto dto) => 
            new autor
            {
                id = dto.id,
                nombre = dto.nombre,
                apellido = dto.apellido
            };
    }
}
