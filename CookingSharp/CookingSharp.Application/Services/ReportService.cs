using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        /// Genera un reporte PDF de las recetas mejor valoradas.
        /// </summary>
        /// <returns>Array de bytes del PDF generado.</returns>
        public async Task<byte[]> GenerateTopRatedRecipesReportAsync()
        {
            var reportData = await GetTopRatedRecipesDataAsync(10);
            return _pdfGenerator.GeneratePopularityReport(reportData);
        }

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
        /// Genera un reporte PDF de la contribución de chefs.
        /// </summary>
        /// <returns>Array de bytes del PDF generado.</returns>
        public async Task<byte[]> GenerateChefContributionReportAsync()
        {
            var reportData = await GetChefContributionDataAsync();
            return _pdfGenerator.GenerateChefContributionReport(reportData);
        }

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

            return reportData.Select((data, index) => new ChefContributionReportDto
            {
                Rank = index + 1,
                ChefName = data.ChefName,
                PublishedRecipesCount = data.PublishedRecipesCount
            });
        }

        /// <summary>
        /// Genera un reporte PDF de engagement vs. complejidad de recetas.
        /// </summary>
        /// <returns>Array de bytes del PDF generado.</returns>
        public async Task<byte[]> GenerateRecipeEngagementReportAsync()
        {
            var rawData = (await _unitOfWork.RecipeAnalysis.GetRecipeAnalysisDataAsync()).ToList();

            if (!rawData.Any() || rawData.Sum(d => d.VoteCount) == 0)
            {
                return _pdfGenerator.GenerateRecipeEngagementReport(Enumerable.Empty<RecipeEngagementReportDto>());
            }

            const int minVotesRequired = 2;
            var globalAverageRating = rawData.Sum(d => d.AverageRating * d.VoteCount) / rawData.Sum(d => d.VoteCount);

            var reportData = rawData
                .Select(d => new RecipeEngagementReportDto
                {
                    RecipeId = d.RecipeId,
                    RecipeName = d.RecipeName,
                    AuthorName = d.AuthorName,
                    StepCount = d.StepCount,
                    CommentCount = d.CommentCount,
                    SimpleAverageRating = d.AverageRating,
                    VoteCount = d.VoteCount,
                    WeightedAverageRating = d.VoteCount >= minVotesRequired
                        ? ((double)d.VoteCount / (d.VoteCount + minVotesRequired) * d.AverageRating) +
                          ((double)minVotesRequired / (d.VoteCount + minVotesRequired) * globalAverageRating)
                        : globalAverageRating
                }).ToList();

            return _pdfGenerator.GenerateRecipeEngagementReport(reportData);
        }

        /// <summary>
        /// Genera un reporte PDF de rendimiento por categoría.
        /// </summary>
        /// <returns>Array de bytes del PDF generado.</returns>
        public async Task<byte[]> GenerateCategoryPerformanceReportAsync()
        {
            var performanceData = await _unitOfWork.CategoryPerformance.GetCategoryPerformanceDataAsync();
            return _pdfGenerator.GenerateCategoryPerformanceReport(performanceData);
        }
    }
}