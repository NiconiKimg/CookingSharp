using CookingSharp.Application.Contracts.Infrastructure;
using CookingSharp.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;

namespace CookingSharp.Infrastructure.Auth;

/// <summary>
/// Implementación del servicio de generación de tokens JWT.
/// </summary>
public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IConfiguration _configuration;

    public JwtTokenGenerator(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Genera un token JWT para un usuario específico.
    /// </summary>
    /// <param name="user">La entidad del usuario para quien se generará el token.</param>
    /// <returns>El token JWT como una cadena de texto.</returns>
    public string GenerateToken(User user)
    {
        // Obtenemos la clave secreta y la configuración desde appsettings.json
        var secretKey = _configuration["JwtSettings:Secret"];
        var issuer = _configuration["JwtSettings:Issuer"];
        var audience = _configuration["JwtSettings:Audience"];

        if (string.IsNullOrEmpty(secretKey))
        {
            throw new InvalidOperationException("La clave secreta de JWT no está configurada en appsettings.json");
        }

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        // Creamos los "claims" (afirmaciones) que irán dentro del token.
        // Estos son datos sobre el usuario que la API puede leer sin necesidad de ir a la base de datos.
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()), // "Subject" - El ID del usuario
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role.ToString()), // El rol del usuario
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // "JWT ID" - Un identificador único para el token
        };

        // Creamos el token con su configuración
        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddHours(8), // El token expira en 8 horas
            signingCredentials: credentials);

        // Escribimos el token como una cadena de texto
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}