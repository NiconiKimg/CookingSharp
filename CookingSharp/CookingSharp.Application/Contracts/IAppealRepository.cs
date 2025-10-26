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
    }
}