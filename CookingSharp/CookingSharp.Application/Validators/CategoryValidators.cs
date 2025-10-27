using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de creación y actualización de categoría.
/// </summary>
public class CategoryCreateUpdateDtoValidator : AbstractValidator<CategoryCreateUpdateDTO>
{
    public CategoryCreateUpdateDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre de la categoría es requerido.")
            .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La descripción es requerida.")
            .MaximumLength(255).WithMessage("La descripción no puede exceder los 255 caracteres.");
    }
}