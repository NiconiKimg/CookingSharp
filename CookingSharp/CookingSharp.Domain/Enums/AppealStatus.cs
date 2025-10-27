namespace CookingSharp.Domain.Enums;

/// <summary>
/// Estados posibles de una solicitud de promoción a Chef.
/// </summary>
public enum AppealStatus
{
    /// <summary>
    /// La solicitud está pendiente de revisión.
    /// </summary>
    Pending,

    /// <summary>
    /// La solicitud ha sido aprobada.
    /// </summary>
    Approved,

    /// <summary>
    /// La solicitud ha sido rechazada.
    /// </summary>
    Rejected
}