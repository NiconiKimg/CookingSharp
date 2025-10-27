using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa la valoración que un usuario otorga a una receta.
/// </summary>
public class RecipeRating : RatingBase
{
    /// <summary>
    /// Clave foránea de la receta calificada.
    /// </summary>
    public int RecipeId { get; private set; }

    public Recipe Recipe { get; private set; }

    private RecipeRating() { }

    /// <summary>
    /// Constructor para crear una nueva valoración de receta válida.
    /// </summary>
    /// <param name="stars">Número de estrellas (1-5).</param>
    /// <param name="userId">ID del usuario que realiza la valoración.</param>
    /// <param name="recipeId">ID de la receta calificada.</param>
    public RecipeRating(int stars, int userId, int recipeId)
    {
        SetStars(stars);

        if (userId <= 0) throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));
        if (recipeId <= 0) throw new ArgumentException("El ID de receta debe ser un valor positivo.", nameof(recipeId));

        UserId = userId;
        RecipeId = recipeId;
    }
}