namespace WebApp.DTOs;
public class RecipeResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public ICollection<CategoryResponseDTO> Categories { get; set; } = new List<CategoryResponseDTO>();
}
public class RecipeCreateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<RecipeStepCreateDTO> Steps { get; set; } = new List<RecipeStepCreateDTO>();
    public ICollection<int> CategoryIds { get; set; } = new List<int>();
}
public class RecipeStepCreateDTO
{
    public string Instruction { get; set; }
}