using CookingSharp.Application.DTOs;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de valoraciones.
/// </summary>
public interface IRatingService
{
    /// <summary>
    /// Añade o actualiza la valoración de un usuario para una receta específica.
    /// Si el usuario ya ha valorado la receta, se actualiza la valoración existente.
    /// Si no, se crea una nueva.
    /// </summary>
    /// <param name="recipeId">El ID de la receta a valorar.</param>
    /// <param name="ratingDto">El DTO con la puntuación en estrellas.</param>
    /// <param name="userId">El ID del usuario que realiza la valoración.</param>
    Task RateRecipeAsync(int recipeId, RatingCreateUpdateDTO ratingDto, int userId);

    /// <summary>
    /// Elimina la valoración de un usuario para una receta.
    /// </summary>
    /// <param name="recipeId">El ID de la receta.</param>
    /// <param name="userId">El ID del usuario cuya valoración se eliminará.</param>
    Task RemoveRatingAsync(int recipeId, int userId);

    /// <summary>
    /// Obtiene la valoración promedio de una receta.
    /// </summary>
    /// <param name="recipeId">El ID de la receta.</param>
    /// <returns>La puntuación promedio, o 0 si no tiene valoraciones.</returns>
    Task<double> GetAverageRatingForRecipeAsync(int recipeId);
}