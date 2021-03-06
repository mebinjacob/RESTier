﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Restier.Core.Submit
{
    /// <summary>
    /// Represents a change set entry filter.
    /// </summary>
    public interface IChangeSetEntryFilter
    {
        /// <summary>
        /// Asynchronously applies logic before a change set entry is executed.
        /// </summary>
        /// <param name="context">
        /// The submit context.
        /// </param>
        /// <param name="entry">
        /// A change set entry.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        Task OnExecutingEntryAsync(
            SubmitContext context,
            ChangeSetEntry entry,
            CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously applies logic after a change set entry is executed.
        /// </summary>
        /// <param name="context">
        /// The submit context.
        /// </param>
        /// <param name="entry">
        /// A change set entry.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        Task OnExecutedEntryAsync(
            SubmitContext context,
            ChangeSetEntry entry,
            CancellationToken cancellationToken);
    }
}
