using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CookingSharp.Infrastructure.Persistence.Repositories
{
    /// <summary>
    /// Repositorio para realizar análisis complejos de recetas utilizando ADO.NET para un rendimiento óptimo.
    /// </summary>
    public class RecipeAnalysisRepository : IRecipeAnalysisRepository
    {
        private readonly string _connectionString;

        public RecipeAnalysisRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Ejecuta una consulta SQL compleja para recopilar datos agregados sobre recetas,
        /// incluyendo el recuento de pasos, comentarios, la valoración media y el número de votos.
        /// </summary>
        /// <returns>Una colección de DTOs con los datos de análisis de recetas.</returns>
        public async Task<IEnumerable<RecipeAnalysisDataDto>> GetRecipeAnalysisDataAsync()
        {
            var analysisDataList = new List<RecipeAnalysisDataDto>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                const string sql = @"
                    SELECT 
                        r.Id AS RecipeId,
                        r.Name AS RecipeName,
                        u.Name + ' ' + u.Surname AS AuthorName,
                        ISNULL(steps.StepCount, 0) AS StepCount,
                        ISNULL(comments.CommentCount, 0) AS CommentCount,
                        ISNULL(ratings.AverageRating, 0) AS AverageRating,
                        ISNULL(ratings.VoteCount, 0) AS VoteCount
                    FROM 
                        Recipes r
                    JOIN 
                        Users u ON r.UserId = u.Id
                    LEFT JOIN 
                        (SELECT RecipeId, COUNT(*) AS StepCount FROM RecipeSteps GROUP BY RecipeId) AS steps 
                        ON r.Id = steps.RecipeId
                    LEFT JOIN 
                        (SELECT RecipeId, COUNT(*) AS CommentCount FROM Comments GROUP BY RecipeId) AS comments 
                        ON r.Id = comments.RecipeId
                    LEFT JOIN 
                        (SELECT RecipeId, AVG(CAST(Stars AS FLOAT)) AS AverageRating, COUNT(*) as VoteCount FROM RecipeRatings GROUP BY RecipeId) AS ratings 
                        ON r.Id = ratings.RecipeId
                    WHERE
                        r.Status = 1; -- 1 corresponde al valor del enum 'Published'
                ";

                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            analysisDataList.Add(new RecipeAnalysisDataDto
                            {
                                RecipeId = reader.GetInt32(reader.GetOrdinal("RecipeId")),
                                RecipeName = reader.GetString(reader.GetOrdinal("RecipeName")),
                                AuthorName = reader.GetString(reader.GetOrdinal("AuthorName")),
                                StepCount = reader.GetInt32(reader.GetOrdinal("StepCount")),
                                CommentCount = reader.GetInt32(reader.GetOrdinal("CommentCount")),
                                AverageRating = reader.GetDouble(reader.GetOrdinal("AverageRating")),
                                VoteCount = reader.GetInt32(reader.GetOrdinal("VoteCount"))
                            });
                        }
                    }
                }
            }
            return analysisDataList;
        }
    }
}