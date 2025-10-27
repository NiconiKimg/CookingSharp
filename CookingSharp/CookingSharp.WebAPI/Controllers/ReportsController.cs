using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers
{
    /// <summary>
    /// Controlador para la generación de reportes en formato PDF.
    /// </summary>
    [Authorize(Roles = "Admin")]
    [Route("api/reports")]
    public class ReportsController : BaseApiController
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        /// <summary>
        /// Genera y devuelve el reporte de popularidad de recetas en formato PDF.
        /// </summary>
        /// <returns>Un archivo PDF.</returns>
        [HttpGet("popularity/recipes")]
        [ProducesResponseType(typeof(FileContentResult), 200)]
        [ProducesResponseType(204)] // No Content
        public async Task<IActionResult> GetPopularityReport()
        {
            try
            {
                byte[] pdfBytes = await _reportService.GenerateTopRatedRecipesReportAsync();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    return NoContent();
                }

                string fileName = $"Reporte_Popularidad_Recetas_{DateTime.Now:yyyyMMdd}.pdf";
                return File(pdfBytes, "application/pdf", fileName);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno al generar el reporte.");
            }
        }

        /// <summary>
        /// Genera y devuelve el reporte de contribución de chefs en formato PDF.
        /// </summary>
        /// <returns>Un archivo PDF.</returns>
        [HttpGet("contribution/chefs")]
        [ProducesResponseType(typeof(FileContentResult), 200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> GetChefContributionReport()
        {
            try
            {
                byte[] pdfBytes = await _reportService.GenerateChefContributionReportAsync();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    return NoContent();
                }

                string fileName = $"Reporte_Contribucion_Chefs_{DateTime.Now:yyyyMMdd}.pdf";
                return File(pdfBytes, "application/pdf", fileName);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno al generar el reporte.");
            }
        }

        /// <summary>
        /// Genera y devuelve el reporte de análisis de engagement de recetas en formato PDF.
        /// </summary>
        /// <returns>Un archivo PDF.</returns>
        [HttpGet("analysis/engagement")]
        [ProducesResponseType(typeof(FileContentResult), 200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> GetRecipeEngagementReport()
        {
            try
            {
                byte[] pdfBytes = await _reportService.GenerateRecipeEngagementReportAsync();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    return NoContent();
                }

                string fileName = $"Reporte_Analisis_Engagement_{DateTime.Now:yyyyMMdd}.pdf";
                return File(pdfBytes, "application/pdf", fileName);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno al generar el reporte.");
            }
        }

        /// <summary>
        /// Genera y devuelve el reporte de rendimiento por categoría en formato PDF.
        /// </summary>
        /// <returns>Un archivo PDF.</returns>
        [HttpGet("performance/categories")]
        [ProducesResponseType(typeof(FileContentResult), 200)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> GetCategoryPerformanceReport()
        {
            try
            {
                byte[] pdfBytes = await _reportService.GenerateCategoryPerformanceReportAsync();

                if (pdfBytes == null || pdfBytes.Length == 0)
                {
                    return NoContent();
                }

                string fileName = $"Reporte_Rendimiento_Categorias_{DateTime.Now:yyyyMMdd}.pdf";
                return File(pdfBytes, "application/pdf", fileName);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno al generar el reporte.");
            }
        }
    }
}