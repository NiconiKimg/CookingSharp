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

    public async Task<IEnumerable<Menu>> GetMenusByUserWithRecipesAsync(int userId)
    {
        return await _dbSet
            .Include(m => m.Recipes)
            .Where(m => m.UserId == userId)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<IEnumerable<Menu>> GetAllWithDetailsAsync()
    {
        return await _dbSet
            .Include(m => m.User)
            .Include(m => m.Recipes)
            .Include(m => m.Ratings)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Menu?> GetByIdWithDetailsAsync(int id)
    {
        return await _dbSet
            .Include(m => m.User)
            .Include(m => m.Ratings)
            .Include(m => m.Recipes)
                .ThenInclude(r => r.User)
            .Include(m => m.Recipes)
                .ThenInclude(r => r.Categories)
            .Include(m => m.Recipes)
                .ThenInclude(r => r.Ratings)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}