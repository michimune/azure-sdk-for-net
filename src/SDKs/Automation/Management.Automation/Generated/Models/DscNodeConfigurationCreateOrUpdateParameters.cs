// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update node configuration
    /// operation.
    /// </summary>
    public partial class DscNodeConfigurationCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DscNodeConfigurationCreateOrUpdateParameters class.
        /// </summary>
        public DscNodeConfigurationCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DscNodeConfigurationCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="source">Gets or sets the source.</param>
        /// <param name="name">Gets or sets the type of the parameter.</param>
        /// <param name="configuration">Gets or sets the configuration of the
        /// node.</param>
        /// <param name="newNodeConfigurationBuildVersionRequired">If a new
        /// build version of NodeConfiguration is required.</param>
        public DscNodeConfigurationCreateOrUpdateParameters(ContentSource source, string name, DscConfigurationAssociationProperty configuration, bool? newNodeConfigurationBuildVersionRequired = default(bool?))
        {
            Source = source;
            Name = name;
            Configuration = configuration;
            NewNodeConfigurationBuildVersionRequired = newNodeConfigurationBuildVersionRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public ContentSource Source { get; set; }

        /// <summary>
        /// Gets or sets the type of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the configuration of the node.
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public DscConfigurationAssociationProperty Configuration { get; set; }

        /// <summary>
        /// Gets or sets if a new build version of NodeConfiguration is
        /// required.
        /// </summary>
        [JsonProperty(PropertyName = "newNodeConfigurationBuildVersionRequired")]
        public bool? NewNodeConfigurationBuildVersionRequired { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Configuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Configuration");
            }
            if (Source != null)
            {
                Source.Validate();
            }
        }
    }
}
