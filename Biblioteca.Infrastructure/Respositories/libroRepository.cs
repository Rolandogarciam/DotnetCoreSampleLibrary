using System;
using System.Linq;
using Biblioteca.Domain.Models;

namespace Biblioteca.Infrastructure.Respositories
{
    /// <summary>
    /// Class for libro repository
    /// </summary>
    public class libroRepository : genericRepository<libro>
    {
        public libroRepository(libraryContext context) : base(context)
        {
        }
    }
}
