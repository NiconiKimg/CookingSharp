using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de comentarios.
/// </summary>
public interface ICommentService
{
    /// <summary>
    /// Obtiene todos los comentarios para una receta específica.
    /// </summary>
    /// <param name="recipeId">El ID de la receta.</param>
    Task<IEnumerable<CommentResponseDTO>> GetCommentsForRecipeAsync(int recipeId);

    /// <summary>
    /// Añade un nuevo comentario a una receta.
    /// </summary>
    /// <param name="recipeId">El ID de la receta a comentar.</param>
    /// <param name="commentCreateDto">El DTO con el texto del comentario.</param>
    /// <param name="authorUserId">El ID del usuario que escribe el comentario.</param>
    Task<CommentResponseDTO> AddCommentToRecipeAsync(int recipeId, CommentCreateDTO commentCreateDto, int authorUserId);

    Task<CommentResponseDTO?> GetByIdAsync(int commentId);
    Task UpdateCommentAsync(int commentId, CommentUpdateDTO commentUpdateDto);
    Task DeleteCommentAsync(int commentId);
}