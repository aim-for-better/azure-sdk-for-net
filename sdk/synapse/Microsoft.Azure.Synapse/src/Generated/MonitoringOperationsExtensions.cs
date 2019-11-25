// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MonitoringOperations.
    /// </summary>
    public static partial class MonitoringOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='appId'>
            /// </param>
            /// <param name='attemptId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static HistoryServerDataResponse GetHistoryServerData(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string appId, string attemptId, string apiVersion = default(string))
            {
                return operations.GetHistoryServerDataAsync(workspaceName, poolName, livyId, appId, attemptId, apiVersion).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='appId'>
            /// </param>
            /// <param name='attemptId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HistoryServerDataResponse> GetHistoryServerDataAsync(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string appId, string attemptId, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHistoryServerDataWithHttpMessagesAsync(workspaceName, poolName, livyId, appId, attemptId, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static SparkJobListViewResponse GetSparkJobList(this IMonitoringOperations operations, string workspaceName, string apiVersion = default(string))
            {
                return operations.GetSparkJobListAsync(workspaceName, apiVersion).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkJobListViewResponse> GetSparkJobListAsync(this IMonitoringOperations operations, string workspaceName, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSparkJobListWithHttpMessagesAsync(workspaceName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static SparkJobListViewResponse GetApplicationDetails(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string apiVersion = default(string))
            {
                return operations.GetApplicationDetailsAsync(workspaceName, poolName, livyId, apiVersion).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SparkJobListViewResponse> GetApplicationDetailsAsync(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetApplicationDetailsWithHttpMessagesAsync(workspaceName, poolName, livyId, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static HistoryServerPropertiesResponse GetHistoryServerProperties(this IMonitoringOperations operations, string workspaceName, string apiVersion = default(string))
            {
                return operations.GetHistoryServerPropertiesAsync(workspaceName, apiVersion).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HistoryServerPropertiesResponse> GetHistoryServerPropertiesAsync(this IMonitoringOperations operations, string workspaceName, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHistoryServerPropertiesWithHttpMessagesAsync(workspaceName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='appId'>
            /// </param>
            /// <param name='attemptId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static HistoryServerDiagnosticResponse GetHistoryServerDiagnostic(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string appId, string attemptId, string apiVersion = default(string))
            {
                return operations.GetHistoryServerDiagnosticAsync(workspaceName, poolName, livyId, appId, attemptId, apiVersion).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='appId'>
            /// </param>
            /// <param name='attemptId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HistoryServerDiagnosticResponse> GetHistoryServerDiagnosticAsync(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string appId, string attemptId, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHistoryServerDiagnosticWithHttpMessagesAsync(workspaceName, poolName, livyId, appId, attemptId, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='appId'>
            /// </param>
            /// <param name='attemptId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            public static HistoryServerGraphResponse GetHistoryServerGraph(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string appId, string attemptId, string apiVersion = default(string))
            {
                return operations.GetHistoryServerGraphAsync(workspaceName, poolName, livyId, appId, attemptId, apiVersion).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace to execute operations on.
            /// </param>
            /// <param name='poolName'>
            /// </param>
            /// <param name='livyId'>
            /// </param>
            /// <param name='appId'>
            /// </param>
            /// <param name='attemptId'>
            /// </param>
            /// <param name='apiVersion'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HistoryServerGraphResponse> GetHistoryServerGraphAsync(this IMonitoringOperations operations, string workspaceName, string poolName, string livyId, string appId, string attemptId, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHistoryServerGraphWithHttpMessagesAsync(workspaceName, poolName, livyId, appId, attemptId, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
