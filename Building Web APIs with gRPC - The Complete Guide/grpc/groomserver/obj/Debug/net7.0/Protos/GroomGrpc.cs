// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/groom.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRoom.gRPC.Messages {
  public static partial class Groom
  {
    static readonly string __ServiceName = "groom.Groom";

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
    static readonly grpc::Marshaller<global::gRoom.gRPC.Messages.RoomRegistrationRequest> __Marshaller_groom_RoomRegistrationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRoom.gRPC.Messages.RoomRegistrationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRoom.gRPC.Messages.RoomRegistrationResponse> __Marshaller_groom_RoomRegistrationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRoom.gRPC.Messages.RoomRegistrationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRoom.gRPC.Messages.NewsFlash> __Marshaller_groom_NewsFlash = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRoom.gRPC.Messages.NewsFlash.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRoom.gRPC.Messages.NewsStreamStatus> __Marshaller_groom_NewsStreamStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRoom.gRPC.Messages.NewsStreamStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRoom.gRPC.Messages.ReceivedMessage> __Marshaller_groom_ReceivedMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRoom.gRPC.Messages.ReceivedMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::gRoom.gRPC.Messages.ChatMessage> __Marshaller_groom_ChatMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::gRoom.gRPC.Messages.ChatMessage.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRoom.gRPC.Messages.RoomRegistrationRequest, global::gRoom.gRPC.Messages.RoomRegistrationResponse> __Method_RegisterToRoom = new grpc::Method<global::gRoom.gRPC.Messages.RoomRegistrationRequest, global::gRoom.gRPC.Messages.RoomRegistrationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterToRoom",
        __Marshaller_groom_RoomRegistrationRequest,
        __Marshaller_groom_RoomRegistrationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRoom.gRPC.Messages.NewsFlash, global::gRoom.gRPC.Messages.NewsStreamStatus> __Method_SendNewsFlash = new grpc::Method<global::gRoom.gRPC.Messages.NewsFlash, global::gRoom.gRPC.Messages.NewsStreamStatus>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "SendNewsFlash",
        __Marshaller_groom_NewsFlash,
        __Marshaller_groom_NewsStreamStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::gRoom.gRPC.Messages.ReceivedMessage> __Method_StartMonitoring = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::gRoom.gRPC.Messages.ReceivedMessage>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "StartMonitoring",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_groom_ReceivedMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::gRoom.gRPC.Messages.ChatMessage, global::gRoom.gRPC.Messages.ChatMessage> __Method_StartChat = new grpc::Method<global::gRoom.gRPC.Messages.ChatMessage, global::gRoom.gRPC.Messages.ChatMessage>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StartChat",
        __Marshaller_groom_ChatMessage,
        __Marshaller_groom_ChatMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRoom.gRPC.Messages.GroomReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Groom</summary>
    [grpc::BindServiceMethod(typeof(Groom), "BindService")]
    public abstract partial class GroomBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRoom.gRPC.Messages.RoomRegistrationResponse> RegisterToRoom(global::gRoom.gRPC.Messages.RoomRegistrationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::gRoom.gRPC.Messages.NewsStreamStatus> SendNewsFlash(grpc::IAsyncStreamReader<global::gRoom.gRPC.Messages.NewsFlash> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StartMonitoring(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::gRoom.gRPC.Messages.ReceivedMessage> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StartChat(grpc::IAsyncStreamReader<global::gRoom.gRPC.Messages.ChatMessage> requestStream, grpc::IServerStreamWriter<global::gRoom.gRPC.Messages.ChatMessage> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GroomBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterToRoom, serviceImpl.RegisterToRoom)
          .AddMethod(__Method_SendNewsFlash, serviceImpl.SendNewsFlash)
          .AddMethod(__Method_StartMonitoring, serviceImpl.StartMonitoring)
          .AddMethod(__Method_StartChat, serviceImpl.StartChat).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GroomBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterToRoom, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRoom.gRPC.Messages.RoomRegistrationRequest, global::gRoom.gRPC.Messages.RoomRegistrationResponse>(serviceImpl.RegisterToRoom));
      serviceBinder.AddMethod(__Method_SendNewsFlash, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::gRoom.gRPC.Messages.NewsFlash, global::gRoom.gRPC.Messages.NewsStreamStatus>(serviceImpl.SendNewsFlash));
      serviceBinder.AddMethod(__Method_StartMonitoring, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::gRoom.gRPC.Messages.ReceivedMessage>(serviceImpl.StartMonitoring));
      serviceBinder.AddMethod(__Method_StartChat, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::gRoom.gRPC.Messages.ChatMessage, global::gRoom.gRPC.Messages.ChatMessage>(serviceImpl.StartChat));
    }

  }
}
#endregion
