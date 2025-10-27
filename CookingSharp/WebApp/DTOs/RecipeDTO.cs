using Microsoft.AspNetCore.Http;

namespace WebApp.DTOs
{
    // -------------------------------------------------------------------
    //  DTOs para RECIBIR datos de la API (para mostrar en el formulario)
    // -------------------------------------------------------------------

    /// <summary>
    /// DTO para recibir los detalles completos de UNA receta. Incluye los pasos.
    /// Usado en la página de edición para poblar el formulario.
    /// </summary>
    public class RecipeResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public ICollection<RecipeStepResponseDTO> Steps { get; set; } = new List<RecipeStepResponseDTO>();
        public ICollection<CategoryResponseDTO> Categories { get; set; } = new List<CategoryResponseDTO>();
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
        public string ImageUrl { get; set; }
    }

    /// <summary>
    /// DTO para recibir los detalles de un paso de una receta.s
    /// </summary>
    public class RecipeStepResponseDTO
    {
        public int StepNumber { get; set; }
        public string Instruction { get; set; } = string.Empty;
    }


    // -------------------------------------------------------------------
    //     DTOs para ENVIAR datos a la API (para actualizar la receta)
    // -------------------------------------------------------------------

    /// <summary>
    /// DTO para enviar las actualizaciones de una receta a la API (PUT).
    /// </summary>
    public class RecipeUpdateDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<RecipeStepCreateDTO> Steps { get; set; } = new List<RecipeStepCreateDTO>();
        public ICollection<int> CategoryIds { get; set; } = new List<int>();
        public IFormFile? Image { get; set; }
    }

    /// <summary>
    /// DTO para enviar la instrucción de un paso nuevo o modificado.
    /// Reutilizamos el DTO de creación porque tiene la misma estructura.
    /// </summary>
    public class RecipeStepCreateDTO
    {
        public string Instruction { get; set; } = string.Empty;
    }

    // -------------------------------------------------------------------
    //         DTOs Adicionales (ya deberían estar en tu proyecto)
    // -------------------------------------------------------------------

    /// <summary>
    /// DTO ligero para listas (usado en la página principal y "Mis Recetas").
    /// </summary>
    public class RecipeSummaryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public ICollection<CategoryResponseDTO> Categories { get; set; } = new List<CategoryResponseDTO>();
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
        public string ImageUrl { get; set; }
    }

    /// <summary>
    /// DTO para crear una nueva receta (usado por CreateRecipe.razor).
    /// </summary>
    public class RecipeCreateDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<RecipeStepCreateDTO> Steps { get; set; } = new List<RecipeStepCreateDTO>();
        public ICollection<int> CategoryIds { get; set; } = new List<int>();
        public IFormFile? Image { get; set; }

    }
}