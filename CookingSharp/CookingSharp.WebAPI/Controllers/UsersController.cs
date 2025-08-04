using CookingSharp.Application.Services;
using CookingSharp.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CookingSharp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(UserService userService) : ControllerBase
    {
        #region GET Endpoints

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponseDTO>>> GetAll()
        {
            var users = await userService.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponseDTO>> GetById(int id)
        {
            var user = await userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        #endregion

        #region POST Endpoint

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Create([FromBody] UserDTO userDto)
        {
            try
            {
                var createdUser = await userService.AddAsync(userDto);
                return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, createdUser);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region PUT Endpoint

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserResponseDTO userDto)
        {
            if (id != userDto.Id)
            {
                return BadRequest("El ID de la URL no coincide con el ID del objeto.");
            }

            try
            {
                await userService.UpdateAsync(userDto);
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
            var success = await userService.DeleteAsync(id);

            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }

        #endregion
    }
}