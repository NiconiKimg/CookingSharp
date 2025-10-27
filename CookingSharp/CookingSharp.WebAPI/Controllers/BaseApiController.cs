using Microsoft.AspNetCore.Mvc;

namespace CookingSharp.WebAPI.Controllers;

/// <summary>
/// Controlador base del cual heredarán todos los demás controladores de la API.
/// Proporciona atributos comunes como [ApiController] y la ruta base.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
}