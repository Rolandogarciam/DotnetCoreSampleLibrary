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
    /// Class for autor service. (Service)
    /// </summary>
    public class autorService : genericService, IService<autorDto>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        public autorService(IUnitOfWork uow) : base(uow)
        {
        }

        /// <summary>
        /// <see cref="IService{TDto}.add(TDto)"/>
        /// </summary>
        public autorDto add(autorDto dto) 
        {
            var result = this.unitOfWork.autorRepository.add(autorDtoMap.map(dto));
            this.unitOfWork.saveChanges();
            return autorMap.map(result);
        }

        /// <summary>
        /// <see cref="IService{TDto}.all"/>
        /// </summary>
        public ICollection<autorDto> all() => this.unitOfWork.autorRepository.all().Select(x => autorMap.map(x)).ToList();

        /// <summary>
        /// <see cref="IService{TDto}.get(decimal)"/>
        /// </summary>
        public autorDto get(decimal id) => autorMap.map(this.unitOfWork.autorRepository.get(id));
    }
}
