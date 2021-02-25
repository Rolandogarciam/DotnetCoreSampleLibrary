using System;
using System.Linq;
using Biblioteca.Dto;
using Biblioteca.Domain.Models;
using Biblioteca.Infrastructure;
using System.Collections.Generic;
using Biblioteca.Application.Mapper.DtoToEntity;
using Biblioteca.Application.Mapper.EntityToDto;
using Biblioteca.Application.Services.Interfaces;

namespace Biblioteca.Application.Services
{
    /// <summary>
    /// Class for libro service. (Service)
    /// </summary>
    public class libroService : genericService, IService<libroDto>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uow"></param>
        public libroService(IUnitOfWork uow) : base(uow)
        {
        }

        /// <summary>
        /// <see cref="IService{TDto}.add(TDto)"/>
        /// </summary>
        public libroDto add(libroDto dto)
        {
            var result = this.unitOfWork.libroRepository.add(libroDtoMap.Map(dto));
            result.autores = new List<autor>();
            foreach (var id in dto.autoresId)
            {
                result.autores.Add(this.unitOfWork.autorRepository.get(id));
            }
            this.unitOfWork.saveChanges();
            return libroMap.map(result);
        }

        /// <summary>
        /// <see cref="IService{TDto}.all"/>
        /// </summary>
        public ICollection<libroDto> all() => this.unitOfWork.libroRepository.all().Select(x => libroMap.map(x)).ToList();

        /// <summary>
        /// <see cref="IService{TDto}.get(decimal)"/>
        /// </summary>
        public libroDto get(decimal id) => libroMap.map(this.unitOfWork.libroRepository.get(id));
        
    }
}
