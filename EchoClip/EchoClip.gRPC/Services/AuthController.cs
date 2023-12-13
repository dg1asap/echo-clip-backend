using Grpc.Core;

namespace EchoClip.gRPC.Services;

public class AuthController : gRPC.AuthController.AuthControllerBase
{
    
    private readonly ILogger<AuthController> _logger;
    private readonly JwtAuthManager _jwtAuthManager;

    public AuthController(ILogger<AuthController> logger, JwtAuthManager jwtAuthManager)
    {
        _logger = logger;
        _jwtAuthManager = jwtAuthManager;
    }

    public override Task<AuthResponse> Authentication(AuthRequest request, ServerCallContext context)
    {
        var authResposne = _jwtAuthManager.Authenticate(request);
        if (authResposne == null)
        {
            throw new RpcException(new Status(StatusCode.Unauthenticated, "Invalid user Credentails"));
        }
        return Task.FromResult(authResposne);
    }
}
