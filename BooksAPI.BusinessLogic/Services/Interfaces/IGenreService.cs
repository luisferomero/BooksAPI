using BooksAPI.BusinessLogic.DTOs.Genre;
using BooksAPI.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Services.Interfaces
{
    public interface IGenreService : IGenericService<Genre, GenreDto>
    {
    }
}
