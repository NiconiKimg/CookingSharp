using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Contracts
{
    /// <summary>
    /// Define el contrato para un repositorio que realiza consultas complejas de análisis de recetas,
    /// destinado a la implementación con ADO.NET para un rendimiento óptimo.
    /// </summary>
    public interface IRecipeAnalysisRepository
    {
        /// <summary>
        /// Obtiene datos de análisis agregados para todas las recetas publicadas.
        /// </summary>
        /// <returns>Una colección de DTOs con los datos de análisis de recetas.</returns>
        Task<IEnumerable<RecipeAnalysisDataDto>> GetRecipeAnalysisDataAsync();
    }
}