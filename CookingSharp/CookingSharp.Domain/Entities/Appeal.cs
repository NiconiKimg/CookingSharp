using CookingSharp.Domain.Enums;
using System;

namespace CookingSharp.Domain.Entities;

/// <summary>
/// Representa una solicitud de un Aprendiz para convertirse en Chef.
/// </summary>
public class Appeal
{
    /// <summary>
    /// Identificador único de la solicitud.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Texto de justificación enviado por el usuario en la solicitud.
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Estado actual de la solicitud (Pendiente, Aprobada, Rechazada).
    /// </summary>
    public AppealStatus Status { get; private set; }

    /// <summary>
    /// Clave foránea del usuario que realiza la solicitud.
    /// </summary>
    public int UserId { get; private set; }

    public User User { get; private set; }

    private Appeal() { }

    /// <summary>
    /// Constructor para crear una nueva solicitud válida.
    /// </summary>
    /// <param name="description">Texto de la solicitud.</param>
    /// <param name="userId">ID del usuario solicitante.</param>
    public Appeal(string description, int userId)
    {
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("La descripción de la solicitud no puede estar vacía.", nameof(description));
        if (userId <= 0)
            throw new ArgumentException("El ID de usuario debe ser un valor positivo.", nameof(userId));

        Description = description;
        UserId = userId;
        Status = AppealStatus.Pending;
    }

    /// <summary>
    /// Aprueba la solicitud si está pendiente.
    /// </summary>
    public void Approve()
    {
        if (Status == AppealStatus.Pending)
            Status = AppealStatus.Approved;
    }

    /// <summary>
    /// Rechaza la solicitud si está pendiente.
    /// </summary>
    public void Reject()
    {
        if (Status == AppealStatus.Pending)
            Status = AppealStatus.Rejected;
    }
}