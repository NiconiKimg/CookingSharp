using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de creación de receta.
/// </summary>
public class RecipeCreateDtoValidator : AbstractValidator<RecipeCreateDTO>
{
    public RecipeCreateDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre de la receta es requerido.")
            .MaximumLength(150).WithMessage("El nombre no puede exceder los 150 caracteres.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La descripción es requerida.")
            .MaximumLength(500).WithMessage("La descripción no puede exceder los 500 caracteres.");

        RuleFor(x => x.Steps)
            .NotEmpty().WithMessage("La receta debe tener al menos un paso.");

        // Valida cada uno de los pasos en la colección
        RuleForEach(x => x.Steps)
            .SetValidator(new RecipeStepCreateDtoValidator());

        RuleFor(x => x.CategoryIds)
            .NotEmpty().WithMessage("La receta debe pertenecer al menos a una categoría.");
    }
}

/// <summary>
/// Validador para el DTO de actualización de receta.
/// </summary>
public class RecipeUpdateDtoValidator : AbstractValidator<RecipeUpdateDTO>
{
    public RecipeUpdateDtoValidator()
    {
        // Las reglas son idénticas a la creación
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre de la receta es requerido.")
            .MaximumLength(150).WithMessage("El nombre no puede exceder los 150 caracteres.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La descripción es requerida.")
            .MaximumLength(500).WithMessage("La descripción no puede exceder los 500 caracteres.");

        RuleFor(x => x.Steps)
            .NotEmpty().WithMessage("La receta debe tener al menos un paso.");

        RuleForEach(x => x.Steps)
            .SetValidator(new RecipeStepCreateDtoValidator());

        RuleFor(x => x.CategoryIds)
            .NotEmpty().WithMessage("La receta debe pertenecer al menos a una categoría.");
    }
}


/// <summary>
/// Validador para el DTO de creación de paso de receta.
/// </summary>
public class RecipeStepCreateDtoValidator : AbstractValidator<RecipeStepCreateDTO>
{
    public RecipeStepCreateDtoValidator()
    {
        RuleFor(x => x.Instruction)
            .NotEmpty().WithMessage("La instrucción del paso no puede estar vacía.")
            .MaximumLength(1000).WithMessage("La instrucción no puede exceder los 1000 caracteres.");
    }
}