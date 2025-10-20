using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CookingSharp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeService _recipeService;

        public RecipesController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        #region GET Endpoints

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseRecipeDTO>>> GetAll()
        {
            var recipes = await _recipeService.GetAllAsync();
            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseRecipeDTO>> GetById(int id)
        {
            var recipe = await _recipeService.GetAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        #endregion

        #region POST Endpoints

        [HttpPost]
        public async Task<ActionResult<ResponseRecipeDTO>> Create([FromBody] CreateRecipeDTO recipeDto)
        {
            try
            {

                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)
                                ?? throw new Exception("UserId no presente en el token."));

                var createRecipeDto = new CreateRecipeDTO
                {
                    Description = recipeDto.Description,
                    Content = recipeDto.Content,
                    UserId = userId,
                    CategoryIds = recipeDto.CategoryIds
                };

                var createdRecipe = await _recipeService.AddAsync(createRecipeDto);
                return CreatedAtAction(nameof(GetById), new { id = createdRecipe.Id }, createdRecipe);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        #endregion

        #region PUT Endpoints

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRecipeDTO recipeDto)
        {
            try
            {
                await _recipeService.UpdateAsync(id, recipeDto);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region DELETE Endpoints

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _recipeService.DeleteAsync(id);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }

        #endregion
    }
}