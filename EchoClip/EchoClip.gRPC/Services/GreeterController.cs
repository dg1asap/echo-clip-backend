using Grpc.Core;

namespace EchoClip.gRPC.Services
{
    public class GreeterController : gRPC.GreeterController.GreeterControllerBase
    {
        private readonly ILogger<GreeterController> _logger;
        public GreeterController(ILogger<GreeterController> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
