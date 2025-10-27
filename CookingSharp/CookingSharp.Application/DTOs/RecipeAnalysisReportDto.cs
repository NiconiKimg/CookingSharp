namespace CookingSharp.Application.DTOs
{
    /// <summary>
    /// DTO para contener los datos de análisis agregados para una receta,
    /// recuperados directamente desde la base de datos con ADO.NET.
    /// </summary>
    public class RecipeAnalysisDataDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string AuthorName { get; set; }
        public int StepCount { get; set; }
        public int CommentCount { get; set; }
        public double AverageRating { get; set; }
        public int VoteCount { get; set; }
    }

    /// <summary>
    /// DTO para transportar los datos procesados y calculados para el informe de engagement vs. complejidad de la receta.
    /// </summary>
    public class RecipeEngagementReportDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string AuthorName { get; set; }
        public int StepCount { get; set; }
        public int CommentCount { get; set; }
        public double SimpleAverageRating { get; set; }
        public double WeightedAverageRating { get; set; }
        public int VoteCount { get; set; }
    }
}