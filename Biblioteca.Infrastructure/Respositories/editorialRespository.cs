using System;
using System.Linq;
using Biblioteca.Domain.Models;

namespace Biblioteca.Infrastructure.Respositories
{
    /// <summary>
    /// Class for editorial repository.
    /// </summary>
    public class editorialRepository : genericRepository<editorial>
    {
        public editorialRepository(libraryContext context) : base(context)
        {
        }
    }
}
