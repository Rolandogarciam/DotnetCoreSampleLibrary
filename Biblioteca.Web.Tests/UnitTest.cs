using NUnit.Framework;
using Biblioteca.Domain.Models;
using Biblioteca.Infrastructure;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Biblioteca.Web.Tests
{
    public class Tests
    {

        public readonly string ConnectionString = "Data Source=.;Initial Catalog=biblioteca;User ID=sa;Password=;Trusted_Connection=True;";

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAuditor()
        {
            var options = new DbContextOptionsBuilder<libraryContext>()
               .UseSqlServer(this.ConnectionString)
               .Options;
            var libraryContext = new libraryContext(options);
            var uow = new unitOfWork(libraryContext);

            var autor = new autor {
                nombre = "Rolando",
                apellido = "Garcia"
            };

            uow.autorRepository.add(autor);
            uow.saveChanges();
        }

        [Test]
        public void TestEditorial()
        {
            var options = new DbContextOptionsBuilder<libraryContext>()
               .UseSqlServer(this.ConnectionString)
               .Options;
            var libraryContext = new libraryContext(options);
            var uow = new unitOfWork(libraryContext);
            
            var editorial = new editorial
            {
                nombre = "OREALLY",
                sede = "Bogota"
            };

            uow.editorialRepository.add(editorial);
            uow.saveChanges();
        }

        [Test]
        public void TestLibro()
        {
            var options = new DbContextOptionsBuilder<libraryContext>()
               .UseSqlServer(this.ConnectionString)
               .Options;
            var libraryContext = new libraryContext(options);
            var uow = new unitOfWork(libraryContext);

            var libro = new libro
            {
                isbn = 101,
                editorialId = 1,
                titulo = "Ajo",
                sinopsis = "Test Test",
                nPaginas = "23"
            };

            uow.libroRepository.add(libro);
            uow.saveChanges();
        }

        [Test]
        public void TestLibroConAutores()
        {
            var options = new DbContextOptionsBuilder<libraryContext>()
               .UseSqlServer(this.ConnectionString)
               .Options;
            var libraryContext = new libraryContext(options);
            var uow = new unitOfWork(libraryContext);

            var autores = new List<autor>();

            autores.Add(new autor
            {
                nombre = "Rolando",
                apellido = "Garcia"
            });

            autores.Add(new autor
            {
                nombre = "Carlos",
                apellido = "Martinez"
            });

            var libro = new libro
            {
                isbn = 1011,
                editorialId = 1,
                titulo = "Ajo",
                sinopsis = "Test Test",
                nPaginas = "23",
                autores = autores
            };

            uow.libroRepository.add(libro);
            uow.saveChanges();
        }
    }
}