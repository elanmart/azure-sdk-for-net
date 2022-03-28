// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The publishing profile of a gallery image Version. </summary>
    public partial class GalleryImageVersionPublishingProfile : GalleryArtifactPublishingProfileBase
    {
        /// <summary> Initializes a new instance of GalleryImageVersionPublishingProfile. </summary>
        public GalleryImageVersionPublishingProfile()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageVersionPublishingProfile. </summary>
        /// <param name="targetRegions"> The target regions where the Image Version is going to be replicated to. This property is updatable. </param>
        /// <param name="replicaCount"> The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable. </param>
        /// <param name="excludeFromLatest"> If set to true, Virtual Machines deployed from the latest version of the Image Definition won&apos;t use this Image Version. </param>
        /// <param name="publishedOn"> The timestamp for when the gallery image version is published. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="storageAccountType"> Specifies the storage account type to be used to store the image. This property is not updatable. </param>
        /// <param name="replicationMode"> Optional parameter which specifies the mode to be used for replication. This property is not updatable. </param>
        internal GalleryImageVersionPublishingProfile(IList<TargetRegion> targetRegions, int? replicaCount, bool? excludeFromLatest, DateTimeOffset? publishedOn, DateTimeOffset? endOfLifeOn, StorageAccountType? storageAccountType, ReplicationMode? replicationMode) : base(targetRegions, replicaCount, excludeFromLatest, publishedOn, endOfLifeOn, storageAccountType, replicationMode)
        {
        }
    }
}
