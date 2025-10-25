using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de creación y actualización de menú.
/// </summary>
public class MenuCreateUpdateDtoValidator : AbstractValidator<MenuCreateUpdateDTO>
{
    public MenuCreateUpdateDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre del menú es requerido.")
            .MaximumLength(150).WithMessage("El nombre no puede exceder los 150 caracteres.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La descripción es requerida.")
            .MaximumLength(500).WithMessage("La descripción no puede exceder los 500 caracteres.");

        RuleFor(x => x.RecipeIds)
            .NotEmpty().WithMessage("El menú debe contener al menos una receta.");
    }
}