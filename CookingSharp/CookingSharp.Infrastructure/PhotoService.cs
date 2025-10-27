using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CookingSharp.Application.Contracts.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace CookingSharp.Infrastructure;

/// <summary>
/// Implementación del servicio de gestión de imágenes mediante Cloudinary.
/// </summary>
public class PhotoService : IPhotoService
{
    private readonly Cloudinary _cloudinary;
    private readonly CloudinarySettings _cloudinarySettings;

    public PhotoService(IOptions<CloudinarySettings> config)
    {
        _cloudinarySettings = config.Value;
        var account = new Account(
            _cloudinarySettings.CloudName,
            _cloudinarySettings.ApiKey,
            _cloudinarySettings.ApiSecret);
        _cloudinary = new Cloudinary(account);
    }

    /// <summary>
    /// Sube una imagen a Cloudinary de forma asíncrona.
    /// </summary>
    /// <param name="file">Archivo de imagen a subir.</param>
    /// <returns>Tupla con la URL de la imagen y su identificador público.</returns>
    public async Task<(string ImageUrl, string PublicId)> AddPhotoAsync(IFormFile file)
    {
        if (file.Length > 0)
        {
            await using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
                Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new System.Exception(uploadResult.Error.Message);
            }

            return (uploadResult.SecureUrl.AbsoluteUri, uploadResult.PublicId);
        }
        return (string.Empty, string.Empty);
    }

    /// <summary>
    /// Elimina una imagen de Cloudinary de forma asíncrona.
    /// </summary>
    /// <param name="publicId">Identificador público de la imagen a eliminar.</param>
    /// <returns>True si la eliminación fue exitosa, false en caso contrario.</returns>
    public async Task<bool> DeletePhotoAsync(string publicId)
    {
        var deleteParams = new DeletionParams(publicId);
        var result = await _cloudinary.DestroyAsync(deleteParams);
        return result.Result == "ok";
    }

    /// <summary>
    /// Obtiene la imagen por defecto configurada.
    /// </summary>
    /// <returns>Tupla con la URL y el identificador público de la imagen por defecto.</returns>
    public (string ImageUrl, string PublicId) GetDefaultImage()
    {
        return (_cloudinarySettings.DefaultImageUrl, _cloudinarySettings.DefaultImagePublicId);
    }
}