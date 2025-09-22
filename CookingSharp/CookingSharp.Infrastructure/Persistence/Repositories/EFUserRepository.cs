using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly CookingSharpDbContext _context;

        public EFUserRepository(CookingSharpDbContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null)
            {
                return false;
            }
            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsWithEmailAsync(string mail, int? excludeId = null)
        {
            var query = _context.Users.AsQueryable();
            if (excludeId.HasValue)
            {
                query = query.Where(u => u.Id != excludeId.Value);
            }
            return await query.AnyAsync(u => u.Email.ToUpper() == mail.ToUpper());
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task UpdateAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}