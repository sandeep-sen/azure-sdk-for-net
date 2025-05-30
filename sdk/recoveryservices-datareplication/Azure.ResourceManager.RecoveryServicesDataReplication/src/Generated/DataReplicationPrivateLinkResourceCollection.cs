// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="DataReplicationPrivateLinkResource"/> and their operations.
    /// Each <see cref="DataReplicationPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="DataReplicationVaultResource"/>.
    /// To get a <see cref="DataReplicationPrivateLinkResourceCollection"/> instance call the GetDataReplicationPrivateLinkResources method from an instance of <see cref="DataReplicationVaultResource"/>.
    /// </summary>
    public partial class DataReplicationPrivateLinkResourceCollection : ArmCollection, IEnumerable<DataReplicationPrivateLinkResource>, IAsyncEnumerable<DataReplicationPrivateLinkResource>
    {
        private readonly ClientDiagnostics _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataReplicationPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected DataReplicationPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataReplicationPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataReplicationPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", DataReplicationPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataReplicationPrivateLinkResource.ResourceType, out string dataReplicationPrivateLinkResourcePrivateLinkResourcesApiVersion);
            _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataReplicationPrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataReplicationVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataReplicationVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of site recovery private link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The private link name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<DataReplicationPrivateLinkResource>> GetAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DataReplicationPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of site recovery private link resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The private link name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<DataReplicationPrivateLinkResource> Get(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DataReplicationPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataReplicationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of private link resources.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataReplicationPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataReplicationPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataReplicationPrivateLinkResource(Client, DataReplicationPrivateLinkResourceData.DeserializeDataReplicationPrivateLinkResourceData(e)), _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "DataReplicationPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of private link resources.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataReplicationPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataReplicationPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataReplicationPrivateLinkResource(Client, DataReplicationPrivateLinkResourceData.DeserializeDataReplicationPrivateLinkResourceData(e)), _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "DataReplicationPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The private link name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DataReplicationPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The private link name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DataReplicationPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The private link name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataReplicationPrivateLinkResource>> GetIfExistsAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DataReplicationPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> The private link name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual NullableResponse<DataReplicationPrivateLinkResource> GetIfExists(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _dataReplicationPrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("DataReplicationPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataReplicationPrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataReplicationPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new DataReplicationPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataReplicationPrivateLinkResource> IEnumerable<DataReplicationPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataReplicationPrivateLinkResource> IAsyncEnumerable<DataReplicationPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
