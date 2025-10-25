using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa la valoración (de 1 a 5 estrellas) que un usuario da a una receta.
/// </summary>
public class Rating
{
    /// <summary>
    /// Identificador único de la valoración.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Puntuación en estrellas (un valor entre 1 y 5).
    /// </summary>
    public int Stars { get; private set; }

    /// <summary>
    /// Clave foránea del usuario que realiza la valoración.
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Clave foránea de la receta que está siendo valorada.
    /// </summary>
    public int RecipeId { get; private set; }

    public User User { get; private set; }
    public Recipe Recipe { get; private set; }

    private Rating() { }

    /// <summary>
    /// Constructor para crear una nueva valoración válida.
    /// </summary>
    /// <param name="stars">Puntuación en estrellas (1-5).</param>
    /// <param name="userId">ID del usuario que valora.</param>
    /// <param name="recipeId">ID de la receta valorada.</param>
    public Rating(int stars, int userId, int recipeId)
    {
        SetStars(stars);

        if (userId <= 0)
            throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));

        if (recipeId <= 0)
            throw new ArgumentException("El ID de receta debe ser un valor positivo.", nameof(recipeId));

        UserId = userId;
        RecipeId = recipeId;
    }

    /// <summary>
    /// Cambia la puntuación de la valoración, asegurando que esté en el rango válido.
    /// </summary>
    /// <param name="newStars">La nueva puntuación (1-5).</param>
    public void SetStars(int newStars)
    {
        if (newStars < 1 || newStars > 5)
            throw new ArgumentOutOfRangeException(nameof(newStars), "La valoración debe estar entre 1 y 5 estrellas.");

        Stars = newStars;
    }
}