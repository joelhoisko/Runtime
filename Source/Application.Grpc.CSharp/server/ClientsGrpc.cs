// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: dolittle/application/server/clients.proto
// </auto-generated>
// Original file comments:
// ---------------------------------------------------------------------------------------------
//  Copyright (c) Dolittle. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// --------------------------------------------------------------------------------------------
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Dolittle.Runtime.Application.Grpc.Server {
  /// <summary>
  /// Represents the Client service
  /// </summary>
  public static partial class Clients
  {
    static readonly string __ServiceName = "dolittle.runtime.application.server.Clients";

    static readonly grpc::Marshaller<global::Dolittle.Runtime.Application.Grpc.ClientInfo> __Marshaller_dolittle_runtime_application_ClientInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dolittle.Runtime.Application.Grpc.ClientInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Dolittle.Runtime.Application.Grpc.ClientInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Connect = new grpc::Method<global::Dolittle.Runtime.Application.Grpc.ClientInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Connect",
        __Marshaller_dolittle_runtime_application_ClientInfo,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dolittle.Runtime.Application.Grpc.Server.ClientsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Clients</summary>
    [grpc::BindServiceMethod(typeof(Clients), "BindService")]
    public abstract partial class ClientsBase
    {
      public virtual global::System.Threading.Tasks.Task Connect(global::Dolittle.Runtime.Application.Grpc.ClientInfo request, grpc::IServerStreamWriter<global::Google.Protobuf.WellKnownTypes.Empty> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Clients</summary>
    public partial class ClientsClient : grpc::ClientBase<ClientsClient>
    {
      /// <summary>Creates a new client for Clients</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ClientsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Clients that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ClientsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ClientsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ClientsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Google.Protobuf.WellKnownTypes.Empty> Connect(global::Dolittle.Runtime.Application.Grpc.ClientInfo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Connect(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Google.Protobuf.WellKnownTypes.Empty> Connect(global::Dolittle.Runtime.Application.Grpc.ClientInfo request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Connect, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ClientsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ClientsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Connect, serviceImpl.Connect).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClientsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Connect, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Dolittle.Runtime.Application.Grpc.ClientInfo, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Connect));
    }

  }
}
#endregion
