using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private BooksApiContext _context;
        public UnitOfWork(BooksApiContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public BooksApiContext GetContext()
        {
            return _context;
        }
    }
}
