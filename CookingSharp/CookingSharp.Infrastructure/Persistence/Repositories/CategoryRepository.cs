using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del repositorio para la entidad Category.
/// </summary>
public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    /// <summary>
    /// Constructor del repositorio de categorías.
    /// </summary>
    /// <param name="context">El contexto de la base de datos.</param>
    public CategoryRepository(CookingSharpDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Obtiene todas las categorías, opcionalmente filtradas por un término de búsqueda en el nombre.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda para filtrar por nombre.</param>
    /// <returns>Una colección de categorías.</returns>
    public async Task<IEnumerable<Category>> GetAllAsync(string? searchTerm = null)
    {
        var query = _dbSet.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            query = query.Where(c => c.Name.Contains(searchTerm));
        }

        return await query.ToListAsync();
    }

    /// <summary>
    /// Verifica si una categoría con un nombre específico ya existe.
    /// </summary>
    /// <param name="name">Nombre a verificar.</param>
    /// <param name="excludeId">ID de categoría a excluir de la búsqueda.</param>
    /// <returns>Verdadero si existe, falso en caso contrario.</returns>
    public async Task<bool> ExistsWithNameAsync(string name, int? excludeId = null)
    {
        var query = _dbSet.AsQueryable();
        if (excludeId.HasValue)
        {
            query = query.Where(c => c.Id != excludeId.Value);
        }
        return await query.AnyAsync(c => c.Name.ToUpper() == name.ToUpper());
    }
}