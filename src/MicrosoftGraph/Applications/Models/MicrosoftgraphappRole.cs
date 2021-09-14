// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.MicrosoftGraph.Applications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// appRole
    /// </summary>
    public partial class MicrosoftgraphappRole
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphappRole class.
        /// </summary>
        public MicrosoftgraphappRole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphappRole class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="allowedMemberTypes">Specifies whether this app role
        /// can be assigned to users and groups (by setting to ['User']), to
        /// other application's (by setting to ['Application'], or both (by
        /// setting to ['User', 'Application']). App roles supporting
        /// assignment to other applications' service principals are also known
        /// as application permissions. The 'Application' value is only
        /// supported for app roles defined on application entities.</param>
        /// <param name="description">The description for the app role. This is
        /// displayed when the app role is being assigned and, if the app role
        /// functions as an application permission, during  consent
        /// experiences.</param>
        /// <param name="displayName">Display name for the permission that
        /// appears in the app role assignment and consent experiences.</param>
        /// <param name="id">Unique role identifier inside the appRoles
        /// collection. When creating a new app role, a new Guid identifier
        /// must be provided.</param>
        /// <param name="isEnabled">When creating or updating an app role, this
        /// must be set to true (which is the default). To delete a role, this
        /// must first be set to false.  At that point, in a subsequent call,
        /// this role may be removed.</param>
        /// <param name="origin">Specifies if the app role is defined on the
        /// application object or on the servicePrincipal entity. Must not be
        /// included in any POST or PATCH requests. Read-only.</param>
        /// <param name="value">Specifies the value to include in the roles
        /// claim in ID tokens and access tokens authenticating an assigned
        /// user or service principal. Must not exceed 120 characters in
        /// length. Allowed characters are : ! # $ % &amp; ' ( ) * + , - . / :
        /// ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges
        /// 0-9, A-Z and a-z. Any other character, including the space
        /// character, are not allowed. May not begin with ..</param>
        public MicrosoftgraphappRole(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IList<string> allowedMemberTypes = default(IList<string>), string description = default(string), string displayName = default(string), System.Guid? id = default(System.Guid?), bool? isEnabled = default(bool?), string origin = default(string), string value = default(string))
        {
            AdditionalProperties = additionalProperties;
            AllowedMemberTypes = allowedMemberTypes;
            Description = description;
            DisplayName = displayName;
            Id = id;
            IsEnabled = isEnabled;
            Origin = origin;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this app role can be assigned to
        /// users and groups (by setting to ['User']), to other application's
        /// (by setting to ['Application'], or both (by setting to ['User',
        /// 'Application']). App roles supporting assignment to other
        /// applications' service principals are also known as application
        /// permissions. The 'Application' value is only supported for app
        /// roles defined on application entities.
        /// </summary>
        [JsonProperty(PropertyName = "allowedMemberTypes")]
        public IList<string> AllowedMemberTypes { get; set; }

        /// <summary>
        /// Gets or sets the description for the app role. This is displayed
        /// when the app role is being assigned and, if the app role functions
        /// as an application permission, during  consent experiences.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets display name for the permission that appears in the
        /// app role assignment and consent experiences.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets unique role identifier inside the appRoles collection.
        /// When creating a new app role, a new Guid identifier must be
        /// provided.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets when creating or updating an app role, this must be
        /// set to true (which is the default). To delete a role, this must
        /// first be set to false.  At that point, in a subsequent call, this
        /// role may be removed.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets specifies if the app role is defined on the
        /// application object or on the servicePrincipal entity. Must not be
        /// included in any POST or PATCH requests. Read-only.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets specifies the value to include in the roles claim in
        /// ID tokens and access tokens authenticating an assigned user or
        /// service principal. Must not exceed 120 characters in length.
        /// Allowed characters are : ! # $ % &amp;amp; ' ( ) * + , - . / : ;  =
        /// ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z
        /// and a-z. Any other character, including the space character, are
        /// not allowed. May not begin with ..
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
