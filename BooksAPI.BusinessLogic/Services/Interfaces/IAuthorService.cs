using BooksAPI.BusinessLogic.DTOs.Author;
using BooksAPI.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Services.Interfaces
{
    public interface IAuthorService : IGenericService<Author, AuthorDto>
    {

    }
}
