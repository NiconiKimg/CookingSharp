using System.Collections.Generic;

namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO ligero para mostrar un resumen de la receta en listas. No incluye pasos.
/// </summary>
public class RecipeSummaryDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public ICollection<CategoryResponseDTO> Categories { get; set; }
}

/// <summary>
/// DTO completo para devolver una receta, incluyendo sus pasos y categorías.
/// </summary>
public class RecipeResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public ICollection<RecipeStepResponseDTO> Steps { get; set; }
    public ICollection<CategoryResponseDTO> Categories { get; set; }
}

/// <summary>
/// DTO para crear una nueva receta.
/// </summary>
public class RecipeCreateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<RecipeStepCreateDTO> Steps { get; set; }
    public ICollection<int> CategoryIds { get; set; }
}

/// <summary>
/// DTO para actualizar una receta existente.
/// </summary>
public class RecipeUpdateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<RecipeStepCreateDTO> Steps { get; set; }
    public ICollection<int> CategoryIds { get; set; }
}

/// <summary>
/// DTO para actualizar el estado de una receta.
/// </summary>
public class RecipeStatusUpdateDTO
{
    public string Status { get; set; }
}

/// <summary>
/// DTO para crear un paso dentro de una receta.
/// </summary>
public class RecipeStepCreateDTO
{
    public string Instruction { get; set; }
}

/// <summary>
/// DTO para devolver la información de un paso de receta.
/// </summary>
public class RecipeStepResponseDTO
{
    public int StepNumber { get; set; }
    public string Instruction { get; set; }
}