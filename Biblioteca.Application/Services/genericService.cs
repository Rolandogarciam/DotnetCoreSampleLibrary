using System;
using Biblioteca.Infrastructure;

namespace Biblioteca.Application.Services
{
    public class genericService
    {
        #region UnitOfWork
        protected readonly IUnitOfWork unitOfWork;
        #endregion

        public genericService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
