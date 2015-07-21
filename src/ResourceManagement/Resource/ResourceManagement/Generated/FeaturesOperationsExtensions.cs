namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class FeaturesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Page<FeatureResult> ListAll(this IFeaturesOperations operations)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<FeatureResult>> ListAllAsync( this IFeaturesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<FeatureResult>> result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            public static Page<FeatureResult> List(this IFeaturesOperations operations, string resourceProviderNamespace)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListAsync(resourceProviderNamespace), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<FeatureResult>> ListAsync( this IFeaturesOperations operations, string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<FeatureResult>> result = await operations.ListWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get all features under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            public static FeatureResult Get(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).GetAsync(resourceProviderNamespace, featureName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all features under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<FeatureResult> GetAsync( this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<FeatureResult> result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, featureName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Registers for a previewed feature of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            public static FeatureResult Register(this IFeaturesOperations operations, string resourceProviderNamespace, string featureName)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).RegisterAsync(resourceProviderNamespace, featureName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers for a previewed feature of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Namespace of the resource provider.
            /// </param>
            /// <param name='featureName'>
            /// Previewed feature name in the resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<FeatureResult> RegisterAsync( this IFeaturesOperations operations, string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<FeatureResult> result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, featureName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<FeatureResult> ListAllNext(this IFeaturesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListAllNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features for all the providers in the current
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<FeatureResult>> ListAllNextAsync( this IFeaturesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<FeatureResult>> result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<FeatureResult> ListNext(this IFeaturesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IFeaturesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of previewed features of a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<FeatureResult>> ListNextAsync( this IFeaturesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<FeatureResult>> result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}