// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServiceLibrary.Protos {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Customer
  {
    static readonly string __ServiceName = "greet.Customer";

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
    static readonly grpc::Marshaller<global::GrpcServiceLibrary.Protos.GetCustomersRequest> __Marshaller_greet_GetCustomersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceLibrary.Protos.GetCustomersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceLibrary.Protos.GetCustomersResponse> __Marshaller_greet_GetCustomersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceLibrary.Protos.GetCustomersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceLibrary.Protos.GetCustomerByIdRequest> __Marshaller_greet_GetCustomerByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceLibrary.Protos.GetCustomerByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServiceLibrary.Protos.GetCustomerByIdResponse> __Marshaller_greet_GetCustomerByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServiceLibrary.Protos.GetCustomerByIdResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceLibrary.Protos.GetCustomersRequest, global::GrpcServiceLibrary.Protos.GetCustomersResponse> __Method_GetCustomers = new grpc::Method<global::GrpcServiceLibrary.Protos.GetCustomersRequest, global::GrpcServiceLibrary.Protos.GetCustomersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomers",
        __Marshaller_greet_GetCustomersRequest,
        __Marshaller_greet_GetCustomersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServiceLibrary.Protos.GetCustomerByIdRequest, global::GrpcServiceLibrary.Protos.GetCustomerByIdResponse> __Method_GetCustomerById = new grpc::Method<global::GrpcServiceLibrary.Protos.GetCustomerByIdRequest, global::GrpcServiceLibrary.Protos.GetCustomerByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerById",
        __Marshaller_greet_GetCustomerByIdRequest,
        __Marshaller_greet_GetCustomerByIdResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServiceLibrary.Protos.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Customer</summary>
    [grpc::BindServiceMethod(typeof(Customer), "BindService")]
    public abstract partial class CustomerBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceLibrary.Protos.GetCustomersResponse> GetCustomers(global::GrpcServiceLibrary.Protos.GetCustomersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServiceLibrary.Protos.GetCustomerByIdResponse> GetCustomerById(global::GrpcServiceLibrary.Protos.GetCustomerByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CustomerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomers, serviceImpl.GetCustomers)
          .AddMethod(__Method_GetCustomerById, serviceImpl.GetCustomerById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceLibrary.Protos.GetCustomersRequest, global::GrpcServiceLibrary.Protos.GetCustomersResponse>(serviceImpl.GetCustomers));
      serviceBinder.AddMethod(__Method_GetCustomerById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServiceLibrary.Protos.GetCustomerByIdRequest, global::GrpcServiceLibrary.Protos.GetCustomerByIdResponse>(serviceImpl.GetCustomerById));
    }

  }
}
#endregion