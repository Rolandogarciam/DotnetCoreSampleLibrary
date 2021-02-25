using System;
using System.Linq;
using Biblioteca.Domain.Models;

namespace Biblioteca.Infrastructure.Respositories
{
    /// <summary>
    /// Class for autor repository
    /// </summary>
    public class autorRepository : genericRepository<autor>
    {
        public autorRepository(libraryContext context) : base(context)
        {
        }
    }
}
