namespace CookingSharp.Application.DTOs
{
    /// <summary>
    /// DTO para transportar los datos de rendimiento agregados para una categoría.
    /// </summary>
    public class CategoryPerformanceDto
    {
        public string CategoryName { get; set; }
        public int RecipeCount { get; set; }
        public double AverageRating { get; set; }
        public int TotalRatings { get; set; }
        public int TotalComments { get; set; }
    }
}