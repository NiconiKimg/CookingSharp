using System;

namespace CookingSharp.Application.Common.Exceptions;

/// <summary>
/// Excepción personalizada para errores de validación de negocio o solicitudes incorrectas.
/// </summary>
public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
    }
}