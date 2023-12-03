using EchoClip.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EchoClip.Services.Implementations;

public class AuthService : IAuthService
{
    private const string SecretKey = "your_secret_key";
    private readonly JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

    public TokenModel loginIn(string username, string password)
    {
        if (IsValidUser(username, password))
        {
            var accessToken = GenerateAccessToken(username);
            var refreshToken = GenerateRefreshToken();

            return new TokenModel
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }
        else
        {
            throw new Exception("Login Failed !!!!!!");
        }
    }

    public TokenModel getToken(string refreshToken)
    {
        if (IsValidRefreshToken(refreshToken))
        {
            var accessToken = GenerateAccessTokenFromRefreshToken(refreshToken);

            return new TokenModel
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken //TODO Do spradzenia czy refresh token się zmienia?
            };
        }
        else
        {
            throw new Exception("RefreshToken Failed !!!!!!");
        }
    }

    private bool IsValidUser(string username, string password)
    {
        return username == "exampleUser" && password == "examplePassword";
        // TODO do bazy
    }

    private string GenerateAccessToken(string username)
    {
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, username)
            }),
            Expires = DateTime.UtcNow.AddMinutes(15), // Czas ważności tokenu
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Convert.FromBase64String(SecretKey)),
                SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private string GenerateRefreshToken()
    {
        return Guid.NewGuid().ToString();
    }

    private bool IsValidRefreshToken(string refreshToken)
    {
        return true;
    }

    private string GenerateAccessTokenFromRefreshToken(string refreshToken)
    {
        return refreshToken;
    }

}