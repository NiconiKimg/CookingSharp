using AutoMapper;
using CookingSharp.Application.Common.Exceptions;
using CookingSharp.Application.Contracts;
using CookingSharp.Application.Contracts.Infrastructure;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using CookingSharp.Domain.Entities;
using CookingSharp.Domain.Enums;


// Se eliminan los 'usings' a la capa de Infrastructure
// using CookingSharp.Infrastructure;
// using Microsoft.Extensions.Options;

namespace CookingSharp.Application.Services;

/// <summary>
/// Implementación del servicio de gestión de recetas.
/// </summary>
public class RecipeService : IRecipeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IPhotoService _photoService;
    // Se elimina el campo: private readonly CloudinarySettings _cloudinarySettings;

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="RecipeService"/>.
    /// </summary>
    /// <param name="unitOfWork">La unidad de trabajo para interactuar con los repositorios.</param>
    /// <param name="mapper">El mapeador de objetos para transformar entidades en DTOs.</param>
    /// <param name="photoService">El servicio para gestionar la subida de imágenes.</param>
    public RecipeService(IUnitOfWork unitOfWork, IMapper mapper, IPhotoService photoService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _photoService = photoService;
    }

    /// <summary>
    /// Crea una nueva receta de forma asíncrona (sin imagen).
    /// </summary>
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
    public async Task<IEnumerable<RecipeResponseDTO>> GetAllAsync()
    {
        return await GetAllAsync(null, null);
    }

    /// <summary>
    /// Obtiene todas las recetas con sus detalles de forma asíncrona, opcionalmente filtradas.
    /// </summary>
    public async Task<IEnumerable<RecipeResponseDTO>> GetAllAsync(string? searchTerm = null, int? categoryId = null)
    {
        var recipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync(searchTerm, categoryId);
        return _mapper.Map<IEnumerable<RecipeResponseDTO>>(recipes);
    }

    /// <summary>
    /// Obtiene una versión resumida de todas las recetas publicadas de forma asíncrona.
    /// </summary>
    public async Task<IEnumerable<RecipeSummaryDTO>> GetAllSummariesAsync()
    {
        var recipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync();
        var publishedRecipes = recipes.Where(r => r.Status == RecipeStatus.Published);
        return _mapper.Map<IEnumerable<RecipeSummaryDTO>>(publishedRecipes);
    }

    /// <summary>
    /// Obtiene una receta por su ID con sus detalles de forma asíncrona.
    /// </summary>
    public async Task<RecipeResponseDTO?> GetByIdAsync(int id)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdWithDetailsAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);
        return _mapper.Map<RecipeResponseDTO>(recipe);
    }

    /// <summary>
    /// Obtiene las recetas (en formato resumen) de un usuario específico.
    /// </summary>
    public async Task<IEnumerable<RecipeSummaryDTO>> GetRecipesByUserIdAsync(int userId)
    {
        var recipes = await _unitOfWork.Recipes.GetByUserIdWithDetailsAsync(userId);
        return _mapper.Map<IEnumerable<RecipeSummaryDTO>>(recipes);
    }

    /// <summary>
    /// Obtiene las recetas completas (con pasos) de un usuario específico.
    /// </summary>
    public async Task<IEnumerable<RecipeResponseDTO>> GetFullRecipesByUserIdAsync(int userId)
    {
        var recipes = await _unitOfWork.Recipes.GetByUserIdWithDetailsAsync(userId);
        return _mapper.Map<IEnumerable<RecipeResponseDTO>>(recipes);
    }

    /// <summary>
    /// Actualiza una receta existente de forma asíncrona.
    /// </summary>
    public async Task UpdateAsync(int id, RecipeUpdateDTO recipeUpdateDto)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdWithDetailsAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);

        if (recipeUpdateDto.Image != null)
        {
            if (!string.IsNullOrEmpty(recipe.ImagePublicId) && recipe.ImagePublicId != _photoService.GetDefaultImage().PublicId)
            {
                await _photoService.DeletePhotoAsync(recipe.ImagePublicId);
            }
            var (imageUrl, publicId) = await _photoService.AddPhotoAsync(recipeUpdateDto.Image);
            recipe.SetImage(imageUrl, publicId);
        }

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
    public async Task DeleteAsync(int id)
    {
        var recipe = await _unitOfWork.Recipes.GetByIdAsync(id) ?? throw new NotFoundException(nameof(Recipe), id);

        if (!string.IsNullOrEmpty(recipe.ImagePublicId) && recipe.ImagePublicId != _photoService.GetDefaultImage().PublicId)
        {
            await _photoService.DeletePhotoAsync(recipe.ImagePublicId);
        }

        _unitOfWork.Recipes.Delete(recipe);
        await _unitOfWork.CompleteAsync();
    }

    /// <summary>
    /// Obtiene el número total de recetas de forma asíncrona.
    /// </summary>
    public async Task<int> GetTotalCountAsync()
    {
        return await _unitOfWork.Recipes.CountAsync();
    }

    /// <summary>
    /// Obtiene una versión resumida de todas las recetas publicadas de forma asíncrona, opcionalmente filtrada.
    /// </summary>
    public async Task<IEnumerable<RecipeSummaryDTO>> GetAllPublishedSummariesAsync(string? searchTerm = null, int? categoryId = null)
    {
        var recipes = await _unitOfWork.Recipes.GetAllPublishedWithDetailsAsync(searchTerm, categoryId);
        return _mapper.Map<IEnumerable<RecipeSummaryDTO>>(recipes);
    }

    /// <summary>
    /// Crea una nueva receta con una imagen de forma asíncrona. Si no se proporciona imagen, se asigna una por defecto.
    /// </summary>
    public async Task<RecipeResponseDTO> CreateWithImageAsync(RecipeCreateDTO dto, int userId)
    {
        _ = await _unitOfWork.Users.GetByIdAsync(userId) ?? throw new NotFoundException(nameof(User), userId);

        var recipe = new Recipe(dto.Name, dto.Description, userId);

        if (dto.Image != null && dto.Image.Length > 0)
        {
            var (imageUrl, publicId) = await _photoService.AddPhotoAsync(dto.Image);
            recipe.SetImage(imageUrl, publicId);
        }
        else
        {
            var (imageUrl, publicId) = _photoService.GetDefaultImage();
            recipe.SetImage(imageUrl, publicId);
        }

        foreach (var stepDto in dto.Steps)
        {
            recipe.AddStep(stepDto.Instruction);
        }

        foreach (var categoryId in dto.CategoryIds)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(categoryId) ?? throw new BadRequestException($"La categoría con ID '{categoryId}' no existe.");
            recipe.Categories.Add(category);
        }

        await _unitOfWork.Recipes.AddAsync(recipe);
        await _unitOfWork.CompleteAsync();

        var createdRecipe = await _unitOfWork.Recipes.GetByIdWithDetailsAsync(recipe.Id);
        return _mapper.Map<RecipeResponseDTO>(createdRecipe);
    }
}