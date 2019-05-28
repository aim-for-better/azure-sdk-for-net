// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Gets the application HTTP endpoints.
    /// </summary>
    public partial class ApplicationGetHttpsEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGetHttpsEndpoint
        /// class.
        /// </summary>
        public ApplicationGetHttpsEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGetHttpsEndpoint
        /// class.
        /// </summary>
        /// <param name="destinationPort">The destination port to connect
        /// to.</param>
        /// <param name="subDomainSuffix">The subDomainSuffix of the
        /// application and can not greater thant 3 characters.</param>
        /// <param name="accessModes">The list of access modes for the
        /// application.</param>
        /// <param name="location">The location of the endpoint.</param>
        /// <param name="publicPort">The public port to connect to.</param>
        /// <param name="disableGatewayAuth">The value indicates whether to
        /// disable GatewayAuth.</param>
        public ApplicationGetHttpsEndpoint(int destinationPort, string subDomainSuffix, IList<string> accessModes = default(IList<string>), string location = default(string), int? publicPort = default(int?), bool? disableGatewayAuth = default(bool?))
        {
            AccessModes = accessModes;
            Location = location;
            DestinationPort = destinationPort;
            PublicPort = publicPort;
            SubDomainSuffix = subDomainSuffix;
            DisableGatewayAuth = disableGatewayAuth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of access modes for the application.
        /// </summary>
        [JsonProperty(PropertyName = "accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        /// Gets or sets the location of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the destination port to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPort")]
        public int DestinationPort { get; set; }

        /// <summary>
        /// Gets or sets the public port to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "publicPort")]
        public int? PublicPort { get; set; }

        /// <summary>
        /// Gets or sets the subDomainSuffix of the application and can not
        /// greater thant 3 characters.
        /// </summary>
        [JsonProperty(PropertyName = "subDomainSuffix")]
        public string SubDomainSuffix { get; set; }

        /// <summary>
        /// Gets or sets the value indicates whether to disable GatewayAuth.
        /// </summary>
        [JsonProperty(PropertyName = "disableGatewayAuth")]
        public bool? DisableGatewayAuth { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubDomainSuffix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubDomainSuffix");
            }
        }
    }
}
