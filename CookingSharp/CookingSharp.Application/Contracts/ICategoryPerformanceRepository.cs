using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts
{
    /// <summary>
    /// Define el contrato para un repositorio que obtiene datos de rendimiento por categoría.
    /// </summary>
    public interface ICategoryPerformanceRepository
    {
        /// <summary>
        /// Obtiene datos de rendimiento agregados para todas las categorías.
        /// </summary>
        /// <returns>Una colección de DTOs con los datos de rendimiento.</returns>
        Task<IEnumerable<CategoryPerformanceDto>> GetCategoryPerformanceDataAsync();
    }
}