// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.ResourceManager.Version2018_05_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Entity representing the reference to the deployment paramaters.
    /// </summary>
    public partial class ParametersLink
    {
        /// <summary>
        /// Initializes a new instance of the ParametersLink class.
        /// </summary>
        public ParametersLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParametersLink class.
        /// </summary>
        /// <param name="uri">The URI of the parameters file.</param>
        /// <param name="contentVersion">If included, must match the
        /// ContentVersion in the template.</param>
        public ParametersLink(string uri, string contentVersion = default(string))
        {
            Uri = uri;
            ContentVersion = contentVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI of the parameters file.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets if included, must match the ContentVersion in the
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
