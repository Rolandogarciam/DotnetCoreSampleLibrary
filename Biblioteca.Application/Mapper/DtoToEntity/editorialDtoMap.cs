using System;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;

namespace Biblioteca.Application.Mapper.DtoToEntity
{
    /// <summary>
    /// Class for mapper editorialDto to editorial.
    /// </summary>
    public static class editorialDtoMap
    {
        /// <summary>
        /// Allows mapping editorialDto to editorial.
        /// </summary>
        public static editorial map(editorialDto dto) => 
            new editorial
            {
                id = dto.id,
                nombre = dto.nombre,
                sede = dto.sede
            };
    }
}
