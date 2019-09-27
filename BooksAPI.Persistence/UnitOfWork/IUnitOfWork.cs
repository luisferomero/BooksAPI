using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
        Task SaveChangesAsync();
        BooksApiContext GetContext();
    }
}
