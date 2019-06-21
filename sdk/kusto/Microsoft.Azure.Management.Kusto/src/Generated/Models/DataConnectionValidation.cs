// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing an data connection validation.
    /// </summary>
    public partial class DataConnectionValidation
    {
        /// <summary>
        /// Initializes a new instance of the DataConnectionValidation class.
        /// </summary>
        public DataConnectionValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataConnectionValidation class.
        /// </summary>
        /// <param name="dataConnectionName">The name of the data
        /// connection.</param>
        /// <param name="properties">The data connection properties to
        /// validate.</param>
        public DataConnectionValidation(string dataConnectionName = default(string), DataConnection properties = default(DataConnection))
        {
            DataConnectionName = dataConnectionName;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the data connection.
        /// </summary>
        [JsonProperty(PropertyName = "dataConnectionName")]
        public string DataConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the data connection properties to validate.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DataConnection Properties { get; set; }

    }
}