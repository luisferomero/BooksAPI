using AutoMapper;
using BooksAPI.BusinessLogic.DTOs.Author;
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
    public class AuthorService : GenericService<Author, AuthorDto>, IAuthorService
    {
        public AuthorService(IUnitOfWork uow, IMapper mapper, IGenericRepository<Author> repository)
            : base(uow, mapper, repository, new AuthorValidator())
        {


        }
    }
}
