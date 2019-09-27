using BooksAPI.BusinessLogic.DTOs.Genre;
using FluentValidation; 
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Validators
{
    public class GenreValidator : AbstractValidator<GenreDto>
    {
        public GenreValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("El nombre es requerido");
        }
    }
}
