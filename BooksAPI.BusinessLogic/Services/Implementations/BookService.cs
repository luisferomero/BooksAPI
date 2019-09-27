using AutoMapper;
using BooksAPI.BusinessLogic.DTOs.Book;
using BooksAPI.BusinessLogic.Services.Interfaces;
using BooksAPI.BusinessLogic.Validators;
using BooksAPI.Entities.Entities;
using BooksAPI.Persistence.Repositories;
using BooksAPI.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Services.Implementations
{
    public class BookService : GenericService<Book, BookDto> , IBookService
    {
        public BookService(IUnitOfWork uow, IMapper mapper, IGenericRepository<Book> repository)
            : base(uow, mapper, repository, new BookValidator())
        {

        }
    }
}
