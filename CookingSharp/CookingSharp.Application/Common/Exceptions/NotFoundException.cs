using System;

namespace CookingSharp.Application.Common.Exceptions;

/// <summary>
/// Excepción personalizada para ser lanzada cuando no se encuentra un recurso solicitado.
/// </summary>
public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string name, object key)
        : base($"La entidad \"{name}\" ({key}) no fue encontrada.")
    {
    }
}