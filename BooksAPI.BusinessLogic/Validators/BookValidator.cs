using BooksAPI.BusinessLogic.DTOs.Book;
using BooksAPI.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Validators
{
    public class BookValidator : AbstractValidator<BookDto>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre es requerido");
        }
    }
}
