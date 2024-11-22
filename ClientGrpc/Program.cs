using System;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using holas_namespace;

namespace ClientGrpc
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Creating gRPC Client...");

            using var channel = GrpcChannel.ForAddress("http://localhost:5035");
            var client = new Hola.HolaClient(channel);
            int cantidad = int.Parse(Console.ReadLine());
            var response = client.Saludar(new SaludoRequest { Name = "Ivan", Cantidad = cantidad });
            int receivedCount = 0;

            try
            {
                while (await response.ResponseStream.MoveNext())
                {
                    var message = response.ResponseStream.Current;
                    Console.WriteLine($"Received: {message.Message}");
                    receivedCount++;

                    if (receivedCount >= cantidad)
                    {
                        break;
                    }
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine($"RPC failed: {e.Status}");
            }
        }
    }
}