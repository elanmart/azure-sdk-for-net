// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Secrets related to a Machine Learning compute based on Databricks. </summary>
    public partial class MachineLearningDatabricksComputeSecrets : MachineLearningComputeSecrets
    {
        /// <summary> Initializes a new instance of MachineLearningDatabricksComputeSecrets. </summary>
        internal MachineLearningDatabricksComputeSecrets()
        {
            ComputeType = ComputeType.Databricks;
        }

        /// <summary> Initializes a new instance of MachineLearningDatabricksComputeSecrets. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="databricksAccessToken"> access token for databricks account. </param>
        internal MachineLearningDatabricksComputeSecrets(ComputeType computeType, string databricksAccessToken) : base(computeType)
        {
            DatabricksAccessToken = databricksAccessToken;
            ComputeType = computeType;
        }

        /// <summary> access token for databricks account. </summary>
        public string DatabricksAccessToken { get; }
    }
}
