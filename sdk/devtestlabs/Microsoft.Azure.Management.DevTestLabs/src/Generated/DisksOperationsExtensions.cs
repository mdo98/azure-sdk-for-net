// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DisksOperations.
    /// </summary>
    public static partial class DisksOperationsExtensions
    {
            /// <summary>
            /// List disks in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Disk> List(this IDisksOperations operations, string resourceGroupName, string labName, string userName, ODataQuery<Disk> odataQuery = default(ODataQuery<Disk>))
            {
                return operations.ListAsync(resourceGroupName, labName, userName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List disks in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Disk>> ListAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, ODataQuery<Disk> odataQuery = default(ODataQuery<Disk>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, userName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=diskType)'
            /// </param>
            public static Disk Get(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, labName, userName, name, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get disk.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example: 'properties($select=diskType)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Disk> GetAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, labName, userName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing disk. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='disk'>
            /// A Disk.
            /// </param>
            public static Disk CreateOrUpdate(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, Disk disk)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, labName, userName, name, disk).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing disk. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='disk'>
            /// A Disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Disk> CreateOrUpdateAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, Disk disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete disk. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            public static void Delete(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.DeleteAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete disk. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Modify properties of disks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='disk'>
            /// A Disk.
            /// </param>
            public static Disk Update(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, DiskFragment disk)
            {
                return operations.UpdateAsync(resourceGroupName, labName, userName, name, disk).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Modify properties of disks.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='disk'>
            /// A Disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Disk> UpdateAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, DiskFragment disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Attach and create the lease of the disk to the virtual machine. This
            /// operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='attachDiskProperties'>
            /// Properties of the disk to attach.
            /// </param>
            public static void Attach(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, AttachDiskProperties attachDiskProperties)
            {
                operations.AttachAsync(resourceGroupName, labName, userName, name, attachDiskProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attach and create the lease of the disk to the virtual machine. This
            /// operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='attachDiskProperties'>
            /// Properties of the disk to attach.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AttachAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, AttachDiskProperties attachDiskProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AttachWithHttpMessagesAsync(resourceGroupName, labName, userName, name, attachDiskProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Detach and break the lease of the disk attached to the virtual machine.
            /// This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='detachDiskProperties'>
            /// Properties of the disk to detach.
            /// </param>
            public static void Detach(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, DetachDiskProperties detachDiskProperties)
            {
                operations.DetachAsync(resourceGroupName, labName, userName, name, detachDiskProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Detach and break the lease of the disk attached to the virtual machine.
            /// This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='detachDiskProperties'>
            /// Properties of the disk to detach.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DetachAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, DetachDiskProperties detachDiskProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DetachWithHttpMessagesAsync(resourceGroupName, labName, userName, name, detachDiskProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create or replace an existing disk. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='disk'>
            /// A Disk.
            /// </param>
            public static Disk BeginCreateOrUpdate(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, Disk disk)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, labName, userName, name, disk).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing disk. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='disk'>
            /// A Disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Disk> BeginCreateOrUpdateAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, Disk disk, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, labName, userName, name, disk, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete disk. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            public static void BeginDelete(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name)
            {
                operations.BeginDeleteAsync(resourceGroupName, labName, userName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete disk. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, labName, userName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Attach and create the lease of the disk to the virtual machine. This
            /// operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='attachDiskProperties'>
            /// Properties of the disk to attach.
            /// </param>
            public static void BeginAttach(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, AttachDiskProperties attachDiskProperties)
            {
                operations.BeginAttachAsync(resourceGroupName, labName, userName, name, attachDiskProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attach and create the lease of the disk to the virtual machine. This
            /// operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='attachDiskProperties'>
            /// Properties of the disk to attach.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginAttachAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, AttachDiskProperties attachDiskProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginAttachWithHttpMessagesAsync(resourceGroupName, labName, userName, name, attachDiskProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Detach and break the lease of the disk attached to the virtual machine.
            /// This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='detachDiskProperties'>
            /// Properties of the disk to detach.
            /// </param>
            public static void BeginDetach(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, DetachDiskProperties detachDiskProperties)
            {
                operations.BeginDetachAsync(resourceGroupName, labName, userName, name, detachDiskProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Detach and break the lease of the disk attached to the virtual machine.
            /// This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the disk.
            /// </param>
            /// <param name='detachDiskProperties'>
            /// Properties of the disk to detach.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDetachAsync(this IDisksOperations operations, string resourceGroupName, string labName, string userName, string name, DetachDiskProperties detachDiskProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDetachWithHttpMessagesAsync(resourceGroupName, labName, userName, name, detachDiskProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List disks in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Disk> ListNext(this IDisksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List disks in a given user profile.
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
            public static async Task<IPage<Disk>> ListNextAsync(this IDisksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}