using System;
using System.Linq;
using Biblioteca.Dto;
using Biblioteca.Infrastructure;
using System.Collections.Generic;
using Biblioteca.Application.Mapper.DtoToEntity;
using Biblioteca.Application.Mapper.EntityToDto;
using Biblioteca.Application.Services.Interfaces;

namespace Biblioteca.Application.Services
{
    /// <summary>
    /// Class for editorial service. (Service)
    /// </summary>
    public class editorialService : genericService, IService<editorialDto>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        public editorialService(IUnitOfWork uow) : base(uow)
        { 
        }

        /// <summary>
        /// <see cref="IService{TDto}.add(TDto)"/>
        /// </summary>
        public editorialDto add(editorialDto dto)
        {
            var result = this.unitOfWork.editorialRepository.add(editorialDtoMap.map(dto));
            this.unitOfWork.saveChanges();
            return editorialMap.map(result);
        }

        /// <summary>
        /// <see cref="IService{TDto}.all"/>
        /// </summary>
        public ICollection<editorialDto> all() => this.unitOfWork.editorialRepository.all().Select(x => editorialMap.map(x)).ToList();

        /// <summary>
        /// <see cref="IService{TDto}.get(decimal)"/>
        /// </summary>
        public editorialDto get(decimal id) => editorialMap.map(this.unitOfWork.editorialRepository.get(id));
    }
}
