using System;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;

namespace Biblioteca.Application.Mapper.EntityToDto
{
    /// <summary>
    /// Class for editorialMap (Adapter).
    /// </summary>
    public static class editorialMap
    {
        /// <summary>
        /// Allows mapping from editorial to editorialDto.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static editorialDto map(editorial entity) =>
            new editorialDto
            {
                id = (int)entity.id,
                nombre = entity.nombre,
                sede = entity.sede
            };
    }
}
