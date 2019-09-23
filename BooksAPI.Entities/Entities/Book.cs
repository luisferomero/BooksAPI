using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.Entities.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
    }
}
