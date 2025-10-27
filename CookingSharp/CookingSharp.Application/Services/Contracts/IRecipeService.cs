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

    /// <summary>
    /// Obtiene todas las recetas con sus detalles, opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de DTOs de receta.</returns>
    Task<IEnumerable<RecipeResponseDTO>> GetAllAsync(string? searchTerm = null, int? categoryId = null);

    /// <summary>
    /// Obtiene las recetas completas (con pasos) de un usuario específico.
    /// </summary>
    /// <param name="userId">El ID del usuario autor.</param>
    /// <returns>Una colección de DTOs de receta completos.</returns>
    Task<IEnumerable<RecipeResponseDTO>> GetFullRecipesByUserIdAsync(int userId);

    Task<IEnumerable<RecipeSummaryDTO>> GetAllSummariesAsync();
    Task<IEnumerable<RecipeSummaryDTO>> GetRecipesByUserIdAsync(int userId);
    Task<RecipeResponseDTO> GetByIdAsync(int id);
    Task UpdateStatusAsync(int recipeId, RecipeStatusUpdateDTO dto);


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

    /// <summary>
    /// Obtiene todas las recetas públicas (en formato de resumen), opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de DTOs de resumen de receta.</returns>
    Task<IEnumerable<RecipeSummaryDTO>> GetAllPublishedSummariesAsync(string? searchTerm = null, int? categoryId = null);

    /// <summary>
    /// Actualiza únicamente el estado de una receta.
    /// </summary>
    /// <param name="id">El ID de la receta a actualizar.</param>
    /// <param name="statusUpdateDto">El DTO con el nuevo estado.</param>
    Task UpdateStatusAsync(int id, RecipeStatusUpdateDTO statusUpdateDto);
}