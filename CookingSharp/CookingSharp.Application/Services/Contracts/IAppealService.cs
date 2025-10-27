using CookingSharp.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookingSharp.Application.Services.Contracts;

/// <summary>
/// Define el contrato para el servicio de gestión de solicitudes para ser Chef.
/// </summary>
public interface IAppealService
{
    /// <summary>
    /// Obtiene todas las solicitudes pendientes. (Para Administradores)
    /// </summary>
    Task<IEnumerable<AppealResponseDTO>> GetAllPendingAsync();

    /// <summary>
    /// Obtiene todas las solicitudes de un usuario específico.
    /// </summary>
    /// <param name="userId">El ID del usuario (Aprendiz).</param>
    Task<IEnumerable<AppealResponseDTO>> GetAppealsByUserAsync(int userId);

    Task<AppealResponseDTO?> GetByIdAsync(int id);

    /// <summary>
    /// Crea una nueva solicitud para convertirse en Chef.
    /// </summary>
    /// <param name="appealDto">El DTO con la descripción de la solicitud.</param>
    /// <param name="applicantUserId">El ID del usuario que realiza la solicitud.</param>
    Task<AppealResponseDTO> CreateAsync(AppealCreateDTO appealDto, int applicantUserId);

    /// <summary>
    /// Procesa una solicitud, cambiándola a Aprobada o Rechazada. (Para Administradores)
    /// </summary>
    /// <param name="id">El ID de la solicitud a procesar.</param>
    /// <param name="appealUpdateDto">El DTO con el nuevo estado.</param>
    Task ProcessAppealAsync(int id, AppealUpdateDTO appealUpdateDto);

    /// <summary>
    /// Obtiene el número de solicitudes pendientes de revisión.
    /// </summary>
    /// <returns>El conteo de solicitudes pendientes.</returns>
    Task<int> GetPendingCountAsync();
}