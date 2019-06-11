// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LiveEventsOperations operations.
    /// </summary>
    public partial interface ILiveEventsOperations
    {
        /// <summary>
        /// List Live Events
        /// </summary>
        /// <remarks>
        /// Lists the Live Events in the account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LiveEvent>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get Live Event
        /// </summary>
        /// <remarks>
        /// Gets a Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LiveEvent>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create Live Event
        /// </summary>
        /// <remarks>
        /// Creates a Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='parameters'>
        /// Live Event properties needed for creation.
        /// </param>
        /// <param name='autoStart'>
        /// The flag indicates if the resource should be automatically started
        /// on creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LiveEvent>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, LiveEvent parameters, bool? autoStart = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a existing Live Event.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='parameters'>
        /// Live Event properties needed for creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LiveEvent>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, LiveEvent parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Live Event
        /// </summary>
        /// <remarks>
        /// Deletes a Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start Live Event
        /// </summary>
        /// <remarks>
        /// Starts an existing Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop Live Event
        /// </summary>
        /// <remarks>
        /// Stops an existing Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='removeOutputsOnStop'>
        /// The flag indicates if remove LiveOutputs on Stop.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StopWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, bool? removeOutputsOnStop = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset Live Event
        /// </summary>
        /// <remarks>
        /// Resets an existing Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResetWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create Live Event
        /// </summary>
        /// <remarks>
        /// Creates a Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='parameters'>
        /// Live Event properties needed for creation.
        /// </param>
        /// <param name='autoStart'>
        /// The flag indicates if the resource should be automatically started
        /// on creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LiveEvent>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, LiveEvent parameters, bool? autoStart = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a existing Live Event.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='parameters'>
        /// Live Event properties needed for creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<LiveEvent>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, LiveEvent parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Live Event
        /// </summary>
        /// <remarks>
        /// Deletes a Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start Live Event
        /// </summary>
        /// <remarks>
        /// Starts an existing Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop Live Event
        /// </summary>
        /// <remarks>
        /// Stops an existing Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='removeOutputsOnStop'>
        /// The flag indicates if remove LiveOutputs on Stop.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, bool? removeOutputsOnStop = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset Live Event
        /// </summary>
        /// <remarks>
        /// Resets an existing Live Event.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the Azure subscription.
        /// </param>
        /// <param name='accountName'>
        /// The Media Services account name.
        /// </param>
        /// <param name='liveEventName'>
        /// The name of the Live Event.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginResetWithHttpMessagesAsync(string resourceGroupName, string accountName, string liveEventName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List Live Events
        /// </summary>
        /// <remarks>
        /// Lists the Live Events in the account.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<LiveEvent>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}