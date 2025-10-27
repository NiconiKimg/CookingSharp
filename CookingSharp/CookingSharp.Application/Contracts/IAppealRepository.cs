using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts
{
    /// <summary>
    /// Contrato para el repositorio de solicitudes (Appeals).
    /// </summary>
    public interface IAppealRepository : IGenericRepository<Appeal>
    {
        /// <summary>
        /// Obtiene todas las solicitudes pendientes, incluyendo los datos del usuario solicitante.
        /// </summary>
        /// <returns>Una colección de entidades Appeal con el usuario cargado.</returns>
        Task<IEnumerable<Appeal>> GetPendingWithUserDetailsAsync();

        /// <summary>
        /// Cuenta el número de solicitudes en estado "Pendiente".
        /// </summary>
        /// <returns>El número de solicitudes pendientes.</returns>
        Task<int> CountPendingAsync();

        /// <summary>
        /// Verifica si un usuario tiene alguna solicitud en estado "Pendiente".
        /// </summary>
        /// <param name="userId">El ID del usuario a verificar.</param>
        /// <returns>True si el usuario tiene una solicitud pendiente, de lo contrario False.</returns>
        Task<bool> HasPendingAppealAsync(int userId);
    }
}