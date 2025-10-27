using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de creación de usuario.
/// </summary>
public class UserCreateDtoValidator : AbstractValidator<UserCreateDTO>
{
    public UserCreateDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre es requerido.")
            .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres.");

        RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("El apellido es requerido.")
            .MaximumLength(100).WithMessage("El apellido no puede exceder los 100 caracteres.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("El email es requerido.")
            .EmailAddress().WithMessage("Debe proporcionar una dirección de email válida.")
            .MaximumLength(255).WithMessage("El email no puede exceder los 255 caracteres.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("La contraseña es requerida.")
            .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.");
    }
}

/// <summary>
/// Validador para el DTO de actualización de usuario.
/// </summary>
public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDTO>
{
    public UserUpdateDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre es requerido.")
            .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres.");

        RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("El apellido es requerido.")
            .MaximumLength(100).WithMessage("El apellido no puede exceder los 100 caracteres.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("El email es requerido.")
            .EmailAddress().WithMessage("Debe proporcionar una dirección de email válida.")
            .MaximumLength(255).WithMessage("El email no puede exceder los 255 caracteres.");
    }
}