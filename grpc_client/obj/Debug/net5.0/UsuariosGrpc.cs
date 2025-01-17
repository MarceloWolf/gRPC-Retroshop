// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: usuarios.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class Usuarios
{
  static readonly string __ServiceName = "Usuarios";

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
  static readonly grpc::Marshaller<global::Nulo> __Marshaller_Nulo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Nulo.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::Username> __Marshaller_Username = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Username.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::Usuario> __Marshaller_Usuario = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Usuario.Parser));
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Marshaller<global::Response> __Marshaller_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Response.Parser));

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::Nulo, global::Nulo> __Method_Listo = new grpc::Method<global::Nulo, global::Nulo>(
      grpc::MethodType.Unary,
      __ServiceName,
      "Listo",
      __Marshaller_Nulo,
      __Marshaller_Nulo);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::Username, global::Usuario> __Method_TraerUsuario = new grpc::Method<global::Username, global::Usuario>(
      grpc::MethodType.Unary,
      __ServiceName,
      "TraerUsuario",
      __Marshaller_Username,
      __Marshaller_Usuario);

  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  static readonly grpc::Method<global::Usuario, global::Response> __Method_AltaUsuario = new grpc::Method<global::Usuario, global::Response>(
      grpc::MethodType.Unary,
      __ServiceName,
      "AltaUsuario",
      __Marshaller_Usuario,
      __Marshaller_Response);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::UsuariosReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of Usuarios</summary>
  [grpc::BindServiceMethod(typeof(Usuarios), "BindService")]
  public abstract partial class UsuariosBase
  {
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::Nulo> Listo(global::Nulo request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    /// <summary>
    ///rpc RegistraOrden(Orden) returns (ConfirmacionOrden);
    /// </summary>
    /// <param name="request">The request received from the client.</param>
    /// <param name="context">The context of the server-side call handler being invoked.</param>
    /// <returns>The response to send back to the client (wrapped by a task).</returns>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::Usuario> TraerUsuario(global::Username request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::System.Threading.Tasks.Task<global::Response> AltaUsuario(global::Usuario request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for Usuarios</summary>
  public partial class UsuariosClient : grpc::ClientBase<UsuariosClient>
  {
    /// <summary>Creates a new client for Usuarios</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public UsuariosClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for Usuarios that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public UsuariosClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected UsuariosClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected UsuariosClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Nulo Listo(global::Nulo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return Listo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Nulo Listo(global::Nulo request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_Listo, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Nulo> ListoAsync(global::Nulo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return ListoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Nulo> ListoAsync(global::Nulo request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_Listo, null, options, request);
    }
    /// <summary>
    ///rpc RegistraOrden(Orden) returns (ConfirmacionOrden);
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
    /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
    /// <param name="cancellationToken">An optional token for canceling the call.</param>
    /// <returns>The response received from the server.</returns>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Usuario TraerUsuario(global::Username request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TraerUsuario(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    /// <summary>
    ///rpc RegistraOrden(Orden) returns (ConfirmacionOrden);
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="options">The options for the call.</param>
    /// <returns>The response received from the server.</returns>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Usuario TraerUsuario(global::Username request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_TraerUsuario, null, options, request);
    }
    /// <summary>
    ///rpc RegistraOrden(Orden) returns (ConfirmacionOrden);
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
    /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
    /// <param name="cancellationToken">An optional token for canceling the call.</param>
    /// <returns>The call object.</returns>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Usuario> TraerUsuarioAsync(global::Username request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return TraerUsuarioAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    /// <summary>
    ///rpc RegistraOrden(Orden) returns (ConfirmacionOrden);
    /// </summary>
    /// <param name="request">The request to send to the server.</param>
    /// <param name="options">The options for the call.</param>
    /// <returns>The call object.</returns>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Usuario> TraerUsuarioAsync(global::Username request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_TraerUsuario, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response AltaUsuario(global::Usuario request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return AltaUsuario(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual global::Response AltaUsuario(global::Usuario request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_AltaUsuario, null, options, request);
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> AltaUsuarioAsync(global::Usuario request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return AltaUsuarioAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public virtual grpc::AsyncUnaryCall<global::Response> AltaUsuarioAsync(global::Usuario request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_AltaUsuario, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    protected override UsuariosClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new UsuariosClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  public static grpc::ServerServiceDefinition BindService(UsuariosBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_Listo, serviceImpl.Listo)
        .AddMethod(__Method_TraerUsuario, serviceImpl.TraerUsuario)
        .AddMethod(__Method_AltaUsuario, serviceImpl.AltaUsuario).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
  public static void BindService(grpc::ServiceBinderBase serviceBinder, UsuariosBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_Listo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Nulo, global::Nulo>(serviceImpl.Listo));
    serviceBinder.AddMethod(__Method_TraerUsuario, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Username, global::Usuario>(serviceImpl.TraerUsuario));
    serviceBinder.AddMethod(__Method_AltaUsuario, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Usuario, global::Response>(serviceImpl.AltaUsuario));
  }

}
#endregion
