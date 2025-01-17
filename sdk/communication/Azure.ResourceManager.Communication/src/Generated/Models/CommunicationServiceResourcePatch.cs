// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> A class representing update parameters for CommunicationService resource. </summary>
    public partial class CommunicationServiceResourcePatch : CommunicationAcceptTags
    {
        /// <summary> Initializes a new instance of CommunicationServiceResourcePatch. </summary>
        public CommunicationServiceResourcePatch()
        {
            LinkedDomains = new ChangeTrackingList<string>();
        }

        /// <summary> List of email Domain resource Ids. </summary>
        public IList<string> LinkedDomains { get; }
    }
}
