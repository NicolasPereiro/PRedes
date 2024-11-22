// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/games.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gameServer_namespace {
  public static partial class Games
  {
    static readonly string __ServiceName = "games.Games";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.AddGameRequest> __Marshaller_games_AddGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.AddGameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.AddGameReply> __Marshaller_games_AddGameReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.AddGameReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.DeleteGameRequest> __Marshaller_games_DeleteGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.DeleteGameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.DeleteGameReply> __Marshaller_games_DeleteGameReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.DeleteGameReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.ModifyGameRequest> __Marshaller_games_ModifyGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.ModifyGameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.ModifyGameReply> __Marshaller_games_ModifyGameReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.ModifyGameReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.GetGamesRequest> __Marshaller_games_GetGamesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.GetGamesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.GetGamesReply> __Marshaller_games_GetGamesReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.GetGamesReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.NextNBuysRequest> __Marshaller_games_NextNBuysRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.NextNBuysRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gameServer_namespace.NextNBuysReply> __Marshaller_games_NextNBuysReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gameServer_namespace.NextNBuysReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gameServer_namespace.AddGameRequest, global::gameServer_namespace.AddGameReply> __Method_AddGame = new grpc::Method<global::gameServer_namespace.AddGameRequest, global::gameServer_namespace.AddGameReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddGame",
        __Marshaller_games_AddGameRequest,
        __Marshaller_games_AddGameReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gameServer_namespace.DeleteGameRequest, global::gameServer_namespace.DeleteGameReply> __Method_DeleteGame = new grpc::Method<global::gameServer_namespace.DeleteGameRequest, global::gameServer_namespace.DeleteGameReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteGame",
        __Marshaller_games_DeleteGameRequest,
        __Marshaller_games_DeleteGameReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gameServer_namespace.ModifyGameRequest, global::gameServer_namespace.ModifyGameReply> __Method_ModifyGame = new grpc::Method<global::gameServer_namespace.ModifyGameRequest, global::gameServer_namespace.ModifyGameReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ModifyGame",
        __Marshaller_games_ModifyGameRequest,
        __Marshaller_games_ModifyGameReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gameServer_namespace.GetGamesRequest, global::gameServer_namespace.GetGamesReply> __Method_GetGames = new grpc::Method<global::gameServer_namespace.GetGamesRequest, global::gameServer_namespace.GetGamesReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGames",
        __Marshaller_games_GetGamesRequest,
        __Marshaller_games_GetGamesReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gameServer_namespace.NextNBuysRequest, global::gameServer_namespace.NextNBuysReply> __Method_NextNBuys = new grpc::Method<global::gameServer_namespace.NextNBuysRequest, global::gameServer_namespace.NextNBuysReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "NextNBuys",
        __Marshaller_games_NextNBuysRequest,
        __Marshaller_games_NextNBuysReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gameServer_namespace.GamesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Games</summary>
    [grpc::BindServiceMethod(typeof(Games), "BindService")]
    public abstract partial class GamesBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gameServer_namespace.AddGameReply> AddGame(global::gameServer_namespace.AddGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gameServer_namespace.DeleteGameReply> DeleteGame(global::gameServer_namespace.DeleteGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gameServer_namespace.ModifyGameReply> ModifyGame(global::gameServer_namespace.ModifyGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gameServer_namespace.GetGamesReply> GetGames(global::gameServer_namespace.GetGamesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task NextNBuys(global::gameServer_namespace.NextNBuysRequest request, grpc::IServerStreamWriter<global::gameServer_namespace.NextNBuysReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GamesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddGame, serviceImpl.AddGame)
          .AddMethod(__Method_DeleteGame, serviceImpl.DeleteGame)
          .AddMethod(__Method_ModifyGame, serviceImpl.ModifyGame)
          .AddMethod(__Method_GetGames, serviceImpl.GetGames)
          .AddMethod(__Method_NextNBuys, serviceImpl.NextNBuys).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GamesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gameServer_namespace.AddGameRequest, global::gameServer_namespace.AddGameReply>(serviceImpl.AddGame));
      serviceBinder.AddMethod(__Method_DeleteGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gameServer_namespace.DeleteGameRequest, global::gameServer_namespace.DeleteGameReply>(serviceImpl.DeleteGame));
      serviceBinder.AddMethod(__Method_ModifyGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gameServer_namespace.ModifyGameRequest, global::gameServer_namespace.ModifyGameReply>(serviceImpl.ModifyGame));
      serviceBinder.AddMethod(__Method_GetGames, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gameServer_namespace.GetGamesRequest, global::gameServer_namespace.GetGamesReply>(serviceImpl.GetGames));
      serviceBinder.AddMethod(__Method_NextNBuys, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::gameServer_namespace.NextNBuysRequest, global::gameServer_namespace.NextNBuysReply>(serviceImpl.NextNBuys));
    }

  }
}
#endregion