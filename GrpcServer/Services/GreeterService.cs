using greeter_namespace;
using Grpc.Core;

namespace GrpcServer.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger; // les autogenera un logger, lo pueden ignorar
        public GreeterService(ILogger<GreeterService> logger)
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

        public override Task<NumbersReturn> AddNumbers(NumbersRequest request, ServerCallContext context)
        {
            return Task.FromResult(new NumbersReturn
            {
                Suma = request.NumeroA + request.NumeroB
            });
        }

        public override Task<UserListReply> GetUserList(UserListRequest request, ServerCallContext context)
        {
            UserListReply reply = new UserListReply();
            reply.Users.Add(new User { Name = "Juan", Age = 22, IsMale = true });
            reply.Users.Add(new User { Name = "Maria", Age = 12, IsMale = false });
            reply.Users.Add(new User { Name = "Pablo", Age = 44, IsMale = true });
            reply.MaxAge = 44; // al ser opcional no tengo porque setearla

            return Task.FromResult(reply);
        }

        // Consejo: cuando especifiquen una nueva función en el .proto, al momenento de implementarla escribir
        // public override .. y dejar que Visual Studio les autocomplete la función 
    }
}