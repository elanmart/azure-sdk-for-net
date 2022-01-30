// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Create or update a managed Cassandra cluster. When updating, you must specify all writable properties. To update only some properties, use PATCH. </summary>
    public partial class ClusterResourceCreateOrUpdateOperation : Operation<ClusterResource>, IOperationSource<ClusterResource>
    {
        private readonly OperationInternals<ClusterResource> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of ClusterResourceCreateOrUpdateOperation for mocking. </summary>
        protected ClusterResourceCreateOrUpdateOperation()
        {
        }

        internal ClusterResourceCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ClusterResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ClusterResourceCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ClusterResource Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ClusterResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ClusterResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ClusterResource IOperationSource<ClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ClusterResourceData.DeserializeClusterResourceData(document.RootElement);
            return new ClusterResource(_armClient, data);
        }

        async ValueTask<ClusterResource> IOperationSource<ClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ClusterResourceData.DeserializeClusterResourceData(document.RootElement);
            return new ClusterResource(_armClient, data);
        }
    }
}
