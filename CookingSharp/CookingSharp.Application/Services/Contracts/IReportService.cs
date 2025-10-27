using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts
{
    /// <summary>
    /// Define el contrato para los servicios de generación de reportes.
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Genera un reporte en formato PDF con el ranking de las recetas más populares.
        /// </summary>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        Task<byte[]> GenerateTopRatedRecipesReportAsync();

        /// <summary>
        /// Genera un reporte en formato PDF con la contribución de recetas por cada chef.
        /// </summary>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        Task<byte[]> GenerateChefContributionReportAsync();

        /// <summary>
        /// Genera un reporte en formato PDF que analiza la complejidad vs. el engagement de las recetas.
        /// </summary>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        Task<byte[]> GenerateRecipeEngagementReportAsync();
    }
}