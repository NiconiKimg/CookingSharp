using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(CookingSharpDbContext context) : base(context)
    {
    }

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