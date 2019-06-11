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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The billing meters.
    /// </summary>
    public partial class BillingMeters
    {
        /// <summary>
        /// Initializes a new instance of the BillingMeters class.
        /// </summary>
        public BillingMeters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingMeters class.
        /// </summary>
        /// <param name="meterParameter">VM Sizes.</param>
        /// <param name="meter">HDI meter guid.</param>
        /// <param name="unit">Unit of meter, VMHours/CoreHours.</param>
        public BillingMeters(string meterParameter = default(string), string meter = default(string), string unit = default(string))
        {
            MeterParameter = meterParameter;
            Meter = meter;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets VM Sizes.
        /// </summary>
        [JsonProperty(PropertyName = "meterParameter")]
        public string MeterParameter { get; set; }

        /// <summary>
        /// Gets or sets HDI meter guid.
        /// </summary>
        [JsonProperty(PropertyName = "meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Gets or sets unit of meter, VMHours/CoreHours.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

    }
}
