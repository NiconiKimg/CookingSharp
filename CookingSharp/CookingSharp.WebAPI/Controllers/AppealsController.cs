using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CookingSharp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppealsController(AppealService appealService) : ControllerBase
    {
        #region GET Endpoints

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppealDTO>>> GetAll()
        {
            var appeal = await appealService.GetAllAsync();
            return Ok(appeal);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppealDTO>> GetById(int id)
        {
            var appeal = await appealService.GetAsync(id);

            if (appeal == null)
            {
                return NotFound();
            }

            return Ok(appeal);
        }

        #endregion

        #region POST Endpoint

        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> Create([FromBody] AppealDTO appealDTO)
        {
            try
            {
                var createdAppeal = await appealService.AddAsync(appealDTO);
                return CreatedAtAction(nameof(GetById), new { id = createdAppeal.Id }, createdAppeal);
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

        #region PUT Endpoint

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AppealDTO appealDto)
        {
            if (id != appealDto.Id)
            {
                return BadRequest("El ID de la URL no coincide con el ID del objeto.");
            }

            try
            {
                await appealService.UpdateAsync(appealDto);
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
    }
}