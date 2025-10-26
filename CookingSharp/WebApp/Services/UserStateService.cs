using System.Security.Claims;
using WebApp.DTOs;

public class UserStateService
{
    public UserResponseDTO CurrentUser { get; private set; }

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