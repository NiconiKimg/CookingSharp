using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de valoración.
/// </summary>
public class RatingCreateUpdateDtoValidator : AbstractValidator<RatingCreateUpdateDTO>
{
    public RatingCreateUpdateDtoValidator()
    {
        RuleFor(x => x.Stars)
            .InclusiveBetween(1, 5).WithMessage("La valoración debe ser un número entre 1 y 5.");
    }
}