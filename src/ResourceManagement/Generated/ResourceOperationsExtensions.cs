// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Resources
{
    public static partial class ResourceOperationsExtensions
    {
        /// <summary>
        /// Checks whether resource exists.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static ResourceExistsResult CheckExistence(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).CheckExistenceAsync(resourceGroupName, identity);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Checks whether resource exists.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static Task<ResourceExistsResult> CheckExistenceAsync(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return operations.CheckExistenceAsync(resourceGroupName, identity, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create or update resource parameters.
        /// </param>
        /// <returns>
        /// Resource information.
        /// </returns>
        public static ResourceCreateOrUpdateResult CreateOrUpdate(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity, BasicResource parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).CreateOrUpdateAsync(resourceGroupName, identity, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create or update resource parameters.
        /// </param>
        /// <returns>
        /// Resource information.
        /// </returns>
        public static Task<ResourceCreateOrUpdateResult> CreateOrUpdateAsync(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity, BasicResource parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, identity, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete resource and all of its resources.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).DeleteAsync(resourceGroupName, identity);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete resource and all of its resources.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return operations.DeleteAsync(resourceGroupName, identity, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// Resource information.
        /// </returns>
        public static ResourceGetResult Get(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).GetAsync(resourceGroupName, identity);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// Resource information.
        /// </returns>
        public static Task<ResourceGetResult> GetAsync(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return operations.GetAsync(resourceGroupName, identity, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a resource permissions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// Resource group permissions information.
        /// </returns>
        public static PermissionGetResult GetPermissions(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).GetPermissionsAsync(resourceGroupName, identity);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a resource permissions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <returns>
        /// Resource group permissions information.
        /// </returns>
        public static Task<PermissionGetResult> GetPermissionsAsync(this IResourceOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return operations.GetPermissionsAsync(resourceGroupName, identity, CancellationToken.None);
        }
        
        /// <summary>
        /// Get all of the resources under a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all resource
        /// groups.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static ResourceListResult List(this IResourceOperations operations, ResourceListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).ListAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get all of the resources under a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all resource
        /// groups.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static Task<ResourceListResult> ListAsync(this IResourceOperations operations, ResourceListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static ResourceListResult ListNext(this IResourceOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static Task<ResourceListResult> ListNextAsync(this IResourceOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
