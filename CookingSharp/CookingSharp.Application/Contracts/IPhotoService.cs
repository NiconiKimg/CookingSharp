using Microsoft.AspNetCore.Http;

namespace CookingSharp.Application.Contracts.Infrastructure;

public interface IPhotoService
{
    Task<(string ImageUrl, string PublicId)> AddPhotoAsync(IFormFile file);
    Task<bool> DeletePhotoAsync(string publicId);
}