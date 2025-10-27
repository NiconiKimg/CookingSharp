using CookingSharp.Application.DTOs;
using FluentValidation;
using System.Linq;

namespace CookingSharp.Application.Validators;

/// <summary>
/// Validador para el DTO de creación de solicitud.
/// </summary>
public class AppealCreateDtoValidator : AbstractValidator<AppealCreateDTO>
{
    public AppealCreateDtoValidator()
    {
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La descripción de la solicitud es requerida.")
            .MaximumLength(1000).WithMessage("La descripción no puede exceder los 1000 caracteres.");
    }
}

/// <summary>
/// Validador para el DTO de actualización de solicitud.
/// </summary>
public class AppealUpdateDtoValidator : AbstractValidator<AppealUpdateDTO>
{
    private readonly string[] _validStatuses = { "Approved", "Rejected" };

    public AppealUpdateDtoValidator()
    {
        RuleFor(x => x.Status)
            .NotEmpty().WithMessage("El estado es requerido.")
            .Must(status => _validStatuses.Contains(status, System.StringComparer.OrdinalIgnoreCase))
            .WithMessage("El estado debe ser 'Approved' o 'Rejected'.");
    }
}