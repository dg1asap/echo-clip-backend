using EchoClip.gRPC.Interfaces;
using Grpc.Core;

namespace EchoClip.gRPC.Services 
{
    class ChatController(ILogger<AuthController> logger) : gRPC.ChatController.ChatControllerBase
    {
        private readonly ILogger<AuthController> _logger = logger;
/*        private readonly IUserService _chatService = chatService;*/


        /*        public override Task<CreateUserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
                {
                    _userService.CreateUser(request.Username, request.Password, request.Email, request.name, request.surname);
                    return Task.FromResult(new CreateUserResponse
                    {
                        Username = request.Username,
                        Email = request.Email,
                    });
                }*/

    }
}
