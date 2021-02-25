using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Biblioteca.Infrastructure.Respositories.Interfaces
{
    /// <summary>
    /// Repository pattern.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Allows to add a new record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity add(TEntity entity);

        /// <summary>
        /// Allows to update a current record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity update(TEntity entity);

        /// <summary>
        /// Allows to get a record.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity get(decimal id);

        /// <summary>
        /// Allows to retrieve a list of records.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> all();

        /// <summary>
        /// Allows to find a list of records.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// </summary>
        void saveChanges();
    }
}
