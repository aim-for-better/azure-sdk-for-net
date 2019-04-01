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
using Microsoft.Azure;
using Microsoft.Azure.Management.HDInsight.Models;

namespace Microsoft.Azure.Management.HDInsight
{
    /// <summary>
    /// Contains all the cluster operations.
    /// </summary>
    public partial interface IClusterOperations
    {
        /// <summary>
        /// This API has been deprecated. Please use BeginUpdateGatewaySettings.
        /// Begins configuring the HTTP settings on the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='httpSettingsParameters'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        [Obsolete("This API has been deprecated. Please use BeginUpdateGatewaySettings.")]
        Task<HDInsightOperationResponse> BeginConfiguringHttpSettingsAsync(string resourceGroupName, string clusterName, HttpSettingsParameters httpSettingsParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins configuring the RDP settings on the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='rdpParameters'>
        /// The OS profile for RDP.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        Task<HDInsightOperationResponse> BeginConfiguringRdpSettingsAsync(string resourceGroupName, string clusterName, RDPSettingsParameters rdpParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins creating a new HDInsight cluster with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='clusterCreateParameters'>
        /// The cluster create request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateCluster operation response.
        /// </returns>
        Task<ClusterCreateResponse> BeginCreatingAsync(string resourceGroupName, string clusterName, ClusterCreateParametersExtended clusterCreateParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins deleting the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        Task<HDInsightOperationResponse> BeginDeletingAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins executing script actions on the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='executeScriptActionParameters'>
        /// The parameters for executing script actions.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        Task<HDInsightOperationResponse> BeginExecuteScriptActionsAsync(string resourceGroupName, string clusterName, ExecuteScriptActionParameters executeScriptActionParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begins a resize operation on the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='resizeParameters'>
        /// The parameters for the resize operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        Task<HDInsightOperationResponse> BeginResizingAsync(string resourceGroupName, string clusterName, ClusterResizeParameters resizeParameters, CancellationToken cancellationToken);

        /// <summary>
        /// Begin updating the Gateway settings on the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='httpSettingsParameters'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        Task<HDInsightOperationResponse> BeginUpdateGatewaySettingsAsync(string resourceGroupName, string clusterName, HttpSettingsParameters httpSettingsParameters, CancellationToken cancellationToken);

        /// <summary>
        /// This API has been deprecated. Please use UpdateGatewaySettings.
        /// Configures the HTTP settings on the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='httpSettingsParameters'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        [Obsolete("This API has been deprecated. Please use UpdateGatewaySettings.")]
        Task<OperationResource> ConfigureHttpSettingsAsync(string resourceGroupName, string clusterName, HttpSettingsParameters httpSettingsParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Configures the RDP settings on the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='rdpParameters'>
        /// The OS profile for RDP. Use null to turn RDP off.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        Task<OperationResource> ConfigureRdpSettingsAsync(string resourceGroupName, string clusterName, RDPSettingsParameters rdpParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new HDInsight cluster with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='clusterCreateParameters'>
        /// The cluster create request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetCluster operation response.
        /// </returns>
        Task<ClusterGetResponse> CreateAsync(string resourceGroupName, string clusterName, ClusterCreateParametersExtended clusterCreateParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        Task<OperationResource> DeleteAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a given persisted script action of the cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='scriptName'>
        /// The name of the script.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeletePersistedScriptAsync(string resourceGroupName, string clusterName, string scriptName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Executes script actions on the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='executeScriptActionParameters'>
        /// The parameters for executing script actions.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        Task<OperationResource> ExecuteScriptActionsAsync(string resourceGroupName, string clusterName, ExecuteScriptActionParameters executeScriptActionParameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetCluster operation response.
        /// </returns>
        Task<ClusterGetResponse> GetAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the capabilities for the specified location.
        /// </summary>
        /// <param name='location'>
        /// The location to get capabilities for.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Capabilities operation response.
        /// </returns>
        Task<CapabilitiesResponse> GetCapabilitiesAsync(string location, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the configuration for the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='configurationName'>
        /// The type name of the hadoop configuration.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Cluster Configurations operation response.
        /// </returns>
        Task<ClusterConfigurationsResponse> GetClusterConfigurationsAsync(string resourceGroupName, string clusterName, string configurationName, CancellationToken cancellationToken);

        /// <summary>
        /// This api has been deprecated. Pleause use GetGatewaySettings.
        /// Gets the connectivity settings for the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The payload for a Configure HTTP settings request.
        /// </returns>
        [Obsolete("This api has been deprecated. Pleause use GetGatewaySettings.")]
        Task<HttpConnectivitySettings> GetConnectivitySettingsAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of the Create operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetCluster operation response.
        /// </returns>
        Task<ClusterGetResponse> GetCreateStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of the Delete operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        Task<OperationResource> GetDeleteStatusAsync(string operationStatusLink, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the Gateway settings for the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The payload for a Configure HTTP settings request.
        /// </returns>
        Task<HttpConnectivitySettings> GetGatewaySettingsAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the script execution detail for the given script execution id.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='scriptExecutionId'>
        /// The script execution Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetScriptExecutionDetail operation response.
        /// </returns>
        Task<ClusterRuntimeScriptActionDetailResponse> GetScriptExecutionDetailAsync(string resourceGroupName, string clusterName, long scriptExecutionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists HDInsight clusters under the subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Cluster operation response.
        /// </returns>
        Task<ClusterListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// List the HDInsight clusters in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Cluster operation response.
        /// </returns>
        Task<ClusterListResponse> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken);

        /// <summary>
        /// Gets all configuration information fro an HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Cluster Configurations operation response.
        /// </returns>
        Task<ClusterListConfigurationsResponse> ListConfigurationsAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);

        /// <summary>
        /// Lists all persisted script actions for the given cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List PersistedScriptActions operations response.
        /// </returns>
        Task<ClusterListPersistedScriptActionsResponse> ListPersistedScriptsAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists all scripts execution history for the given cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The ListScriptExecutionHistory response.
        /// </returns>
        Task<ClusterListRuntimeScriptActionDetailResponse> ListScriptExecutionHistoryAsync(string resourceGroupName, string clusterName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Promote ad-hoc script execution to a persisted script.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='scriptExecutionId'>
        /// The script execution Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> PromoteScriptAsync(string resourceGroupName, string clusterName, long scriptExecutionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Resizes the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='resizeParameters'>
        /// The parameters for the resize operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        Task<OperationResource> ResizeAsync(string resourceGroupName, string clusterName, ClusterResizeParameters resizeParameters, CancellationToken cancellationToken);

        /// <summary>
        /// Update the Gateway settings on the specified cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the cluster.
        /// </param>
        /// <param name='httpSettingsParameters'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The azure async operation response.
        /// </returns>
        Task<OperationResource> UpdateGatewaySettingsAsync(string resourceGroupName, string clusterName, HttpSettingsParameters httpSettingsParameters, CancellationToken cancellationToken);
    }
}
