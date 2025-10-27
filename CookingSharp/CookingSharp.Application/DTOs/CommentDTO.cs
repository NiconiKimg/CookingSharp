using System;

namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO para devolver un comentario, incluyendo el nombre del autor.
/// </summary>
public class CommentResponseDTO
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public DateTime CreatedAt { get; set; }
}

/// <summary>
/// DTO para crear un nuevo comentario.
/// </summary>
public class CommentCreateDTO
{
    public string Text { get; set; }
}

/// <summary>
/// DTO para actualizar un comentario existente.
/// </summary>
public class CommentUpdateDTO
{
    public string Text { get; set; }
}