using System;
using Biblioteca.Dto;
using Biblioteca.Web.Models;

namespace Biblioteca.Web.Mapper.ModelToDto
{
    /// <summary>
    /// Class for libroModelMap.
    /// </summary>
    public static class libroModelMap
    {
        /// <summary>
        /// Allows mapping from libroModel to libroDto
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static libroDto map(libroModel model) =>
            new libroDto
            {
                isbn = model.isbn,
                editorialId = model.editorialId,
                titulo = model.titulo,
                sinopsis = model.sinopsis,
                nPaginas = model.nPaginas,
                autoresId = model.autoresId
            };
    }
}
