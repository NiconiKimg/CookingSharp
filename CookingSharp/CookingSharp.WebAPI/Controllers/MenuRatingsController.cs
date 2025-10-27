using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers
{
    /// <summary>
    /// Controlador para gestionar las valoraciones de menús.
    /// </summary>
    [Authorize]
    [Route("api/menus/{menuId}/ratings")]
    public class MenuRatingsController : BaseApiController
    {
        private readonly IMenuRatingService _menuRatingService;

        public MenuRatingsController(IMenuRatingService menuRatingService)
        {
            _menuRatingService = menuRatingService;
        }

        /// <summary>
        /// Añade o actualiza la valoración de un usuario para un menú.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> RateMenu(int menuId, [FromBody] RatingCreateUpdateDTO ratingDto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            await _menuRatingService.RateMenuAsync(menuId, ratingDto, userId);
            return Ok();
        }
    }
}