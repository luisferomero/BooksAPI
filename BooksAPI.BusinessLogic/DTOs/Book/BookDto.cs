using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.DTOs.Book
{
    public class BookDto : IBaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
