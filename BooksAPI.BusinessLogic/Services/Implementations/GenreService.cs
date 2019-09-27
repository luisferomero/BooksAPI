using BooksAPI.BusinessLogic.DTOs.Genre;
using BooksAPI.BusinessLogic.Services.Interfaces;
using BooksAPI.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Services.Implementations
{
    public class GenreService : GenericService<Genre, GenreDto> , IGenreService
    {
    }
}
