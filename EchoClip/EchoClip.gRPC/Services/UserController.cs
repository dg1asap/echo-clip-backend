using EchoClip.gRPC.Interfaces;
using Grpc.Core;

namespace EchoClip.gRPC.Services 
{
    class UserController(ILogger<AuthController> logger, IUserService userService) : gRPC.UserController.UserControllerBase
    {
        private readonly ILogger<AuthController> _logger = logger;
        private readonly IUserService _userService = userService;

        public override Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
        {
/*            _userService.CreateUser(request.Username, request.Password, request.Email, request.name, request.surname);
*/            _userService.CreateUser(request.Username, request.Password, request.Email);
            return Task.FromResult(new CreateUserResponse
            {
                Username = request.Username,
                Email = request.Email,
            });
        }
    }
}
