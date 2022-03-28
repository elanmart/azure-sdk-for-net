// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkWatcherResource" /> and their operations.
    /// Each <see cref="NetworkWatcherResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkWatcherCollection" /> instance call the GetNetworkWatchers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkWatcherCollection : ArmCollection, IEnumerable<NetworkWatcherResource>, IAsyncEnumerable<NetworkWatcherResource>
    {
        private readonly ClientDiagnostics _networkWatcherClientDiagnostics;
        private readonly NetworkWatchersRestOperations _networkWatcherRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkWatcherCollection"/> class for mocking. </summary>
        protected NetworkWatcherCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkWatcherCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkWatcherCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkWatcherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkWatcherResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkWatcherResource.ResourceType, out string networkWatcherApiVersion);
            _networkWatcherRestClient = new NetworkWatchersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkWatcherApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network watcher in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="data"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkWatcherResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkWatcherName, NetworkWatcherData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkWatcherRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkWatcherResource>(Response.FromValue(new NetworkWatcherResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a network watcher in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="data"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkWatcherResource> CreateOrUpdate(WaitUntil waitUntil, string networkWatcherName, NetworkWatcherData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkWatcherRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkWatcherResource>(Response.FromValue(new NetworkWatcherResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network watcher by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual async Task<Response<NetworkWatcherResource>> GetAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network watcher by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<NetworkWatcherResource> Get(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = _networkWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all network watchers by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers
        /// Operation Id: NetworkWatchers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkWatcherResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkWatcherResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkWatcherResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkWatcherRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcherResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets all network watchers by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers
        /// Operation Id: NetworkWatchers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkWatcherResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkWatcherResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkWatcherResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkWatcherRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcherResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkWatcherName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual async Task<Response<NetworkWatcherResource>> GetIfExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkWatcherResource>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<NetworkWatcherResource> GetIfExists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkWatcherResource>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkWatcherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkWatcherResource> IEnumerable<NetworkWatcherResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkWatcherResource> IAsyncEnumerable<NetworkWatcherResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
