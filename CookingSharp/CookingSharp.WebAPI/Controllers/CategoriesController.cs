using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CookingSharp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController(CategoryService categoryService) : ControllerBase
    {
        #region GET Endpoints

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetAll()
        {
            var categories = await categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> GetById(int id)
        {
            var category = await categoryService.GetAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        #endregion

        #region POST Endpoint

        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> Create([FromBody] CategoryDTO categoryDto)
        {
            try
            {
                var createdCategory = await categoryService.AddAsync(categoryDto);
                return CreatedAtAction(nameof(GetById), new { id = createdCategory.Id }, createdCategory);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region PUT Endpoint

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
            {
                return BadRequest("El ID de la URL no coincide con el ID del objeto.");
            }

            try
            {
                await categoryService.UpdateAsync(categoryDto);
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

        #region DELETE Endpoint

        [HttpDelete("{id}")] // Responde a: DELETE /api/categories/5
        public async Task<IActionResult> Delete(int id)
        {
            var success = await categoryService.DeleteAsync(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }

        #endregion
    }
}