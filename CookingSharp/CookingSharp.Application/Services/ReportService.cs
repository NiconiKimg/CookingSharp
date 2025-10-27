using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Enums;
using CookingSharp.Domain.Entities;

namespace CookingSharp.Application.Services
{
    /// <summary>
    /// Implementación del servicio para generar reportes.
    /// </summary>
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPdfReportGenerator _pdfGenerator;

        public ReportService(IUnitOfWork unitOfWork, IPdfReportGenerator pdfGenerator)
        {
            _unitOfWork = unitOfWork;
            _pdfGenerator = pdfGenerator;
        }

        /// <summary>
        /// Orquesta la generación del reporte de popularidad de recetas.
        /// </summary>
        public async Task<byte[]> GenerateTopRatedRecipesReportAsync()
        {
            var reportData = await GetTopRatedRecipesDataAsync(10);
            return _pdfGenerator.GeneratePopularityReport(reportData);
        }

        /// <summary>
        /// Obtiene y calcula los datos para el reporte de ranking de popularidad de recetas.
        /// </summary>
        private async Task<IEnumerable<RecipePopularityReportDto>> GetTopRatedRecipesDataAsync(int top)
        {
            const int minVotesRequired = 2;
            var allRecipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync();
            var publishedRecipes = allRecipes.Where(r => r.Status == RecipeStatus.Published);

            var allRatings = publishedRecipes.SelectMany(r => r.Ratings).ToList();
            if (!allRatings.Any())
            {
                return Enumerable.Empty<RecipePopularityReportDto>();
            }

            var globalAverageRating = allRatings.Average(r => r.Stars);

            var rankedRecipes = publishedRecipes
                .Where(r => r.Ratings.Count >= minVotesRequired)
                .Select(r => new
                {
                    Recipe = r,
                    SimpleAverage = r.Ratings.Average(rating => rating.Stars),
                    VoteCount = r.Ratings.Count
                })
                .Select(r => new
                {
                    r.Recipe,
                    r.SimpleAverage,
                    r.VoteCount,
                    WeightedScore = (double)r.VoteCount / (r.VoteCount + minVotesRequired) * r.SimpleAverage +
                                    (double)minVotesRequired / (r.VoteCount + minVotesRequired) * globalAverageRating
                })
                .OrderByDescending(r => r.WeightedScore)
                .Take(top)
                .ToList();

            return rankedRecipes.Select((r, index) => new RecipePopularityReportDto
            {
                Rank = index + 1,
                Title = r.Recipe.Name,
                Author = $"{r.Recipe.User.Name} {r.Recipe.User.Surname}",
                WeightedScore = r.WeightedScore,
                SimpleAverage = r.SimpleAverage,
                VoteCount = r.VoteCount
            });
        }

        /// <summary>
        /// Orquesta la generación del reporte de contribución por chef.
        /// </summary>
        public async Task<byte[]> GenerateChefContributionReportAsync()
        {
            // 1. Obtener los datos procesados.
            var reportData = await GetChefContributionDataAsync();

            // 2. Delegar la creación del PDF a la capa de infraestructura.
            return _pdfGenerator.GenerateChefContributionReport(reportData);
        }

        /// <summary>
        /// Obtiene y calcula los datos para el reporte de contribución por chef.
        /// </summary>
        private async Task<IEnumerable<ChefContributionReportDto>> GetChefContributionDataAsync()
        {
            var allUsers = await _unitOfWork.Users.GetAllAsync();
            var chefs = allUsers.Where(u => u.Role == UserRole.Chef).ToList();

            var allRecipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync();

            var reportData = chefs.Select(chef => new
            {
                ChefName = $"{chef.Name} {chef.Surname}",
                PublishedRecipesCount = allRecipes.Count(r => r.UserId == chef.Id && r.Status == RecipeStatus.Published)
            })
            .OrderByDescending(data => data.PublishedRecipesCount)
            .ToList();

            // Añadir el ranking después de ordenar
            return reportData.Select((data, index) => new ChefContributionReportDto
            {
                Rank = index + 1,
                ChefName = data.ChefName,
                PublishedRecipesCount = data.PublishedRecipesCount
            });
        }
    }
}
