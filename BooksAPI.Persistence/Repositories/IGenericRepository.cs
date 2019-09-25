using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Persistence.Repositories
{
    public interface IGenericRepository
    {
        public interface IGenericRepository<TEntity> where TEntity : class
        {
            TEntity GetById(int Id);
            IEnumerable<TEntity> GetAll();
            IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
            TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
            void Add(TEntity entity);
            void AddRange(IEnumerable<TEntity> entities);
            void Remove(TEntity entity);
            void RemoveRange(IEnumerable<TEntity> entities);
            void Update(TEntity entity);
            IEnumerable<TEntity> GetListMultipleInclude(params Expression<Func<TEntity, object>>[] includes);
            TEntity GetSingleMultipleInclude(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
            Task<TEntity> GetIncludeAsync(Expression<Func<TEntity, object>> include, Expression<Func<TEntity, bool>> predicate);
            int GetQuantity();
            bool Any(Expression<Func<TEntity, bool>> predicate);
        }
    }
}
