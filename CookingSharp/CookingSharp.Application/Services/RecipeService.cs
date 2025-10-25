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
/// Implementación del servicio de gestión de recetas.
/// </summary>
public class RecipeService : IRecipeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

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
    /// <exception cref="NotFoundException">Se lanza si el usuario creador o alguna categoría no existen.</exception>
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
        var recipes = await _unitOfWork.Recipes.GetAllWithDetailsAsync();
        return _mapper.Map<IEnumerable<RecipeResponseDTO>>(recipes);
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
    /// Actualiza una receta existente de forma asíncrona.
    /// </summary>
    /// <param name="id">El ID de la receta a actualizar.</param>
    /// <param name="recipeUpdateDto">El DTO con los nuevos datos de la receta.</param>
    /// <exception cref="NotFoundException">Se lanza si la receta o alguna categoría no existen.</exception>
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
}