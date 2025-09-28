using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private readonly CookingSharpDbContext _context;

        public EFRecipeRepository(CookingSharpDbContext context)
        {
            _context = context;
        }

        public async Task<Recipe> AddAsync(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var recipeToDelete = await _context.Recipes.FindAsync(id);
            if (recipeToDelete == null)
            {
                return false;
            }
            _context.Recipes.Remove(recipeToDelete);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            return await _context.Recipes
                .Include(r => r.User)
                .Include(r => r.Categories)
                .ToListAsync();
        }

        public async Task<Recipe?> GetByIdAsync(int id)
        {
            return await _context.Recipes
                .Include(r => r.User)
                .Include(r => r.Categories)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task UpdateAsync(Recipe recipe)
        {
            _context.Entry(recipe).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}