﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Diagnostics;

namespace Microsoft.AspNet.SignalR.Client
{
    [DebuggerDisplay("{ConnectionId} {Url} -> {ProtocolVersion}")]
    public class NegotiationResponse
    {
        public string ConnectionId { get; set; }
        public string Url { get; set; }
        public string ProtocolVersion { get; set; }
    }
}
