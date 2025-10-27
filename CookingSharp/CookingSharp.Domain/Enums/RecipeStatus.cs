namespace CookingSharp.Domain.Enums;

/// <summary>
/// Estados del ciclo de vida de una receta.
/// </summary>
public enum RecipeStatus
{
    /// <summary>
    /// La receta está en borrador y no es visible públicamente.
    /// </summary>
    Draft,

    /// <summary>
    /// La receta ha sido publicada y es visible para todos.
    /// </summary>
    Published,

    /// <summary>
    /// La receta ha sido archivada por el autor.
    /// </summary>
    Archived,

    /// <summary>
    /// La receta ha sido bloqueada por un administrador.
    /// </summary>
    Blocked
}