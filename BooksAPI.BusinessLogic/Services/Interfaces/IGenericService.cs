using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic.Services.Interfaces
{
    public interface IGenericService<TEntity, TDto>
    {
        Task<TEntity> CreateAsync(TDto dto);
        ICollection<TEntity> GetAll();
        TEntity GetById(int Id);
        TEntity Delete(int Id);
        Task<TEntity> Update(TDto dto);
    }
}
