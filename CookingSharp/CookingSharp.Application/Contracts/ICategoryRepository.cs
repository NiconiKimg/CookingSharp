using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts;

/// <summary>
/// Contrato para el repositorio de categorías.
/// </summary>
public interface ICategoryRepository : IGenericRepository<Category>
{
    /// <summary>
    /// Verifica si ya existe una categoría con un determinado nombre.
    /// </summary>
    /// <param name="name">El nombre a verificar.</param>
    /// <param name="excludeId">Un ID de categoría opcional para excluir de la búsqueda.</param>
    /// <returns>True si el nombre ya existe, de lo contrario False.</returns>
    Task<bool> ExistsWithNameAsync(string name, int? excludeId = null);

    /// <summary>
    /// Obtiene todas las entidades de un tipo de forma asíncrona, con una opción para filtrar por un término de búsqueda.
    /// Este método oculta la implementación base de IGenericRepository.
    /// </summary>
    /// <param name="searchTerm">El término opcional para filtrar las categorías por nombre.</param>
    /// <returns>Una colección de todas las entidades que coinciden con el filtro.</returns>
    new Task<IEnumerable<Category>> GetAllAsync(string? searchTerm = null);
}