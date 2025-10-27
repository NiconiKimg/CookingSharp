using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using CookingSharp.Domain.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
{
    public RecipeRepository(CookingSharpDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Recipe>> GetTopRatedRecipesAsync(int count)
    {
        return await _dbSet
            .AsNoTracking()
            .Include(r => r.User)
            .Include(r => r.Ratings)
            .Where(r => r.Ratings.Any() && r.Status == RecipeStatus.Published)
            .OrderByDescending(r => r.Ratings.Average(rt => rt.Stars))
            .Take(count)
            .ToListAsync();
    }

    /// <summary>
    /// Obtiene todas las recetas con sus detalles.
    /// </summary>
    public async Task<IEnumerable<Recipe>> GetAllWithDetailsAsync()
    {
        // Esta implementación ahora llama a la sobrecarga con parámetros nulos
        return await GetAllWithDetailsAsync(null, null);
    }

    /// <summary>
    /// Obtiene todas las recetas con sus detalles, opcionalmente filtradas por un término de búsqueda y/o categoría.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda para filtrar por nombre, descripción o autor.</param>
    /// <param name="categoryId">ID de categoría para filtrar las recetas.</param>
    /// <returns>Una colección de recetas.</returns>
    public async Task<IEnumerable<Recipe>> GetAllWithDetailsAsync(string? searchTerm = null, int? categoryId = null)
    {
        var query = _dbSet
            .Include(r => r.User)
            .Include(r => r.Categories)
            .Include(r => r.Ratings)
            .Include(r => r.Steps)
            .AsNoTracking()
            .Where(r => r.Status == RecipeStatus.Published || r.Status == RecipeStatus.Blocked);

        if (categoryId.HasValue && categoryId > 0)
        {
            query = query.Where(r => r.Categories.Any(c => c.Id == categoryId));
        }

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            var term = searchTerm.ToUpper();
            query = query.Where(r =>
                r.Name.ToUpper().Contains(term) ||
                r.Description.ToUpper().Contains(term) ||
                (r.User.Name + " " + r.User.Surname).ToUpper().Contains(term)
            );
        }

        return await query.ToListAsync();
    }

    /// <summary>
    /// Obtiene todas las recetas públicas (estado "Published"), opcionalmente filtradas.
    /// </summary>
    public async Task<IEnumerable<Recipe>> GetAllPublishedWithDetailsAsync(string? searchTerm = null, int? categoryId = null)
    {
        var query = _dbSet
            .Include(r => r.User)
            .Include(r => r.Categories)
            .Include(r => r.Ratings)
            .Include(r => r.Steps)
            .AsNoTracking()
            .Where(r => r.Status == RecipeStatus.Published);

        if (categoryId.HasValue && categoryId > 0)
        {
            query = query.Where(r => r.Categories.Any(c => c.Id == categoryId));
        }

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            var term = searchTerm.ToUpper();
            query = query.Where(r =>
                r.Name.ToUpper().Contains(term) ||
                r.Description.ToUpper().Contains(term) ||
                (r.User.Name + " " + r.User.Surname).ToUpper().Contains(term)
            );
        }

        return await query.ToListAsync();
    }

    public async Task<Recipe?> GetByIdWithDetailsAsync(int id)
    {
        return await _dbSet
            .Include(r => r.User)
            .Include(r => r.Steps)
            .Include(r => r.Categories)
            .Include(r => r.Ratings)
            .FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<IEnumerable<Recipe>> GetByUserIdWithDetailsAsync(int userId)
    {
        return await _dbSet
            .Include(r => r.User)
            .Include(r => r.Categories)
            .Include(r => r.Steps)
            .Where(r => r.UserId == userId)
            .ToListAsync();
    }
}