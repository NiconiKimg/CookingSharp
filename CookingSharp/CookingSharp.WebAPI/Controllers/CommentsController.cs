using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

[Authorize]
[Route("api/recipes/{recipeId}/[controller]")]
public class CommentsController : BaseApiController
{
    private readonly ICommentService _commentService;

    public CommentsController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    #region --- GET Endpoints ---

    /// <summary>
    /// Obtiene todos los comentarios de una receta específica.
    /// </summary>
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetCommentsForRecipe(int recipeId)
    {
        var comments = await _commentService.GetCommentsForRecipeAsync(recipeId);
        return Ok(comments);
    }

    #endregion

    #region --- POST Endpoints ---

    /// <summary>
    /// Añade un nuevo comentario a una receta (cualquier usuario autenticado).
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> AddComment(int recipeId, CommentCreateDTO commentCreateDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var createdComment = await _commentService.AddCommentToRecipeAsync(recipeId, commentCreateDto, userId);
        return Ok(createdComment);
    }

    #endregion

    #region --- PUT/DELETE Endpoints ---

    /// <summary>
    /// Actualiza un comentario existente (solo para el autor o un Admin).
    /// </summary>
    [HttpPut("{commentId}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> UpdateComment(int recipeId, int commentId, CommentUpdateDTO commentUpdateDto)
    {
        var comment = await _commentService.GetByIdAsync(commentId);
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        if (comment.AuthorId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid(); // 403 Forbidden
        }

        await _commentService.UpdateCommentAsync(commentId, commentUpdateDto);
        return NoContent();
    }

    /// <summary>
    /// Elimina un comentario (solo para el autor o un Admin).
    /// </summary>
    [HttpDelete("{commentId}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> DeleteComment(int recipeId, int commentId)
    {
        var comment = await _commentService.GetByIdAsync(commentId);
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        if (comment.AuthorId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid();
        }

        await _commentService.DeleteCommentAsync(commentId);
        return NoContent();
    }

    #endregion
}