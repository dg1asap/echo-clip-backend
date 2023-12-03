using EchoClip.Services.Implementations;

namespace EchoClip.Services.Interfaces
{
    public interface IAuthService
    {
        TokenModel login(string username, string password);
        TokenModel getAccessToken(string refreshToken);
    }
}
