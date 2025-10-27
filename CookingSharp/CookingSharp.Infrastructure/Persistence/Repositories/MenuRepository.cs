using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

/// <summary>
/// Implementación del repositorio para la entidad Menu.
/// </summary>
public class MenuRepository : GenericRepository<Menu>, IMenuRepository
{
    public MenuRepository(CookingSharpDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Menu>> GetTopRatedMenusAsync(int count)
    {
        return await _dbSet
            .AsNoTracking()
            .Include(m => m.User) 
            .Include(m => m.Recipes)
            .Include(m => m.Ratings)
            .Where(m => m.Ratings.Any())
            .OrderByDescending(m => m.Ratings.Average(rt => rt.Stars))
            .Take(count)
            .ToListAsync();
    }
}