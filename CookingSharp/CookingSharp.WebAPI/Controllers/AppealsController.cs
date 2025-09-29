using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services;
using CookingSharp.Domain;
using Microsoft.AspNetCore.Authorization;
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


        [HttpGet("mis-solicitudes")] //appeal/mis-solicitudes
        public async Task<ActionResult<IEnumerable<AppealDTO>>> GetAllMy()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)
                                ?? throw new Exception("UserId no presente en el token."));

            var appeal = await appealService.GetAllAsyncMy(userId);
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

        [Authorize(Roles = "Apprentice")]
        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> Create([FromBody] AppealCreateDTO createDTO)
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)
                                ?? throw new Exception("UserId no presente en el token."));

                var appealDTO = new AppealDTO
                {
                    Description = createDTO.Description,                  
                    UserId = userId
                };

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
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAppealDTO appealDTO)
        {

            try
            {
                await appealService.UpdateAsync(id, appealDTO);
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