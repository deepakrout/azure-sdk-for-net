// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableSelfHelpSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _discoverySolutionNLPSubscriptionScopeClientDiagnostics;
        private DiscoverySolutionNLPSubscriptionScopeRestOperations _discoverySolutionNLPSubscriptionScopeRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSelfHelpSubscriptionResource"/> class for mocking. </summary>
        protected MockableSelfHelpSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSelfHelpSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSelfHelpSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DiscoverySolutionNLPSubscriptionScopeClientDiagnostics => _discoverySolutionNLPSubscriptionScopeClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SelfHelp", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DiscoverySolutionNLPSubscriptionScopeRestOperations DiscoverySolutionNLPSubscriptionScopeRestClient => _discoverySolutionNLPSubscriptionScopeRestClient ??= new DiscoverySolutionNLPSubscriptionScopeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Help/discoverSolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolutionNLPSubscriptionScope_Post</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for discovering solutions using NLP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SolutionNlpMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SolutionNlpMetadata> PostDiscoverySolutionNLPSubscriptionScopesAsync(DiscoveryNlpContent content = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionNLPSubscriptionScopeRestClient.CreatePostRequest(Id.SubscriptionId, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => SolutionNlpMetadata.DeserializeSolutionNlpMetadata(e), DiscoverySolutionNLPSubscriptionScopeClientDiagnostics, Pipeline, "MockableSelfHelpSubscriptionResource.PostDiscoverySolutionNLPSubscriptionScopes", "value", null, cancellationToken);
        }

        /// <summary>
        /// Search for relevant Azure Diagnostics, Solutions and Troubleshooters using a natural language issue summary and subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Help/discoverSolutions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySolutionNLPSubscriptionScope_Post</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for discovering solutions using NLP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SolutionNlpMetadata"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SolutionNlpMetadata> PostDiscoverySolutionNLPSubscriptionScopes(DiscoveryNlpContent content = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiscoverySolutionNLPSubscriptionScopeRestClient.CreatePostRequest(Id.SubscriptionId, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => SolutionNlpMetadata.DeserializeSolutionNlpMetadata(e), DiscoverySolutionNLPSubscriptionScopeClientDiagnostics, Pipeline, "MockableSelfHelpSubscriptionResource.PostDiscoverySolutionNLPSubscriptionScopes", "value", null, cancellationToken);
        }
    }
}
