using CookingSharp.Application.Services.Contracts;
using CookingSharp.WebAPI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

/// <summary>
/// Controlador para obtener datos agregados del dashboard.
/// </summary>
public class DashboardController : BaseApiController
{
    private readonly IDashboardService _dashboardService;

    public DashboardController(IDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }

    /// <summary>
    /// Obtiene los datos principales para la página de inicio.
    /// </summary>
    [AllowAnonymous]
    [HttpGet("home")]
    public async Task<IActionResult> GetHomePageData()
    {
        var data = await _dashboardService.GetHomePageDataAsync();
        return Ok(data);
    }
}