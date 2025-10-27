namespace CookingSharp.Infrastructure;

/// <summary>
/// Configuración para el servicio de almacenamiento de imágenes Cloudinary.
/// </summary>
public class CloudinarySettings
{
    /// <summary>
    /// Nombre de la cuenta de Cloudinary.
    /// </summary>
    public string CloudName { get; set; }

    /// <summary>
    /// Clave API de Cloudinary.
    /// </summary>
    public string ApiKey { get; set; }

    /// <summary>
    /// Secreto API de Cloudinary.
    /// </summary>
    public string ApiSecret { get; set; }

    /// <summary>
    /// URL de la imagen por defecto.
    /// </summary>
    public string DefaultImageUrl { get; set; }

    /// <summary>
    /// Identificador público de la imagen por defecto.
    /// </summary>
    public string DefaultImagePublicId { get; set; }
}