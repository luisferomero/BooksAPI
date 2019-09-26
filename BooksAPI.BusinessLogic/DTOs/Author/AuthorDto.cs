using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.DTOs.Author
{
    public class AuthorDto : IBaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
