using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

[Authorize]
public class AppealsController : BaseApiController
{
    private readonly IAppealService _appealService;

    public AppealsController(IAppealService appealService)
    {
        _appealService = appealService;
    }

    #region --- Admin Endpoints ---

    /// <summary>
    /// Obtiene todas las solicitudes pendientes (solo para Admins).
    /// </summary>
    [HttpGet("pending")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllPending()
    {
        var appeals = await _appealService.GetAllPendingAsync();
        return Ok(appeals);
    }

    /// <summary>
    /// Procesa una solicitud, aprobándola o rechazándola (solo para Admins).
    /// </summary>
    [HttpPut("{id}/process")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> ProcessAppeal(int id, AppealUpdateDTO appealUpdateDto)
    {
        await _appealService.ProcessAppealAsync(id, appealUpdateDto);
        return NoContent();
    }

    #endregion

    #region --- User Endpoints ---

    /// <summary>
    /// Obtiene todas las solicitudes hechas por el usuario actual.
    /// </summary>
    [HttpGet("my-appeals")]
    public async Task<IActionResult> GetMyAppeals()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var appeals = await _appealService.GetAppealsByUserAsync(userId);
        return Ok(appeals);
    }

    /// <summary>
    /// Crea una nueva solicitud para convertirse en Chef (solo para Aprendices).
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Apprentice")]
    public async Task<IActionResult> Create(AppealCreateDTO appealCreateDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var createdAppeal = await _appealService.CreateAsync(appealCreateDto, userId);
        return Ok(createdAppeal);
    }

    #endregion

    /// <summary>
    /// Obtiene el número de solicitudes pendientes de revisión (solo para Admins).
    /// </summary>
    [HttpGet("pending/count")]
    [Authorize(Roles = "Admin")]
    [ProducesResponseType(typeof(int), 200)]
    public async Task<IActionResult> GetPendingCount()
    {
        var count = await _appealService.GetPendingCountAsync();
        return Ok(count);
    }
}