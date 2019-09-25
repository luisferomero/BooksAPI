using BooksAPI.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.Persistence
{
    public class BooksApiContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=BooksAPI;Integrated Security=True");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
