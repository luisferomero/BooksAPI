using AutoMapper;
using BooksAPI.BusinessLogic.DTOs.Author;
using BooksAPI.BusinessLogic.DTOs.Book;
using BooksAPI.BusinessLogic.DTOs.Genre;
using BooksAPI.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Genre, GenreDto>().ReverseMap();
        }
    }
}
