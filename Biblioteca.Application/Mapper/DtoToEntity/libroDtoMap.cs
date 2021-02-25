using System;
using System.Linq;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;
using Biblioteca.Application.Mapper.EntityToDto;

namespace Biblioteca.Application.Mapper.DtoToEntity
{
    /// <summary>
    /// Class for mapper libroDto to libro.
    /// </summary>
    public static class libroDtoMap
    {
        /// <summary>
        /// Allows mapping from libroDto to libro.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static libro Map(libroDto dto) => 
            new libro
            {
                isbn = dto.isbn,
                editorialId = dto.editorialId,
                titulo = dto.titulo,
                sinopsis = dto.sinopsis,
                nPaginas = dto.nPaginas
            };
    }
}
