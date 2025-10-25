using CookingSharp.Application.DTOs;
using CookingSharp.Application.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CookingSharp.WebAPI.Controllers;

/// <summary>
/// Controlador para gestionar los menús de recetas.
/// </summary>
[Authorize] // Todos los endpoints requieren autenticación por defecto, a menos que se especifique lo contrario.
public class MenusController : BaseApiController
{
    private readonly IMenuService _menuService;

    public MenusController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    #region --- GET Endpoints ---

    /// <summary>
    /// Obtiene todos los menús creados por el usuario actualmente autenticado.
    /// </summary>
    [HttpGet("my-menus")]
    [ProducesResponseType(typeof(IEnumerable<MenuResponseDTO>), 200)]
    [ProducesResponseType(401)] // Unauthorized
    public async Task<IActionResult> GetMyMenus()
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var menus = await _menuService.GetMenusByUserAsync(userId);
        return Ok(menus);
    }

    /// <summary>
    /// Obtiene un menú específico por su ID.
    /// </summary>
    /// <remarks>
    /// Este endpoint es público para que cualquiera pueda ver un menú si tiene el enlace.
    /// </remarks>
    [AllowAnonymous]
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(MenuResponseDTO), 200)]
    [ProducesResponseType(404)] // Not Found
    public async Task<IActionResult> GetById(int id)
    {
        var menu = await _menuService.GetByIdAsync(id);
        return Ok(menu);
    }

    #endregion

    #region --- POST Endpoints ---

    /// <summary>
    /// Crea un nuevo menú (restringido a roles de Chef y Admin).
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Chef,Admin")]
    [ProducesResponseType(typeof(MenuResponseDTO), 201)] // Created
    [ProducesResponseType(400)] // Bad Request
    [ProducesResponseType(401)] // Unauthorized
    [ProducesResponseType(403)] // Forbidden
    public async Task<IActionResult> Create(MenuCreateUpdateDTO menuDto)
    {
        var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var createdMenu = await _menuService.CreateAsync(menuDto, userId);
        return CreatedAtAction(nameof(GetById), new { id = createdMenu.Id }, createdMenu);
    }

    #endregion

    #region --- PUT Endpoints ---

    /// <summary>
    /// Actualiza un menú existente (restringido al autor del menú o a un Administrador).
    /// </summary>
    [HttpPut("{id}")]
    [ProducesResponseType(204)] // No Content
    [ProducesResponseType(401)] // Unauthorized
    [ProducesResponseType(403)] // Forbidden
    [ProducesResponseType(404)] // Not Found
    public async Task<IActionResult> Update(int id, MenuCreateUpdateDTO menuDto)
    {
        // 1. Obtener el menú para verificar la propiedad.
        var menu = await _menuService.GetByIdAsync(id);

        // 2. Obtener la información del usuario que realiza la petición desde el token JWT.
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        // 3. Lógica de Autorización: Permitir la acción solo si el usuario es el autor O si es un Admin.
        if (menu.UserId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid(); // Devuelve un 403 Forbidden si el usuario no tiene permisos.
        }

        // 4. Si la autorización es exitosa, proceder con la actualización.
        await _menuService.UpdateAsync(id, menuDto);
        return NoContent();
    }

    #endregion

    #region --- DELETE Endpoints ---

    /// <summary>
    /// Elimina un menú (restringido al autor del menú o a un Administrador).
    /// </summary>
    [HttpDelete("{id}")]
    [ProducesResponseType(204)] // No Content
    [ProducesResponseType(401)] // Unauthorized
    [ProducesResponseType(403)] // Forbidden
    [ProducesResponseType(404)] // Not Found
    public async Task<IActionResult> Delete(int id)
    {
        // Lógica de autorización idéntica a la del método Update.
        var menu = await _menuService.GetByIdAsync(id);
        var currentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var currentUserRole = User.FindFirstValue(ClaimTypes.Role)!;

        if (menu.UserId != currentUserId && currentUserRole != "Admin")
        {
            return Forbid();
        }

        await _menuService.DeleteAsync(id);
        return NoContent();
    }

    #endregion
}