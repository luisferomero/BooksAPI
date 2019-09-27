using BooksAPI.BusinessLogic.DTOs.Author;
using BooksAPI.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Validators
{
    public class AuthorValidator : AbstractValidator<AuthorDto>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre es requerido");
        }
    }
}
