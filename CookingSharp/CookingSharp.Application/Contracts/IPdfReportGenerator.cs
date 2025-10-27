using CookingSharp.Application.DTOs;
using System.Collections.Generic;

namespace CookingSharp.Application.Contracts
{
    /// <summary>
    /// Define el contrato para un servicio de infraestructura que genera reportes en formato PDF.
    /// </summary>
    public interface IPdfReportGenerator
    {
        /// <summary>
        /// Genera un reporte de popularidad de recetas.
        /// </summary>
        /// <param name="data">Los datos procesados del ranking de recetas.</param>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        byte[] GeneratePopularityReport(IEnumerable<RecipePopularityReportDto> data);

        /// <summary>
        /// Genera un reporte de contribución de recetas por chef.
        /// </summary>
        /// <param name="data">Los datos procesados de la contribución por chef.</param>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        byte[] GenerateChefContributionReport(IEnumerable<ChefContributionReportDto> data);

        /// <summary>
        /// Genera un reporte de análisis de engagement vs. complejidad de recetas.
        /// </summary>
        /// <param name="data">Los datos procesados del análisis de recetas.</param>
        /// <returns>Un array de bytes que representa el archivo PDF.</returns>
        byte[] GenerateRecipeEngagementReport(IEnumerable<RecipeEngagementReportDto> data);

        byte[] GenerateCategoryPerformanceReport(IEnumerable<CategoryPerformanceDto> data);
    }
}