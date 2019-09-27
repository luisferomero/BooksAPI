using AutoMapper;
using BooksAPI.BusinessLogic.DTOs.Genre;
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
    public class GenreService : GenericService<Genre, GenreDto> , IGenreService
    {
        public GenreService(IUnitOfWork uow, IMapper mapper, IGenericRepository<Genre> repository)
            : base(uow, mapper, repository, new GenreValidator())
        {

        }
    }
}
