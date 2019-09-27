using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Persistence.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly BooksApiContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(BooksApiContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity) => _dbSet.Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) => _dbSet.AddRange(entities);

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => _dbSet.Where(predicate);

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();

        public TEntity GetById(int Id) => _dbSet.Find(Id);

        public void Remove(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Update(TEntity entity) => _dbSet.Update(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => _dbSet.RemoveRange(entities);

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate) => _dbSet.SingleOrDefault(predicate);

        public int GetQuantity() => _dbSet.Count();

        public bool Any(Expression<Func<TEntity, bool>> predicate) =>  _dbSet.Any(predicate);
        
    }
}
