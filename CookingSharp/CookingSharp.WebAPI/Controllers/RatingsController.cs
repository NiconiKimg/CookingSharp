using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

[Authorize]
[Route("api/recipes/{recipeId}/[controller]")] // Ruta anidada: api/recipes/5/ratings
public class RatingsController : BaseApiController
{
    private readonly IRatingService _ratingService;

    public RatingsController(IRatingService ratingService)
    {
        _ratingService = ratingService;
    }

    #region --- GET Endpoints ---

    /// <summary>
    /// Obtiene la valoración promedio de una receta.
    /// </summary>
    [AllowAnonymous]
    [HttpGet("average")]
    public async Task<IActionResult> GetAverageRating(int recipeId)
    {
        var average = await _ratingService.GetAverageRatingForRecipeAsync(recipeId);
        return Ok(new { averageRating = average });
    }

    #endregion

    #region --- POST/DELETE Endpoints ---

    /// <summary>
    /// Añade o actualiza la valoración de un usuario para una receta.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> RateRecipe(int recipeId, RatingCreateUpdateDTO ratingDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        await _ratingService.RateRecipeAsync(recipeId, ratingDto, userId);
        return Ok();
    }

    /// <summary>
    /// Elimina la valoración de un usuario para una receta.
    /// </summary>
    [HttpDelete]
    public async Task<IActionResult> RemoveRating(int recipeId)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        await _ratingService.RemoveRatingAsync(recipeId, userId);
        return NoContent();
    }

    #endregion
}