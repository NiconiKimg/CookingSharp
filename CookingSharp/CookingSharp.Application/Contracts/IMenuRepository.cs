using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Contrato para el repositorio de menús.
/// </summary>
public interface IMenuRepository : IGenericRepository<Menu>
{
    Task<IEnumerable<Menu>> GetTopRatedMenusAsync(int count);

    /// <summary>
    /// Obtiene todos los menús de un usuario, incluyendo las recetas de cada menú.
    /// </summary>
    /// <param name="userId">El ID del usuario.</param>
    /// <returns>Una colección de menús con sus recetas cargadas.</returns>
    Task<IEnumerable<Menu>> GetMenusByUserWithRecipesAsync(int userId);

    /// <summary>
    /// Obtiene todos los menús con sus detalles (autor, recetas, valoraciones) para vistas de resumen.
    /// </summary>
    Task<IEnumerable<Menu>> GetAllWithDetailsAsync();

    /// <summary>
    /// Obtiene un menús con sus detalles (autor, recetas, valoraciones) para vistas de resumen.
    /// </summary>
    Task<Menu?> GetByIdWithDetailsAsync(int id);

    /// <summary>
    /// Obtiene un menús con filtros.
    /// </summary>
    Task<IEnumerable<Menu>> GetAllWithDetailsAsync(string? nameFilter = null, string? authorFilter = null);

}