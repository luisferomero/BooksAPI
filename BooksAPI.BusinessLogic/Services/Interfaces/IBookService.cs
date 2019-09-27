using BooksAPI.BusinessLogic.DTOs.Book;
using BooksAPI.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Services.Interfaces
{
    public interface IBookService : IGenericService<Book, BookDto>
    {

    }
}
