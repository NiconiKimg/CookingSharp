using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(CookingSharpDbContext context) : base(context)
    {
    }

    public async Task<bool> ExistsWithEmailAsync(string email, int? excludeId = null)
    {
        var query = _dbSet.AsQueryable();
        if (excludeId.HasValue)
        {
            query = query.Where(u => u.Id != excludeId.Value);
        }
        return await query.AnyAsync(u => u.Email.ToUpper() == email.ToUpper());
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _dbSet.FirstOrDefaultAsync(u => u.Email.ToUpper() == email.ToUpper());
    }
}