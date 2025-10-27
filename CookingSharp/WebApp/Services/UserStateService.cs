using System.Security.Claims;
using WebApp.DTOs;

/// <summary>
/// Servicio para mantener el estado del usuario autenticado en la aplicación.
/// </summary>
public class UserStateService
{
    /// <summary>
    /// Obtiene el usuario actualmente autenticado.
    /// </summary>
    public UserResponseDTO CurrentUser { get; private set; }

    /// <summary>
    /// Establece el usuario actual basándose en el ClaimsPrincipal.
    /// </summary>
    public void SetUser(ClaimsPrincipal user)
    {
        if (user.Identity.IsAuthenticated)
        {
            CurrentUser = new UserResponseDTO
            {
                Id = int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0"),
                Email = user.FindFirst(ClaimTypes.Email)?.Value,
                Role = user.FindFirst(ClaimTypes.Role)?.Value
            };
        }
        else
        {
            CurrentUser = null;
        }
    }
}