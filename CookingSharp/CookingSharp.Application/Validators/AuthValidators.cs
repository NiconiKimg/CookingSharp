using CookingSharp.Application.DTOs;
using FluentValidation;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de inicio de sesión.
/// </summary>
public class UserLoginDtoValidator : AbstractValidator<UserLoginDTO>
{
    public UserLoginDtoValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("El email es requerido.")
            .EmailAddress().WithMessage("Debe proporcionar una dirección de email válida.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("La contraseña es requerida.");
    }
}