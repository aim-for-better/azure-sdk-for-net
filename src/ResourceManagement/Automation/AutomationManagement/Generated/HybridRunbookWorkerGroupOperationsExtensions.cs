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
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class HybridRunbookWorkerGroupOperationsExtensions
    {
        /// <summary>
        /// Retrieve a hybrid runbook worker group.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='hybridRunbookWorkerGroupName'>
        /// Required. The hybrid runbook worker group name
        /// </param>
        /// <returns>
        /// The response model for the get hybrid runbook worker group
        /// operation.
        /// </returns>
        public static HybridRunbookWorkerGroupGetResponse Get(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccount, string hybridRunbookWorkerGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IHybridRunbookWorkerGroupOperations)s).GetAsync(resourceGroupName, automationAccount, hybridRunbookWorkerGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a hybrid runbook worker group.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='hybridRunbookWorkerGroupName'>
        /// Required. The hybrid runbook worker group name
        /// </param>
        /// <returns>
        /// The response model for the get hybrid runbook worker group
        /// operation.
        /// </returns>
        public static Task<HybridRunbookWorkerGroupGetResponse> GetAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccount, string hybridRunbookWorkerGroupName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, hybridRunbookWorkerGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of hybrid runbook worker groups.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list hybrid runbook worker groups.
        /// </returns>
        public static HybridRunbookWorkerGroupsListResponse List(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IHybridRunbookWorkerGroupOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of hybrid runbook worker groups.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list hybrid runbook worker groups.
        /// </returns>
        public static Task<HybridRunbookWorkerGroupsListResponse> ListAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of hybrid runbook worker groups.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list hybrid runbook worker groups.
        /// </returns>
        public static HybridRunbookWorkerGroupsListResponse ListNext(this IHybridRunbookWorkerGroupOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IHybridRunbookWorkerGroupOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of hybrid runbook worker groups.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list hybrid runbook worker groups.
        /// </returns>
        public static Task<HybridRunbookWorkerGroupsListResponse> ListNextAsync(this IHybridRunbookWorkerGroupOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update a hybrid runbook worker group.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='hybridRunbookWorkerGroupName'>
        /// Required. The hybrid runbook worker group name
        /// </param>
        /// <param name='parameters'>
        /// Required. The hybrid runbook worker group
        /// </param>
        /// <returns>
        /// The response model for the patch hybrid runbook worker group
        /// operation.
        /// </returns>
        public static HybridRunbookWorkerGroupPatchResponse Patch(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccount, string hybridRunbookWorkerGroupName, HybridRunbookWorkerGroupPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IHybridRunbookWorkerGroupOperations)s).PatchAsync(resourceGroupName, automationAccount, hybridRunbookWorkerGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update a hybrid runbook worker group.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IHybridRunbookWorkerGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='hybridRunbookWorkerGroupName'>
        /// Required. The hybrid runbook worker group name
        /// </param>
        /// <param name='parameters'>
        /// Required. The hybrid runbook worker group
        /// </param>
        /// <returns>
        /// The response model for the patch hybrid runbook worker group
        /// operation.
        /// </returns>
        public static Task<HybridRunbookWorkerGroupPatchResponse> PatchAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccount, string hybridRunbookWorkerGroupName, HybridRunbookWorkerGroupPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, automationAccount, hybridRunbookWorkerGroupName, parameters, CancellationToken.None);
        }
    }
}
