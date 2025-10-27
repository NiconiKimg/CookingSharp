using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

[Authorize]
public class RecipesController : BaseApiController
{
    private readonly IRecipeService _recipeService;

    public RecipesController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    #region --- GET Endpoints ---

    /// <summary>
    /// Obtiene una lista de todas las recetas, opcionalmente filtrada (público).
    /// </summary>
    /// <param name="search">Término de búsqueda para filtrar por nombre, descripción o autor.</param>
    /// <param name="categoryId">ID de la categoría para filtrar las recetas.</param>
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? search = null, [FromQuery] int? categoryId = null)
    {
        var recipes = await _recipeService.GetAllAsync(search, categoryId);
        return Ok(recipes);
    }

    /// <summary>
    /// Obtiene un resumen de todas las recetas publicadas, opcionalmente filtradas (endpoint público).
    /// </summary>
    /// <param name="search">Término de búsqueda para filtrar por nombre, descripción o autor.</param>
    /// <param name="categoryId">ID de la categoría para filtrar las recetas.</param>
    [AllowAnonymous]
    [HttpGet("summaries")]
    public async Task<IActionResult> GetAllSummaries([FromQuery] string? search = null, [FromQuery] int? categoryId = null)
    {
        var recipeSummaries = await _recipeService.GetAllPublishedSummariesAsync(search, categoryId);
        return Ok(recipeSummaries);
    }


    /// <summary>
    /// Obtiene una receta específica por su ID (público).
    /// </summary>
    [AllowAnonymous]
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var recipe = await _recipeService.GetByIdAsync(id);
        return Ok(recipe);
    }

    /// <summary>
    /// Obtiene todas las recetas creadas por el usuario autenticado.
    /// </summary>
    [HttpGet("my-recipes")]
    [Authorize(Roles = "Chef,Admin")]
    public async Task<IActionResult> GetMyRecipes()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var recipes = await _recipeService.GetRecipesByUserIdAsync(userId);
        return Ok(recipes);
    }

    /// <summary>
    /// Obtiene el número total de recetas en el sistema.
    /// </summary>
    [HttpGet("count")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> GetCount()
    {
        var count = await _recipeService.GetTotalCountAsync();
        return Ok(count);
    }

    /// <summary>
    /// Obtiene todas las recetas completas (con pasos) creadas por el usuario autenticado.
    /// </summary>
    [HttpGet("my-full-recipes")]
    [Authorize(Roles = "Chef,Admin")]
    public async Task<IActionResult> GetMyFullRecipes()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var recipes = await _recipeService.GetFullRecipesByUserIdAsync(userId);
        return Ok(recipes);
    }

    #endregion

    #region --- POST Endpoints ---

    /// <summary>
    /// Crea una nueva receta (solo para Chefs y Admins).
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Chef,Admin")]
    public async Task<IActionResult> Create([FromForm] RecipeCreateDTO recipeCreateDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var createdRecipe = await _recipeService.CreateWithImageAsync(recipeCreateDto, userId);

        return CreatedAtAction(nameof(GetById), new { id = createdRecipe.Id }, createdRecipe);
    }
    #endregion

    #region --- PUT Endpoints ---

    /// <summary>
    /// Actualiza una receta existente (solo para el autor o un Admin).
    /// </summary>
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update(int id, RecipeUpdateDTO recipeUpdateDto)
    {
        var recipe = await _recipeService.GetByIdAsync(id);

        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        if (recipe.AuthorId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid();
        }

        await _recipeService.UpdateAsync(id, recipeUpdateDto);
        return NoContent();
    }

    #endregion

    #region --- PATCH Endpoints ---

    /// <summary>
    /// Actualiza el estado de una receta (para el autor o un Admin).
    /// </summary>
    [HttpPatch("{id}/status")]
    [Authorize(Roles = "Chef, Admin")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> UpdateStatus(int id, RecipeStatusUpdateDTO recipeStatusUpdateDto)
    {
        // Verificación de autorización: Un Chef solo puede modificar sus propias recetas.
        var recipe = await _recipeService.GetByIdAsync(id);
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        if (currentUserRole != "Admin" && recipe.AuthorId != currentUserId)
        {
            return Forbid(); // 403 Forbidden si no es admin y no es el autor
        }

        await _recipeService.UpdateStatusAsync(id, recipeStatusUpdateDto);

        return NoContent();
    }
    #endregion

    #region --- DELETE Endpoints ---

    /// <summary>
    /// Elimina una receta (solo para el autor o un Admin).
    /// </summary>
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int id)
    {
        var recipe = await _recipeService.GetByIdAsync(id);
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        if (recipe.AuthorId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid();
        }

        await _recipeService.DeleteAsync(id);
        return NoContent();
    }

    #endregion
}