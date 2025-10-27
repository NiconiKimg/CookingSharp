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

        /// <summary>
        /// Obtiene todas las solicitudes pendientes de la base de datos, incluyendo
        /// la información del usuario asociado a cada solicitud.
        /// </summary>
        public async Task<IEnumerable<Appeal>> GetPendingWithUserDetailsAsync()
        {
            return await _dbSet
                .Include(a => a.User)
                .Where(a => a.Status == AppealStatus.Pending)
                .ToListAsync();
        }

        /// <summary>
        /// Cuenta eficientemente el número de solicitudes cuyo estado es "Pendiente".
        /// </summary>
        public async Task<int> CountPendingAsync()
        {
            return await _dbSet.CountAsync(a => a.Status == AppealStatus.Pending);
        }

        /// <summary>
        /// Verifica si un usuario tiene alguna solicitud en estado "Pendiente".
        /// </summary>
        /// <param name="userId">El ID del usuario a verificar.</param>
        /// <returns>True si el usuario tiene una solicitud pendiente, de lo contrario False.</returns>
        public async Task<bool> HasPendingAppealAsync(int userId)
        {
            return await _dbSet.AnyAsync(a => a.UserId == userId && a.Status == AppealStatus.Pending);
        }
    }
}