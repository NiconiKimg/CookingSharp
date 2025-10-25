namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO para devolver información de una categoría.
/// </summary>
public class CategoryResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

/// <summary>
/// DTO para crear o actualizar una categoría.
/// </summary>
public class CategoryCreateUpdateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
}