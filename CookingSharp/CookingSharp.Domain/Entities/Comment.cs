using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa un comentario hecho por un usuario en una receta.
/// </summary>
public class Comment
{
    /// <summary>
    /// Identificador único del comentario.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Contenido textual del comentario.
    /// </summary>
    public string Text { get; private set; }

    /// <summary>
    /// Fecha y hora (UTC) en que se creó el comentario.
    /// </summary>
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// Clave foránea del usuario que hizo el comentario.
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Clave foránea de la receta comentada.
    /// </summary>
    public int RecipeId { get; private set; }
    public User User { get; private set; }
    public Recipe Recipe { get; private set; }

    private Comment() { }

    /// <summary>
    /// Constructor para crear un nuevo comentario válido.
    /// </summary>
    /// <param name="text">El texto del comentario.</param>
    /// <param name="userId">ID del usuario que comenta.</param>
    /// <param name="recipeId">ID de la receta comentada.</param>
    public Comment(string text, int userId, int recipeId)
    {
        EditText(text);

        if (userId <= 0)
            throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));
        if (recipeId <= 0)
            throw new ArgumentException("El ID de receta debe ser un valor positivo.", nameof(recipeId));

        UserId = userId;
        RecipeId = recipeId;
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Permite editar el texto de un comentario.
    /// </summary>
    public void EditText(string newText)
    {
        if (string.IsNullOrWhiteSpace(newText))
            throw new ArgumentException("El texto del comentario no puede estar vacío.", nameof(newText));

        Text = newText;
    }
}