using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de gestión de comentarios.
/// </summary>
public class CommentService : ICommentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Añade un nuevo comentario a una receta de forma asíncrona.
    /// </summary>
    /// <param name="recipeId">El ID de la receta a comentar.</param>
    /// <param name="commentCreateDto">El DTO con el texto del comentario.</param>
    /// <param name="authorUserId">El ID del usuario que escribe el comentario.</param>
    /// <returns>El DTO del comentario recién creado.</returns>
    /// <exception cref="NotFoundException">Se lanza si la receta o el usuario no existen.</exception>
    public async Task<CommentResponseDTO> AddCommentToRecipeAsync(int recipeId, CommentCreateDTO commentCreateDto, int authorUserId)
    {
        _ = await _unitOfWork.Recipes.GetByIdAsync(recipeId) ?? throw new NotFoundException(nameof(Recipe), recipeId);
        _ = await _unitOfWork.Users.GetByIdAsync(authorUserId) ?? throw new NotFoundException(nameof(User), authorUserId);

        var comment = new Comment(commentCreateDto.Text, authorUserId, recipeId);

        await _unitOfWork.Comments.AddAsync(comment);
        await _unitOfWork.CompleteAsync();

        var createdComment = await _unitOfWork.Comments.GetByIdAsync(comment.Id);
        return _mapper.Map<CommentResponseDTO>(createdComment);
    }

    /// <summary>
    /// Obtiene todos los comentarios para una receta específica de forma asíncrona.
    /// </summary>
    /// <param name="recipeId">El ID de la receta.</param>
    /// <returns>Una colección de DTOs de comentario.</returns>
    /// <exception cref="NotFoundException">Se lanza si la receta no existe.</exception>
    public async Task<IEnumerable<CommentResponseDTO>> GetCommentsForRecipeAsync(int recipeId)
    {
        _ = await _unitOfWork.Recipes.GetByIdAsync(recipeId) ?? throw new NotFoundException(nameof(Recipe), recipeId);

        var comments = await _unitOfWork.Comments.GetByRecipeIdWithUserAsync(recipeId);
        return _mapper.Map<IEnumerable<CommentResponseDTO>>(comments);
    }

    /// <summary>
    /// Actualiza un comentario existente de forma asíncrona.
    /// </summary>
    /// <param name="commentId">El ID del comentario a actualizar.</param>
    /// <param name="commentUpdateDto">El DTO con el nuevo texto del comentario.</param>
    /// <exception cref="NotFoundException">Se lanza si el comentario no existe.</exception>
    public async Task UpdateCommentAsync(int commentId, CommentUpdateDTO commentUpdateDto)
    {
        var comment = await _unitOfWork.Comments.GetByIdAsync(commentId) ?? throw new NotFoundException(nameof(Comment), commentId);

        comment.EditText(commentUpdateDto.Text);

        _unitOfWork.Comments.Update(comment);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Elimina un comentario por su ID de forma asíncrona.
    /// </summary>
    /// <param name="commentId">El ID del comentario a eliminar.</param>
    /// <exception cref="NotFoundException">Se lanza si el comentario no existe.</exception>
    public async Task DeleteCommentAsync(int commentId)
    {
        var comment = await _unitOfWork.Comments.GetByIdAsync(commentId) ?? throw new NotFoundException(nameof(Comment), commentId);
        _unitOfWork.Comments.Delete(comment);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Obtiene un comentario por su ID de forma asíncrona.
    /// </summary>
    /// <param name="commentId">El ID del comentario a buscar.</param>
    /// <returns>El DTO del comentario encontrado.</returns>
    /// <exception cref="NotFoundException">Se lanza si el comentario no existe.</exception>
    public async Task<CommentResponseDTO?> GetByIdAsync(int commentId)
    {
        var comment = await _unitOfWork.Comments.GetByIdAsync(commentId) ?? throw new NotFoundException(nameof(Comment), commentId);
        return _mapper.Map<CommentResponseDTO>(comment);
    }
}