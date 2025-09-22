using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly CookingSharpDbContext _context;

        public EFCategoryRepository(CookingSharpDbContext context)
        {
            _context = context;
        }

        public async Task<Category> AddAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var categoryToDelete = await _context.Categories.FindAsync(id);
            if (categoryToDelete == null)
            {
                return false;
            }
            _context.Categories.Remove(categoryToDelete);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsWithNameAsync(string name, int? excludeId = null)
        {
            var query = _context.Categories.AsQueryable();
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }

            return await query.AnyAsync(c => c.Name.ToUpper() == name.ToUpper());
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task UpdateAsync(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}