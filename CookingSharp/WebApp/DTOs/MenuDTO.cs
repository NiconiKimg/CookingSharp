namespace WebApp.DTOs
{
    public class MenuResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int UserId { get; set; }
        public ICollection<RecipeSummaryDTO> Recipes { get; set; } = new List<RecipeSummaryDTO>();
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
        public string AuthorName { get; set; } = string.Empty;
    }

    public class MenuCreateUpdateDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<int> RecipeIds { get; set; } = new List<int>();
    }
}