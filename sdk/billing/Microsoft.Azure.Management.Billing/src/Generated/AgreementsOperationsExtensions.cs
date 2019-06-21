// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AgreementsOperations.
    /// </summary>
    public static partial class AgreementsOperationsExtensions
    {
            /// <summary>
            /// Lists all agreements for a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the participants.
            /// </param>
            public static AgreementListResult ListByBillingAccountName(this IAgreementsOperations operations, string billingAccountName, string expand = default(string))
            {
                return operations.ListByBillingAccountNameAsync(billingAccountName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all agreements for a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the participants.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgreementListResult> ListByBillingAccountNameAsync(this IAgreementsOperations operations, string billingAccountName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountNameWithHttpMessagesAsync(billingAccountName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the agreement by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='agreementName'>
            /// Agreement Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the participants.
            /// </param>
            public static Agreement Get(this IAgreementsOperations operations, string billingAccountName, string agreementName, string expand = default(string))
            {
                return operations.GetAsync(billingAccountName, agreementName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the agreement by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='agreementName'>
            /// Agreement Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the participants.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Agreement> GetAsync(this IAgreementsOperations operations, string billingAccountName, string agreementName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, agreementName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}