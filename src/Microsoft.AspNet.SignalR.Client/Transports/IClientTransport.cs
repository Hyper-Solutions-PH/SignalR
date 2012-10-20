﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Threading.Tasks;
using System.Threading;

namespace Microsoft.AspNet.SignalR.Client.Transports
{
    public interface IClientTransport
    {
        Task<NegotiationResponse> Negotiate(IConnection connection);
        Task Start(IConnection connection, string data);
        Task<T> Send<T>(IConnection connection, string data);
        void Stop(IConnection connection);
    }
}
