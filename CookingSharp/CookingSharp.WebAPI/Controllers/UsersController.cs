using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : BaseApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        #region -- GET Enpoints --
        /// <summary>
        /// Obtiene una lista de todos los usuarios.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        /// <summary>
        /// Obtiene un usuario específico por su ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }

        /// <summary>
        /// Obtiene el número total de usuarios registrados.
        /// </summary>
        [HttpGet("count")]
        [ProducesResponseType(typeof(int), 200)]
        public async Task<IActionResult> GetCount()
        {
            var count = await _userService.GetTotalCountAsync();
            return Ok(count);
        }

        #endregion

        #region -- PUT Endpoints --
        /// <summary>
        /// Actualiza el perfil de un usuario.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UserUpdateDTO userUpdateDto)
        {
            await _userService.UpdateAsync(id, userUpdateDto);
            return NoContent();
        }

        #endregion

        #region -- DELETE Endpoints --
        /// <summary>
        /// Elimina un usuario.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }
        #endregion
    }
}