using CookingSharp.Domain.Entities;
using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Clase base abstracta para todas las valoraciones del sistema.
/// </summary>
public abstract class RatingBase
{
    /// <summary>
    /// Identificador único de la valoración.
    /// </summary>
    public int Id { get; protected set; }

    /// <summary>
    /// Número de estrellas otorgadas (1-5).
    /// </summary>
    public int Stars { get; protected set; }

    /// <summary>
    /// Clave foránea del usuario que realizó la valoración.
    /// </summary>
    public int UserId { get; protected set; }

    public User User { get; protected set; }

    /// <summary>
    /// Establece el número de estrellas para la valoración.
    /// </summary>
    /// <param name="newStars">Número de estrellas (debe estar entre 1 y 5).</param>
    public void SetStars(int newStars)
    {
        if (newStars < 1 || newStars > 5)
            throw new ArgumentOutOfRangeException(nameof(newStars), "La valoración debe estar entre 1 y 5 estrellas.");
        Stars = newStars;
    }
}