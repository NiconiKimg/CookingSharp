using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de categorías.
/// </summary>
public interface ICategoryService
{
    /// <summary>
    /// Obtiene todas las categorías.
    /// </summary>
    /// <returns>Una colección de DTOs de categoría.</returns>
    Task<IEnumerable<CategoryResponseDTO>> GetAllAsync();

    /// <summary>
    /// Obtiene todas las categorías, opcionalmente filtradas por un término de búsqueda.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <returns>Una colección de DTOs de categoría.</returns>
    Task<IEnumerable<CategoryResponseDTO>> GetAllAsync(string? searchTerm = null);

    Task<CategoryResponseDTO?> GetByIdAsync(int id);
    Task<CategoryResponseDTO> CreateAsync(CategoryCreateUpdateDTO categoryCreateUpdateDto);
    Task UpdateAsync(int id, CategoryCreateUpdateDTO categoryCreateUpdateDto);
    Task DeleteAsync(int id);

    /// <summary>
    /// Obtiene el número total de categorías.
    /// </summary>
    /// <returns>El conteo total de categorías.</returns>
    Task<int> GetTotalCountAsync();
}