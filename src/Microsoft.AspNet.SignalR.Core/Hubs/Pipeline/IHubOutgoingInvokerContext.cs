﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Collections.Generic;
namespace Microsoft.AspNet.SignalR.Hubs
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHubOutgoingInvokerContext
    {
        /// <summary>
        /// 
        /// </summary>
        IConnection Connection { get; }

        /// <summary>
        /// 
        /// </summary>
        ClientHubInvocation Invocation { get; }

        /// <summary>
        /// 
        /// </summary>
        string Signal { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<string> ExcludedSignals { get; }
    }
}
