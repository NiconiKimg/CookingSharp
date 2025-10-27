using CookingSharp.Application.DTOs;

public class HomePageDTO
{
    public List<RecipeSummaryDTO> TopRatedRecipes { get; set; } = new();
    public List<MenuSummaryDTO> TopRatedMenus { get; set; } = new();
}