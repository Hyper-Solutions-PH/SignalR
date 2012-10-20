﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Collections.Generic;
using System.Linq;

namespace Microsoft.AspNet.SignalR.Hubs
{
    public class HubOutgoingInvokerContext : IHubOutgoingInvokerContext
    {        
        public HubOutgoingInvokerContext(IConnection connection, string signal, ClientHubInvocation invocation, IEnumerable<string> excludedSignals)
        {
            Connection = connection;
            Signal = signal;
            Invocation = invocation;
            ExcludedSignals = excludedSignals;
        }

        public IConnection Connection
        {
            get;
            private set;
        }

        public ClientHubInvocation Invocation
        {
            get;
            private set;
        }

        public string Signal
        {
            get;
            private set;
        }

        public IEnumerable<string> ExcludedSignals
        {
            get;
            private set;
        }
    }
}
