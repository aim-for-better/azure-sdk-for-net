// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ExtendedLivyBatchResponse
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedLivyBatchResponse class.
        /// </summary>
        public ExtendedLivyBatchResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedLivyBatchResponse class.
        /// </summary>
        /// <param name="jobType">Possible values include: 'SparkBatch',
        /// 'SparkSession'</param>
        /// <param name="result">Possible values include: 'Uncertain',
        /// 'Succeeded', 'Failed', 'Cancelled'</param>
        public ExtendedLivyBatchResponse(LivyBatchStateInformation livyInfo = default(LivyBatchStateInformation), string name = default(string), string workspaceName = default(string), string sparkPoolName = default(string), string submitterName = default(string), string submitterId = default(string), string artifactId = default(string), string jobType = default(string), string result = default(string), SchedulerInformation schedulerInfo = default(SchedulerInformation), SparkServicePluginInformation pluginInfo = default(SparkServicePluginInformation), IList<ErrorInformation> errorInfo = default(IList<ErrorInformation>), IDictionary<string, string> tags = default(IDictionary<string, string>), int? id = default(int?), string appId = default(string), IDictionary<string, string> appInfo = default(IDictionary<string, string>), string state = default(string), IList<string> log = default(IList<string>))
        {
            LivyInfo = livyInfo;
            Name = name;
            WorkspaceName = workspaceName;
            SparkPoolName = sparkPoolName;
            SubmitterName = submitterName;
            SubmitterId = submitterId;
            ArtifactId = artifactId;
            JobType = jobType;
            Result = result;
            SchedulerInfo = schedulerInfo;
            PluginInfo = pluginInfo;
            ErrorInfo = errorInfo;
            Tags = tags;
            Id = id;
            AppId = appId;
            AppInfo = appInfo;
            State = state;
            Log = log;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "livyInfo")]
        public LivyBatchStateInformation LivyInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspaceName")]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sparkPoolName")]
        public string SparkPoolName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitterName")]
        public string SubmitterName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitterId")]
        public string SubmitterId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "artifactId")]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'SparkBatch', 'SparkSession'
        /// </summary>
        [JsonProperty(PropertyName = "jobType")]
        public string JobType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Uncertain', 'Succeeded',
        /// 'Failed', 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedulerInfo")]
        public SchedulerInformation SchedulerInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginInfo")]
        public SparkServicePluginInformation PluginInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorInfo")]
        public IList<ErrorInformation> ErrorInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appInfo")]
        public IDictionary<string, string> AppInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public IList<string> Log { get; set; }

    }
}
