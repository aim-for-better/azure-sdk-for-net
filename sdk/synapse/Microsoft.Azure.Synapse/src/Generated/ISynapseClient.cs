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
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface ISynapseClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets the DNS suffix used as the base for all Synapse service
        /// requests.
        /// </summary>
        string SynapseDnsSuffix { get; set; }

        /// <summary>
        /// Valid api-version for the request.
        /// </summary>
        string LivyApiVersion { get; set; }

        /// <summary>
        /// The Synapse client API Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IMonitoringOperations.
        /// </summary>
        IMonitoringOperations Monitoring { get; }

        /// <summary>
        /// Gets the ISparkBatchOperations.
        /// </summary>
        ISparkBatchOperations SparkBatch { get; }

        /// <summary>
        /// Gets the ISparkSessionOperations.
        /// </summary>
        ISparkSessionOperations SparkSession { get; }

        /// <summary>
        /// Gets the IWorkspaceAclOperations.
        /// </summary>
        IWorkspaceAclOperations WorkspaceAcl { get; }

    }
}
