// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Contains the information necessary to perform a resource move (rename). </summary>
    public partial class SynapseResourceMoveDefinition
    {
        /// <summary> Initializes a new instance of SynapseResourceMoveDefinition. </summary>
        /// <param name="id"> The target ID for the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public SynapseResourceMoveDefinition(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> The target ID for the resource. </summary>
        public ResourceIdentifier Id { get; }
    }
}
