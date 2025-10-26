using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    /// Obtiene una lista de todas las recetas (público).
    /// </summary>
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var recipes = await _recipeService.GetAllAsync();
        return Ok(recipes);
    }

    [AllowAnonymous]
    [HttpGet("summaries")]
    public async Task<IActionResult> GetAllSummaries()
    {
        var recipeSummaries = await _recipeService.GetAllSummariesAsync();
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

    #endregion

    #region --- POST Endpoints ---

    /// <summary>
    /// Crea una nueva receta (solo para Chefs y Admins).
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Chef,Admin")]
    public async Task<IActionResult> Create(RecipeCreateDTO recipeCreateDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var createdRecipe = await _recipeService.CreateAsync(recipeCreateDto, userId);
        return CreatedAtAction(nameof(GetById), new { id = createdRecipe.Id }, createdRecipe);
    }

    #endregion

    #region --- PUT Endpoints ---

    /// <summary>
    /// Actualiza una receta existente (solo para el autor o un Admin).
    /// </summary>
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)] // Forbidden
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update(int id, RecipeUpdateDTO recipeUpdateDto)
    {
        // 1. Obtener la receta para verificar quién es el autor.
        var recipe = await _recipeService.GetByIdAsync(id);

        // 2. Obtener la información del usuario que hace la petición desde el token JWT.
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        // 3. Lógica de Autorización: Permitir solo si el usuario es el autor O si es Admin.
        if (recipe.AuthorId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid(); // Devuelve un 403 Forbidden si no tiene permisos.
        }

        // 4. Si la autorización pasa, proceder con la actualización.
        await _recipeService.UpdateAsync(id, recipeUpdateDto);
        return NoContent();
    }

    #endregion

    #region --- PATCH Endpoints ---

    /// <summary>
    /// Actualiza el estado de una receta (solo para Admins).
    /// </summary>
    [HttpPatch("{id}/status")]
    [Authorize(Roles = "Admin")]
    [ProducesResponseType(204)]
    [ProducesResponseType(403)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> UpdateStatus(int id, RecipeStatusUpdateDTO recipeStatusUpdateDto)
    {

        var recipe = await _recipeService.GetByIdAsync(id);

        Console.WriteLine($"Simulando cambio de estado para Receta ID {id} a '{recipeStatusUpdateDto.Status}'");

        var fullRecipeDto = new RecipeUpdateDTO
        {
            Name = recipe.Name,
            Description = recipe.Description,
            Steps = recipe.Steps.Select(s => new RecipeStepCreateDTO { Instruction = s.Instruction }).ToList(),
            CategoryIds = recipe.Categories.Select(c => c.Id).ToList()
        };
        await _recipeService.UpdateAsync(id, fullRecipeDto);


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
        // Lógica de autorización idéntica a la de Update.
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