using CookingSharp.Application.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Implementación del repositorio para la entidad Appeal.
    /// </summary>
    public class AppealRepository : GenericRepository<Appeal>, IAppealRepository
    {
        public AppealRepository(CookingSharpDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Appeal>> GetPendingWithUserDetailsAsync()
        {
            return await _dbSet
                .Include(a => a.User)
                .Where(a => a.Status == AppealStatus.Pending)
                .ToListAsync();
        }
    }
}