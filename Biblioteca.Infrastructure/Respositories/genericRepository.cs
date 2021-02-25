using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Biblioteca.Infrastructure.Respositories.Interfaces;

namespace Biblioteca.Infrastructure.Respositories
{
    /// <summary>
    /// Class for generic repository.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class genericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Context for EF.
        /// </summary>
        protected libraryContext context;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context"></param>
        public genericRepository(libraryContext context) => 
            this.context = context;


        /// <summary>
        /// <see cref="IRepository{TEntity}.add(TEntity)"/>
        /// </summary>
        public virtual TEntity add(TEntity entity)
        {
            return context
                .Add(entity)
                .Entity;
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}.find(Expression{Func{TEntity, bool}})"/>
        /// </summary>
        public virtual IEnumerable<TEntity> find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}.get(decimal)"/>
        /// </summary>
        public virtual TEntity get(decimal id)
        {
            return context.Find<TEntity>(id);
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}.all"/>
        /// </summary>
        public virtual IEnumerable<TEntity> all()
        {
            return context.Set<TEntity>()
                .AsQueryable()
                .ToList();
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}.update(TEntity)"/>
        /// </summary>
        public virtual TEntity update(TEntity entity)
        {
            return context.Update(entity)
                .Entity;
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}"/>
        /// </summary>
        public TEntity delete(TEntity entity)
        {
            return context.Remove(entity)
                .Entity;
        }

        /// <summary>
        /// <see cref="IRepository{TEntity}.saveChanges"/>
        /// </summary>
        public void saveChanges()
        {
            context.SaveChanges();
        }
    }
}
