using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services;
using Microsoft.AspNetCore.Mvc;

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
                var createdRecipe = await _recipeService.AddAsync(recipeDto);
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