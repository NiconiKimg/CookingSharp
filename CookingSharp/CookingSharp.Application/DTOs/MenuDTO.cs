using System.Collections.Generic;

namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO para devolver un menú, incluyendo las recetas que lo componen.
/// </summary>
public class MenuResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public string AuthorName { get; set; }
    public double AverageRating { get; set; }
    public int RatingsCount { get; set; }
    public ICollection<RecipeResponseDTO> Recipes { get; set; }
}

/// <summary>
/// DTO para crear o actualizar un menú. Solo se especifican los IDs de las recetas.
/// </summary>
public class MenuCreateUpdateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<int> RecipeIds { get; set; }
}

public class MenuSummaryDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string AuthorName { get; set; }
    public double AverageRating { get; set; }
    public int RecipeCount { get; set; }
}