using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
{
    public RecipeRepository(CookingSharpDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Recipe>> GetAllWithDetailsAsync()
    {
        return await _dbSet
            .Include(r => r.User)
            .Include(r => r.Categories)
            .Include(r => r.Ratings)
            .Include(r => r.Steps)
            .AsNoTracking()
            .ToListAsync();
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
            .Where(r => r.UserId == userId)
            .ToListAsync();
    }
}