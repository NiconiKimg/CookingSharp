using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts;

public interface IRecipeRepository : IGenericRepository<Recipe>
{
    /// <summary>
    /// Obtiene todas las recetas incluyendo sus datos relacionados (Autor, Pasos, Categorías).
    /// </summary>
    Task<IEnumerable<Recipe>> GetAllWithDetailsAsync();

    /// <summary>
    /// Obtiene todas las recetas incluyendo sus datos relacionados, opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional para filtrar por nombre, descripción o autor.</param>
    /// <param name="categoryId">ID de categoría opcional para filtrar las recetas.</param>
    Task<IEnumerable<Recipe>> GetAllWithDetailsAsync(string? searchTerm = null, int? categoryId = null);

    /// <summary>
    /// Obtiene una receta por su ID, incluyendo sus datos relacionados.
    /// </summary>
    Task<Recipe?> GetByIdWithDetailsAsync(int id);

    /// <summary>
    /// Obtiene una receta por el ID del autor, incluyendo sus datos relacionados.
    /// </summary>
    Task<IEnumerable<Recipe>> GetByUserIdWithDetailsAsync(int userId);

    /// <summary>
    /// Obtiene un número específico de las recetas mejor calificadas.
    /// </summary>
    /// <param name="count">El número de recetas a devolver.</param>
    /// <returns>Una colección de las recetas mejor calificadas.</returns>
    Task<IEnumerable<Recipe>> GetTopRatedRecipesAsync(int count);

    /// <summary>
    /// Obtiene todas las recetas públicas (estado "Published"), opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de recetas publicadas.</returns>
    Task<IEnumerable<Recipe>> GetAllPublishedWithDetailsAsync(string? searchTerm = null, int? categoryId = null);
    
    /// <summary>
    /// Obtiene una receta por su ID, incluyendo la colección de menús asociados.
    /// </summary>
    Task<Recipe?> GetByIdWithMenusAsync(int id);
}