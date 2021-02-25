using System.Collections.Generic;

namespace Biblioteca.Application.Services.Interfaces
{
    /// <summary>
    /// Interface to services.
    /// </summary>
    /// <typeparam name="TDto"></typeparam>
    public interface IService<TDto>
    {
        /// <summary>
        /// Allows to add a model.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TDto add(TDto dto);

        /// <summary>
        /// Allows to retrieve a model.
        /// </summary>
        /// <returns></returns>
        TDto get(decimal id);

        /// <summary>
        /// Allows to retrieve a list of models.
        /// </summary>
        /// <returns></returns>
        ICollection<TDto> all();
    }
}
