namespace CookingSharp.Application.DTOs;

/// <summary>
/// DTO para devolver una solicitud para ser Chef.
/// </summary>
public class AppealResponseDTO
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public int ApplicantId { get; set; }
    public string ApplicantName { get; set; }
}

/// <summary>
/// DTO para crear una nueva solicitud.
/// </summary>
public class AppealCreateDTO
{
    public string Description { get; set; }
}

/// <summary>
/// DTO para que un administrador actualice el estado de una solicitud.
/// </summary>
public class AppealUpdateDTO
{
    public string Status { get; set; } // Ej: "Approved" o "Rejected"
}