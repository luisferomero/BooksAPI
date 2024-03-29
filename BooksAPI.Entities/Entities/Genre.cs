﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.Entities.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
