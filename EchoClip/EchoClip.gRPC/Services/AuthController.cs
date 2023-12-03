using Grpc.Core;

using EchoClip.Services.Implementations;
using EchoClip.Services.Interfaces;

namespace EchoClip.gRPC.Services;

public class AuthController : gRPC.AuthController.AuthControllerBase {
    
    private readonly IAuthService _authService;
    
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger, IAuthService authService)
    {
        _authService = authService;
        _logger = logger;
    }

    public override Task<LoginResponse> login(LoginRequest request, ServerCallContext context)
    {
        TokenModel token = _authService.login(request.Username, request.Password);
        return Task.FromResult(new LoginResponse
        {
            AccessToken = token.AccessToken,
            RefreshToken = token.RefreshToken
        });
    }

    public override Task<RefreshTokenResponse> getRefreshToken(RefreshTokenRequest request, ServerCallContext context) 
    {
        TokenModel token = _authService.getAccessToken(request.RefreshToken);
        return Task.FromResult(new RefreshTokenResponse
        {
            AccessToken = token.AccessToken
        });
    }
}
