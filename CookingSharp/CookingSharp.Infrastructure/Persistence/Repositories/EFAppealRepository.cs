using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    public class EFAppealRepository : IAppealRepository
    {
        private readonly CookingSharpDbContext _context;

        public EFAppealRepository(CookingSharpDbContext context)
        {
            _context = context;
        }

        public async Task<Appeal> AddAsync(Appeal appeal)
        {
            _context.Appeals.Add(appeal);
            await _context.SaveChangesAsync();
            return appeal;
        }

        public async Task<IEnumerable<Appeal>> GetAllAsync()
        {
            return await _context.Appeals.ToListAsync();
        }

        public async Task<Appeal?> GetByIdAsync(int id)
        {
            return await _context.Appeals.FindAsync(id);
        }

        public async Task UpdateAsync(Appeal appeal)
        {
            _context.Entry(appeal).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}