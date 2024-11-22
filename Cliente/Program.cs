using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpClientExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 5000;

            using var client = new TcpClient();
            await client.ConnectAsync(server, port);
            Console.WriteLine("Connected to server");

            var stream = client.GetStream();

            while (true)
            {
                Console.Write("Enter message (type 'exit' to quit): ");
                string message = Console.ReadLine();

                if (message.ToLower() == "exit")
                {
                    break;
                }

                byte[] data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);
                Console.WriteLine($"Sent: {message}");

                var buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received: {response}");
            }

            client.Close();
            Console.WriteLine("Connection closed");
        }
    }
}