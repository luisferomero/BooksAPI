using BooksAPI.BusinessLogic.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic.Services.Interfaces
{
    public interface IGenericService<TEntity, TDto>
    {
        Task<ResultResponse> CreateAsync(TDto dto);
        ResultResponse GetAll();
        ResultResponse GetById(int Id);
        ResultResponse Delete(int Id);
        Task<ResultResponse> Update(TDto dto);
    }
}
