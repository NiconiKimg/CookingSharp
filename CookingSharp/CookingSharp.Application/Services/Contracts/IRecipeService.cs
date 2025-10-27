using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de recetas.
/// </summary>
public interface IRecipeService
{
    Task<IEnumerable<RecipeResponseDTO>> GetAllAsync();
    Task<IEnumerable<RecipeSummaryDTO>> GetAllSummariesAsync();
    Task<IEnumerable<RecipeSummaryDTO>> GetRecipesByUserIdAsync(int userId);
    Task<RecipeResponseDTO> GetByIdAsync(int id);

    /// <summary>
    /// Crea una nueva receta.
    /// </summary>
    /// <param name="recipeCreateDto">El DTO con los datos de la nueva receta.</param>
    /// <param name="creatorUserId">El ID del usuario que está creando la receta.</param>
    /// <returns>El DTO de la receta recién creada.</returns>
    Task<RecipeResponseDTO> CreateAsync(RecipeCreateDTO recipeCreateDto, int creatorUserId);

    Task UpdateAsync(int id, RecipeUpdateDTO recipeUpdateDto);
    Task DeleteAsync(int id);

    /// <summary>
    /// Obtiene el número total de recetas en el sistema.
    /// </summary>
    /// <returns>El conteo total de recetas.</returns>
    Task<int> GetTotalCountAsync();
}