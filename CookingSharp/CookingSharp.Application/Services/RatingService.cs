using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de gestión de valoraciones.
/// </summary>
public class RatingService : IRatingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RatingService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Añade o actualiza la valoración de un usuario para una receta específica.
    /// </summary>
    /// <param name="recipeId">El ID de la receta a valorar.</param>
    /// <param name="ratingDto">El DTO con la puntuación en estrellas.</param>
    /// <param name="userId">El ID del usuario que realiza la valoración.</param>
    /// <exception cref="NotFoundException">Se lanza si la receta o el usuario no existen.</exception>
    public async Task RateRecipeAsync(int recipeId, RatingCreateUpdateDTO ratingDto, int userId)
    {
        _ = await _unitOfWork.Recipes.GetByIdAsync(recipeId) ?? throw new NotFoundException(nameof(Recipe), recipeId);
        _ = await _unitOfWork.Users.GetByIdAsync(userId) ?? throw new NotFoundException(nameof(User), userId);

        // Idealmente, el repositorio tendría un método para buscar por RecipeId y UserId
        var existingRating = (await _unitOfWork.Ratings.GetAllAsync())
            .FirstOrDefault(r => r.RecipeId == recipeId && r.UserId == userId);

        if (existingRating is null)
        {
            // Crear nueva valoración
            var newRating = new Rating(ratingDto.Stars, userId, recipeId);
            await _unitOfWork.Ratings.AddAsync(newRating);
        }
        else
        {
            // Actualizar valoración existente
            existingRating.SetStars(ratingDto.Stars);
            _unitOfWork.Ratings.Update(existingRating);
        }

        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Elimina la valoración de un usuario para una receta.
    /// </summary>
    /// <param name="recipeId">El ID de la receta.</param>
    /// <param name="userId">El ID del usuario cuya valoración se eliminará.</param>
    /// <exception cref="NotFoundException">Se lanza si la valoración no existe.</exception>
    public async Task RemoveRatingAsync(int recipeId, int userId)
    {
        var ratingToRemove = (await _unitOfWork.Ratings.GetAllAsync())
            .FirstOrDefault(r => r.RecipeId == recipeId && r.UserId == userId)
            ?? throw new NotFoundException("No se encontró una valoración para este usuario en esta receta.", $"{recipeId}/{userId}");

        _unitOfWork.Ratings.Delete(ratingToRemove);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Obtiene la valoración promedio de una receta.
    /// </summary>
    /// <param name="recipeId">El ID de la receta.</param>
    /// <returns>La puntuación promedio, o 0 si no tiene valoraciones.</returns>
    /// <exception cref="NotFoundException">Se lanza si la receta no existe.</exception>
    public async Task<double> GetAverageRatingForRecipeAsync(int recipeId)
    {
        _ = await _unitOfWork.Recipes.GetByIdAsync(recipeId) ?? throw new NotFoundException(nameof(Recipe), recipeId);

        var allRatings = await _unitOfWork.Ratings.GetAllAsync();
        var recipeRatings = allRatings.Where(r => r.RecipeId == recipeId);

        if (!recipeRatings.Any())
        {
            return 0.0;
        }

        return recipeRatings.Average(r => r.Stars);
    }
}