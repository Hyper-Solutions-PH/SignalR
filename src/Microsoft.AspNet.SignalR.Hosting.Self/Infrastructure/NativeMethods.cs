﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.AspNet.SignalR.Hosting.Self.Infrastructure
{
    internal static class NativeMethods
    {
        [DllImport("httpapi.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true, ExactSpelling = true)]
        internal static extern unsafe uint HttpWaitForDisconnect(CriticalHandle requestQueueHandle, ulong connectionId, NativeOverlapped* pOverlapped);

        internal static class HttpErrors
        {
            public const int NO_ERROR = 0x0;
            public const int ERROR_IO_PENDING = 0x3E5;
        }
    }
}
