using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.DTOs.Genre
{
    public class GenreDto : IBaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
