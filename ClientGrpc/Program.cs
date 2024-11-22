using games_namespace;
using greeter_namespace;
using Grpc.Core;
using Grpc.Net.Client;
using holas_namespace;

namespace ClientGrpc
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            // En caso que usen mac y tengan problemas con httpS:
            //https://learn.microsoft.com/en-us/aspnet/core/grpc/troubleshoot?view=aspnetcore-6.0#call-insecure-grpc-services-with-net-core-client 
            // A partir de .NET 5 en el cliente solo tienen que conectarse al servicio en el puerto correspondiente a http:// (ver launSettings.json)

            Console.WriteLine("Creando gRPC Client...");

            // The port number must match the port of the gRPC server.
            // si desactivo el TSL tengo que usar el http en vez de https (solo si https me da problemas en mac)

            // Me conecto al servidor:
            using var channel = GrpcChannel.ForAddress("http://localhost:5035");

            var client = new Hola.HolaClient(channel);

            var response = client.Saludar(new SaludoRequest { Name = "Ivan", Cantidad = 5 });
            try
            {
                while (await response.ResponseStream.MoveNext())
                {
                    var message = response.ResponseStream.Current;
                    Console.WriteLine($"Received: {message.Message}");
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine($"RPC failed: {e.Status}");
            }
            
            /*var client = new Greeter.GreeterClient(channel);
            var gameClient = new Games.GamesClient(channel);

            // Request basica:
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "Ivan" });
            Console.WriteLine("Greeting: " + reply.Message);

            // Suma:
            await Console.Out.WriteLineAsync("Sumando 5 + 4");
            NumbersReturn resultado = await client.AddNumbersAsync(new NumbersRequest
            {
                NumeroA = 4,
                NumeroB = 5,
            });
            Console.WriteLine("Total: " + resultado.Suma);

            // Lista de Usuario:
            UserListReply res = await client.GetUserListAsync(new UserListRequest { });

            foreach (User user in res.Users)
            {
                await Console.Out.WriteLineAsync($"{user.Name} tiene {user.Age} años");
            }
            if (res.HasMaxAge)
                Console.WriteLine($"The max age was set to {res.MaxAge}");
            else
                Console.WriteLine($"The max age was not set");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

            return;*/
        }
    }
}