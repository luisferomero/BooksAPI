using BooksAPI.BusinessLogic.DTOs;
using BooksAPI.BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic.Services.Implementations
{
    public class GenericService<TEntiy, TDto> : IGenericService<TEntiy, TDto> where TEntiy : class where TDto : IBaseDto
    {
        public GenericService()
        {

        }
        public Task<TEntiy> CreateAsync(TDto dto)
        {
            throw new NotImplementedException();
        }

        public TEntiy Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntiy> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntiy GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntiy> Update(TDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
