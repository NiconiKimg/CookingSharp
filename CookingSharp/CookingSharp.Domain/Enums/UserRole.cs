namespace CookingSharp.Domain.Enums;

/// <summary>
/// Roles de usuario en el sistema.
/// </summary>
public enum UserRole
{
    /// <summary>
    /// Administrador del sistema con permisos completos.
    /// </summary>
    Admin,

    /// <summary>
    /// Chef con permisos para crear recetas y menús.
    /// </summary>
    Chef,

    /// <summary>
    /// Aprendiz con permisos básicos de visualización y valoración.
    /// </summary>
    Apprentice
}