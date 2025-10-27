namespace CookingSharp.Application.DTOs
{
    /// <summary>
    /// DTO para transportar los datos procesados para el reporte de popularidad de recetas.
    /// </summary>
    public class RecipePopularityReportDto
    {
        public int Rank { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double WeightedScore { get; set; }
        public double SimpleAverage { get; set; }
        public int VoteCount { get; set; }
    }
}