namespace CookingSharp.Application.DTOs
{
    /// <summary>
    /// DTO para transportar los datos del reporte de contribución por chef.
    /// </summary>
    public class ChefContributionReportDto
    {
        public int Rank { get; set; }
        public string ChefName { get; set; }
        public int PublishedRecipesCount { get; set; }
    }
}