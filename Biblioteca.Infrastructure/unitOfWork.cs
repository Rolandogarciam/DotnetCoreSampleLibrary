using System;
using Biblioteca.Domain.Models;
using Biblioteca.Infrastructure.Respositories;
using Biblioteca.Infrastructure.Respositories.Interfaces;


namespace Biblioteca.Infrastructure
{
    /// <summary>
    /// Unit Of Work Pattern.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Autor Repository (Repository).
        /// </summary>
        IRepository<autor> autorRepository { get; }

        /// <summary>
        /// Libro Repository (Repository).
        /// </summary>
        IRepository<libro> libroRepository { get; }

        /// <summary>
        /// Editorial Repository (Repository).
        /// </summary>
        IRepository<editorial> editorialRepository { get; }

        void saveChanges();
    }


    /// <summary>
    /// <see cref="IUnitOfWork"/>
    /// </summary>
    public class unitOfWork : IUnitOfWork
    {
        private libraryContext context;

        public unitOfWork(libraryContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// <see cref="IUnitOfWork.autorRepository"/>
        /// </summary>
        private IRepository<autor> _autoresRepository;
        public IRepository<autor> autorRepository
        {
            get
            {
                if (_autoresRepository == null)
                {
                    _autoresRepository = new autorRepository(context);
                }

                return _autoresRepository;
            }
        }

        /// <summary>
        /// <see cref="IUnitOfWork.libroRepository"/>
        /// </summary>
        private IRepository<libro> _libroRepository;
        public IRepository<libro> libroRepository
        {
            get
            {
                if (_libroRepository == null)
                {
                    _libroRepository = new libroRepository(context);
                }

                return _libroRepository;
            }
        }

        /// <summary>
        /// <see cref="IUnitOfWork.editorialRepository"/>
        /// </summary>
        private IRepository<editorial> _editorialRepository;
        public IRepository<editorial> editorialRepository
        {
            get
            {
                if (_editorialRepository == null)
                {
                    _editorialRepository = new editorialRepository(context);
                }

                return _editorialRepository;
            }
        }

        public void saveChanges()
        {
            context.SaveChanges();
        }
    }
}
