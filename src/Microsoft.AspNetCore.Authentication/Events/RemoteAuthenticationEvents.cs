// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
    public class RemoteAuthenticationEvents : IRemoteAuthenticationEvents
    {
        public Func<FailureContext, Task> OnRemoteFailure { get; set; } = context => Task.FromResult(0);

        public Func<TicketReceivedContext, Task> OnTicketReceived { get; set; } = context => Task.FromResult(0);

        /// <summary>
        /// Invoked when there is a remote failure
        /// </summary>
        public virtual Task RemoteFailure(FailureContext context) => OnRemoteFailure(context);

        /// <summary>
        /// Invoked after the remote ticket has been received.
        /// </summary>
        public virtual Task TicketReceived(TicketReceivedContext context) => OnTicketReceived(context);
    }
}