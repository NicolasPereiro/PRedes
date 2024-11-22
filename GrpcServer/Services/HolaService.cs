using Grpc.Core;
using holas_namespace;
using System.Collections.Concurrent;

namespace GrpcServer.Services;

public class HolaService : Hola.HolaBase
{
    private static readonly ConcurrentDictionary<IServerStreamWriter<SaludoReply>, bool> ActiveStreams = new ConcurrentDictionary<IServerStreamWriter<SaludoReply>, bool>();

    public override async Task Saludar(SaludoRequest request, IServerStreamWriter<SaludoReply> responseStream, ServerCallContext context)
    {
        ActiveStreams.TryAdd(responseStream, true);
        
        while (!context.CancellationToken.IsCancellationRequested)
        {
            await Task.Delay(1000);
        }

        ActiveStreams.TryRemove(responseStream, out _);
    }

    public static void AddMessage(string message)
    {
        foreach (var stream in ActiveStreams.Keys)
        {
            stream.WriteAsync(new SaludoReply { Message = message });
        }
    }
}