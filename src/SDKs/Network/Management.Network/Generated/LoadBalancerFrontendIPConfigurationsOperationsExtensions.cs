// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LoadBalancerFrontendIPConfigurationsOperations.
    /// </summary>
    public static partial class LoadBalancerFrontendIPConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Gets all the load balancer frontend IP configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            public static IPage<FrontendIPConfiguration> List(this ILoadBalancerFrontendIPConfigurationsOperations operations, string resourceGroupName, string loadBalancerName)
            {
                return operations.ListAsync(resourceGroupName, loadBalancerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the load balancer frontend IP configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FrontendIPConfiguration>> ListAsync(this ILoadBalancerFrontendIPConfigurationsOperations operations, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, loadBalancerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets load balancer frontend IP configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            /// <param name='frontendIPConfigurationName'>
            /// The name of the frontend IP configuration.
            /// </param>
            public static FrontendIPConfiguration Get(this ILoadBalancerFrontendIPConfigurationsOperations operations, string resourceGroupName, string loadBalancerName, string frontendIPConfigurationName)
            {
                return operations.GetAsync(resourceGroupName, loadBalancerName, frontendIPConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets load balancer frontend IP configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='loadBalancerName'>
            /// The name of the load balancer.
            /// </param>
            /// <param name='frontendIPConfigurationName'>
            /// The name of the frontend IP configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FrontendIPConfiguration> GetAsync(this ILoadBalancerFrontendIPConfigurationsOperations operations, string resourceGroupName, string loadBalancerName, string frontendIPConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, loadBalancerName, frontendIPConfigurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the load balancer frontend IP configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FrontendIPConfiguration> ListNext(this ILoadBalancerFrontendIPConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the load balancer frontend IP configurations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FrontendIPConfiguration>> ListNextAsync(this ILoadBalancerFrontendIPConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}