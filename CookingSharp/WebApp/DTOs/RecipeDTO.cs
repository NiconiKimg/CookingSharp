namespace WebApp.DTOs;
public class RecipeResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public ICollection<CategoryResponseDTO> Categories { get; set; } = new List<CategoryResponseDTO>();
}
public class CategoryResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}