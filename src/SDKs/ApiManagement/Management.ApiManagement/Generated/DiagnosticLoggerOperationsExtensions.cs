// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiagnosticLoggerOperations.
    /// </summary>
    public static partial class DiagnosticLoggerOperationsExtensions
    {
            /// <summary>
            /// Lists all loggers associated with the specified Diagnostic of the API
            /// Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<LoggerContract> ListByService(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, ODataQuery<LoggerContract> odataQuery = default(ODataQuery<LoggerContract>))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, diagnosticId, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all loggers associated with the specified Diagnostic of the API
            /// Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LoggerContract>> ListByServiceAsync(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, ODataQuery<LoggerContract> odataQuery = default(ODataQuery<LoggerContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks that logger entity specified by identifier is associated with the
            /// diagnostics entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            public static bool CheckEntityExists(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, string loggerid)
            {
                return operations.CheckEntityExistsAsync(resourceGroupName, serviceName, diagnosticId, loggerid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that logger entity specified by identifier is associated with the
            /// diagnostics entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool> CheckEntityExistsAsync(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, string loggerid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckEntityExistsWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, loggerid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Attaches a logger to a diagnostic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            public static LoggerContract CreateOrUpdate(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, string loggerid)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, diagnosticId, loggerid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attaches a logger to a diagnostic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LoggerContract> CreateOrUpdateAsync(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, string loggerid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, loggerid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Logger from Diagnostic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            public static void Delete(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, string loggerid)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, diagnosticId, loggerid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Logger from Diagnostic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='diagnosticId'>
            /// Diagnostic identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDiagnosticLoggerOperations operations, string resourceGroupName, string serviceName, string diagnosticId, string loggerid, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, diagnosticId, loggerid, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all loggers associated with the specified Diagnostic of the API
            /// Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LoggerContract> ListByServiceNext(this IDiagnosticLoggerOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all loggers associated with the specified Diagnostic of the API
            /// Management service instance.
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
            public static async Task<IPage<LoggerContract>> ListByServiceNextAsync(this IDiagnosticLoggerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}