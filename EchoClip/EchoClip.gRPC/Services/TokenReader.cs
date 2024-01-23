using EchoClip.gRPC.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace EchoClip.gRPC.Services;

public class UserFromTokenReader(IHttpContextAccessor httpContextAccessor, IUserService userService)
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public Guid? GetUserGUID()
    {   
        try
        {
            var accessToken = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();
            var token = accessToken.Substring(7); // <-- 7 from 'Bearer '

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            if (jwtSecurityTokenHandler.CanReadToken(token))
            {
                var claimsPrincipal = jwtSecurityTokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JwtAuthManager.JWT_TOKEN_KEY))
                }, out _);

                var usernameClaim = claimsPrincipal.FindFirst("username");

                if (usernameClaim != null)
                {
                    return userService.GetUserGuidFromUsernameOrEmail(usernameClaim.Value, usernameClaim.Value);
                    /*                return usernameClaim.Value;*/
                }
            }
        }
        catch (Exception ex) { }

        return null;

    }
}