using System;

namespace CookingSharp.Domain.Entities;

public class RecipeRating : RatingBase
{
    public int RecipeId { get; private set; }
    public Recipe Recipe { get; private set; }

    private RecipeRating() { }

    public RecipeRating(int stars, int userId, int recipeId)
    {
        SetStars(stars);

        if (userId <= 0) throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));
        if (recipeId <= 0) throw new ArgumentException("El ID de receta debe ser un valor positivo.", nameof(recipeId));

        UserId = userId;
        RecipeId = recipeId;
    }
}