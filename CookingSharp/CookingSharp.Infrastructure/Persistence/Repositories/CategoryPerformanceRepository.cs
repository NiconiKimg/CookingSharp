using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Repositorio para obtener datos de rendimiento de categorías usando ADO.NET.
    /// </summary>
    public class CategoryPerformanceRepository : ICategoryPerformanceRepository
    {
        private readonly string _connectionString;

        public CategoryPerformanceRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Obtiene datos de rendimiento agregados para todas las categorías.
        /// </summary>
        public async Task<IEnumerable<CategoryPerformanceDto>> GetCategoryPerformanceDataAsync()
        {
            var results = new List<CategoryPerformanceDto>();
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                const string sql = @"
                    SELECT 
                        c.Name AS CategoryName,
                        COUNT(DISTINCT r.Id) AS RecipeCount,
                        ISNULL(AVG(CAST(rr.Stars AS FLOAT)), 0) AS AverageRating,
                        COUNT(DISTINCT rr.Id) AS TotalRatings,
                        COUNT(DISTINCT co.Id) AS TotalComments
                    FROM Categories c
                    LEFT JOIN CategoryRecipe cr ON c.Id = cr.CategoriesId
                    LEFT JOIN Recipes r ON cr.RecipesId = r.Id AND r.Status = 1 -- Solo recetas publicadas
                    LEFT JOIN RecipeRatings rr ON r.Id = rr.RecipeId
                    LEFT JOIN Comments co ON r.Id = co.RecipeId
                    GROUP BY c.Name
                    ORDER BY RecipeCount DESC, AverageRating DESC;
                ";

                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            results.Add(new CategoryPerformanceDto
                            {
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                RecipeCount = reader.GetInt32(reader.GetOrdinal("RecipeCount")),
                                AverageRating = reader.GetDouble(reader.GetOrdinal("AverageRating")),
                                TotalRatings = reader.GetInt32(reader.GetOrdinal("TotalRatings")),
                                TotalComments = reader.GetInt32(reader.GetOrdinal("TotalComments"))
                            });
                        }
                    }
                }
            }
            return results;
        }
    }
}