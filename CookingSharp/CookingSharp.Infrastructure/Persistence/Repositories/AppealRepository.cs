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
        ///Obtiene todas las solicitudes pendientes de la base de datos, incluyendo
        ///la información del usuario asociado a cada solicitud.
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
            // Realiza el conteo directamente en la base de datos para máxima eficiencia,
            // aplicando un filtro para contar solo las entidades con estado 'Pending'.
            return await _dbSet.CountAsync(a => a.Status == AppealStatus.Pending);
        }
    }
}