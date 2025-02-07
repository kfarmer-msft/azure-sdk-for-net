﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.ComponentModel;

namespace Azure.Storage.Common
{
    /// <summary>
    /// <see cref="ParallelTransferOptions"/> is used to provide options for parallel transfers.
    /// </summary>
    public struct ParallelTransferOptions : IEquatable<ParallelTransferOptions>
    {
        /// <summary>
        /// The maximum length of an upload block in bytes.
        /// </summary>
        public int? MaximumBlockLength { get; set; }

        /// <summary>
        /// The maximum number of threads that may be used in a parallel transfer.
        /// </summary>
        public int? MaximumThreadCount { get; set; }

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
            => obj is ParallelTransferOptions other
            && this.Equals(other)
            ;

        /// <summary>
        /// Get a hash code for the ParallelTransferOptions.
        /// </summary>
        /// <returns>Hash code for the ParallelTransferOptions.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
            => this.MaximumBlockLength.GetHashCode()
            ^ this.MaximumThreadCount.GetHashCode()
            ;

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool operator ==(ParallelTransferOptions left, ParallelTransferOptions right) => left.Equals(right);

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're not equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool operator !=(ParallelTransferOptions left, ParallelTransferOptions right) => !(left == right);

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(ParallelTransferOptions obj)
            => this.MaximumBlockLength == obj.MaximumBlockLength
            && this.MaximumThreadCount == obj.MaximumThreadCount
            ;
    }
}
