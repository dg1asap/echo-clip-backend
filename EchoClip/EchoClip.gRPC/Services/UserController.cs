using EchoClip.gRPC.Interfaces;
using Grpc.Core;

namespace EchoClip.gRPC.Services 
{
    class UserController : gRPC.UserController.UserControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<AuthController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public override Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
        {
            _userService.createUser(request.Username, request.Password, request.Email);
            return Task.FromResult(new CreateUserResponse
            {
                Username = request.Username,
                Email = request.Email,
            });
        }
    }
}
