using Grpc.Core;
using holas_namespace;

namespace GrpcServer.Services;

public class HolaService : Hola.HolaBase
{
    public static IServerStreamWriter<SaludoReply>? ResponseStream { get; private set; }
    
    private static int messageCount = 0;

    public override async Task Saludar(SaludoRequest request, IServerStreamWriter<SaludoReply> responseStream, ServerCallContext context)
    {
        ResponseStream = responseStream;
        messageCount = 0;

        while (messageCount < request.Cantidad && !context.CancellationToken.IsCancellationRequested)
        {
            await Task.Delay(1000); // Keep the method alive
        }
        ResponseStream = null;
    }

    public static async Task SendMessageAsync(string message)
    {
        if (ResponseStream != null)
        {
            messageCount++;
            var saludoReply = new SaludoReply { Message = message };
            await ResponseStream.WriteAsync(saludoReply);
        }
    }
}