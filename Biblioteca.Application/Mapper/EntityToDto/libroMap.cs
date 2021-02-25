using System;
using System.Linq;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;

namespace Biblioteca.Application.Mapper.EntityToDto
{
    /// <summary>
    /// Class for libroMap (Adapter).
    /// </summary>
    public static class libroMap
    {
        /// <summary>
        /// Allows mapping from libro to libroDto.
        /// </summary>
        public static libroDto map(libro entity) =>
            new libroDto
            {
                isbn = (int)entity.isbn,
                editorialId = entity.editorialId,
                editorialNombre = entity.editorial?.nombre,
                titulo = entity.titulo,
                sinopsis = entity.sinopsis,
                nPaginas = entity.nPaginas,
                autoresNombre = string.Join(", ", entity.autores.Select(x => x.nombre))
            };
    }
}
