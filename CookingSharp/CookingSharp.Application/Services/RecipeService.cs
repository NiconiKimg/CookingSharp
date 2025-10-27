using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de gestión de recetas.
/// </summary>
public class RecipeService : IRecipeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="RecipeService"/>.
    /// </summary>
    /// <param name="unitOfWork">La unidad de trabajo para interactuar con los repositorios.</param>
    /// <param name="mapper">El mapeador de objetos para transformar entidades en DTOs.</param>
    public RecipeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    /// <summary>
    /// Crea una nueva receta de forma asíncrona.
    /// </summary>
    /// <param name="recipeCreateDto">El DTO con los datos de la nueva receta.</param>
    /// <param name="creatorUserId">El ID del usuario que está creando la receta.</param>
    /// <returns>El DTO de la receta recién creada.</returns>
    /// <exception cref="NotFoundException">Se lanza si el usuario creador no existe.</exception>
    /// <exception cref="BadRequestException">Se lanza si alguna de las categorías no existe.</exception>
    public async Task<RecipeResponseDTO> CreateAsync(RecipeCreateDTO recipeCreateDto, int creatorUserId)
    {
        _ = await _unitOfWork.Users.GetByIdAsync(creatorUserId) ?? throw new NotFoundException(nameof(User), creatorUserId);

        var recipe = new Recipe(recipeCreateDto.Name, recipeCreateDto.Description, creatorUserId);

        foreach (var stepDto in recipeCreateDto.Steps)
        {
            recipe.AddStep(stepDto.Instruction);
        }

        foreach (var categoryId in recipeCreateDto.CategoryIds)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(categoryId) ?? throw new BadRequestException($"La categoría con ID '{categoryId}' no existe.");
            recipe.Categories.Add(category);
        }

        await _unitOfWork.Recipes.AddAsync(recipe);
        await _unitOfWork.CompleteAsync();

        var createdRecipe = await _unitOfWork.Recipes.GetByIdWithDetailsAsync(recipe.Id);
        return _mapper.Map<RecipeResponseDTO>(createdRecipe);
    }

    /// <summary>
    /// Obtiene todas las recetas con sus detalles de forma asíncrona.
    /// </summary>
    /// <returns>Una colección de DTOs de receta.</returns>
    public async Task<IEnumerable<RecipeResponseDTO>> GetAllAsync()
    {
        return await GetAllAsync(null, null);
    }

    /// <summary>
    /// Obtiene todas las recetas con sus detalles de forma asíncrona, opcionalmente filtradas.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de DTOs de receta.</returns>
    public async Task<IEnumerable<RecipeResponseDTO>> GetAllAsync(string? searchTerm = null, int? categoryId = null)
    {
        var recipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync(searchTerm, categoryId);
        return _mapper.Map<IEnumerable<RecipeResponseDTO>>(recipes);
    }

    /// <summary>
    /// Obtiene una versión resumida de todas las recetas publicadas de forma asíncrona.
    /// </summary>
    /// <returns>Una colección de DTOs de resumen de receta.</returns>
    public async Task<IEnumerable<RecipeSummaryDTO>> GetAllSummariesAsync()
    {
        var recipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync();
        var publishedRecipes = recipes.Where(r => r.Status == RecipeStatus.Published);
        return _mapper.Map<IEnumerable<RecipeSummaryDTO>>(publishedRecipes);
    }

    /// <summary>
    /// Obtiene una receta por su ID con sus detalles de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la receta a buscar.</param>
    /// <returns>El DTO de la receta encontrada.</returns>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra la receta.</exception>
    public async Task<RecipeResponseDTO?> GetByIdAsync(int id)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdWithDetailsAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);
        return _mapper.Map<RecipeResponseDTO>(recipe);
    }

    /// <summary>
    /// Obtiene las recetas (en formato resumen) de un usuario específico.
    /// </summary>
    /// <param name="userId">El ID del usuario autor.</param>
    /// <returns>Una colección de DTOs de resumen de receta.</returns>
    public async Task<IEnumerable<RecipeSummaryDTO>> GetRecipesByUserIdAsync(int userId)
    {
        var recipes = await _unitOfWork.Recipes.GetByUserIdWithDetailsAsync(userId);
        return _mapper.Map<IEnumerable<RecipeSummaryDTO>>(recipes);
    }

    /// <summary>
    /// Obtiene las recetas completas (con pasos) de un usuario específico.
    /// </summary>
    /// <param name="userId">El ID del usuario autor.</param>
    /// <returns>Una colección de DTOs de receta completos.</returns>
    public async Task<IEnumerable<RecipeResponseDTO>> GetFullRecipesByUserIdAsync(int userId)
    {
        var recipes = await _unitOfWork.Recipes.GetByUserIdWithDetailsAsync(userId);
        return _mapper.Map<IEnumerable<RecipeResponseDTO>>(recipes);
    }

    /// <summary>
    /// Actualiza una receta existente de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la receta a actualizar.</param>
    /// <param name="recipeUpdateDto">El DTO con los nuevos datos de la receta.</param>
    /// <exception cref="NotFoundException">Se lanza si la receta no existe.</exception>
    public async Task UpdateAsync(int id, RecipeUpdateDTO recipeUpdateDto)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdWithDetailsAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);

        recipe.UpdateDetails(recipeUpdateDto.Name, recipeUpdateDto.Description);

        recipe.ClearSteps();
        foreach (var stepDto in recipeUpdateDto.Steps)
        {
            recipe.AddStep(stepDto.Instruction);
        }

        recipe.Categories.Clear();
        foreach (var categoryId in recipeUpdateDto.CategoryIds)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(categoryId) ?? throw new BadRequestException($"La categoría con ID '{categoryId}' no existe.");
            recipe.Categories.Add(category);
        }

        _unitOfWork.Recipes.Update(recipe);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Actualiza únicamente el estado de una receta de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la receta a actualizar.</param>
    /// <param name="statusUpdateDto">El DTO con el nuevo estado.</param>
    /// <exception cref="NotFoundException">Se lanza si la receta no existe.</exception>
    /// <exception cref="BadRequestException">Se lanza si el estado proporcionado no es válido.</exception>
    public async Task UpdateStatusAsync(int id, RecipeStatusUpdateDTO statusUpdateDto)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);

        switch (statusUpdateDto.Status.ToLower())
        {
            case "published":
                recipe.Publish();
                break;
            case "archived":
                recipe.Archive();
                break;
            case "draft":
                recipe.Unblock();
                break;
            case "blocked":
                recipe.Block();
                break;
            default:
                throw new BadRequestException("El estado proporcionado no es válido.");
        }

        _unitOfWork.Recipes.Update(recipe);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Elimina una receta por su ID de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la receta a eliminar.</param>
    /// <exception cref="NotFoundException">Se lanza si no se encuentra la receta.</exception>
    public async Task DeleteAsync(int id)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);
        _unitOfWork.Recipes.Delete(recipe);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Obtiene el número total de recetas de forma asíncrona.
    /// </summary>
    /// <returns>El número total de recetas.</returns>
    public async Task<int> GetTotalCountAsync()
    {
        return await _unitOfWork.Recipes.CountAsync();
    }

    /// <summary>
    /// Obtiene una versión resumida de todas las recetas publicadas de forma asíncrona, opcionalmente filtrada.
    /// </summary>
    /// <param name="searchTerm">Término de búsqueda opcional.</param>
    /// <param name="categoryId">ID de categoría opcional.</param>
    /// <returns>Una colección de DTOs de resumen de receta.</returns>
    public async Task<IEnumerable<RecipeSummaryDTO>> GetAllPublishedSummariesAsync(string? searchTerm = null, int? categoryId = null)
    {
        var recipes = await _unitOfWork.Recipes.GetAllPublishedWithDetailsAsync(searchTerm, categoryId);
        return _mapper.Map<IEnumerable<RecipeSummaryDTO>>(recipes);
    }
}