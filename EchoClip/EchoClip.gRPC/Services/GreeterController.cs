using Grpc.Core;
using Microsoft.AspNetCore.Authorization;

namespace EchoClip.gRPC.Services
{
    public class GreeterController(ILogger<GreeterController> logger, UserFromTokenReader tokenReader) : gRPC.GreeterController.GreeterControllerBase
    {
        private readonly ILogger<GreeterController> _logger = logger;
        private readonly UserFromTokenReader _tokenReader = tokenReader;

        [Authorize]
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var username = _tokenReader.GetUserGUID();

            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + "XXX" + username + "XXX" + request.Name
            });;
        } 
    }
}
