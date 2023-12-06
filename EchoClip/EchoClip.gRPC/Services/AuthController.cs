using Grpc.Core;

namespace EchoClip.gRPC.Services;

public class AuthController : gRPC.AuthController.AuthControllerBase {
    
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public override Task<AuthResponse> Authentication(AuthRequest request, ServerCallContext context)
    {
        var authResposne = JwtAuthManager.Authenticate(request);
        if (authResposne == null)
        {
            throw new RpcException(new Status(StatusCode.Unauthenticated, "Invalid user Credentails"));
        }
        return Task.FromResult(authResposne);
    }
}
