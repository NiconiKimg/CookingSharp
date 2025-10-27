using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de creación de comentario.
/// </summary>
public class CommentCreateDtoValidator : AbstractValidator<CommentCreateDTO>
{
    public CommentCreateDtoValidator()
    {
        RuleFor(x => x.Text)
            .NotEmpty().WithMessage("El texto del comentario no puede estar vacío.")
            .MaximumLength(1000).WithMessage("El comentario no puede exceder los 1000 caracteres.");
    }
}

/// <summary>
/// Validador para el DTO de actualización de comentario.
/// </summary>
public class CommentUpdateDtoValidator : AbstractValidator<CommentUpdateDTO>
{
    public CommentUpdateDtoValidator()
    {
        RuleFor(x => x.Text)
            .NotEmpty().WithMessage("El texto del comentario no puede estar vacío.")
            .MaximumLength(1000).WithMessage("El comentario no puede exceder los 1000 caracteres.");
    }
}