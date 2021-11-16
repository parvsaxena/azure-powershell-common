// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.Applications.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftGraphOAuth2PermissionGrant : MicrosoftGraphEntity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftGraphOAuth2PermissionGrant class.
        /// </summary>
        public MicrosoftGraphOAuth2PermissionGrant()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftGraphOAuth2PermissionGrant class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        /// <param name="clientId">The id of the client service principal for
        /// the application which is authorized to act on behalf of a signed-in
        /// user when accessing an API. Required. Supports $filter (eq
        /// only).</param>
        /// <param name="consentType">Indicates whether authorization is
        /// granted for the client application to impersonate all users or only
        /// a specific user. AllPrincipals indicates authorization to
        /// impersonate all users. Principal indicates authorization to
        /// impersonate a specific user. Consent on behalf of all users can be
        /// granted by an administrator. Non-admin users may be authorized to
        /// consent on behalf of themselves in some cases, for some delegated
        /// permissions. Required. Supports $filter (eq only).</param>
        /// <param name="principalId">The id of the user on behalf of whom the
        /// client is authorized to access the resource, when consentType is
        /// Principal. If consentType is AllPrincipals this value is null.
        /// Required when consentType is Principal.</param>
        /// <param name="resourceId">The id of the resource service principal
        /// to which access is authorized. This identifies the API which the
        /// client is authorized to attempt to call on behalf of a signed-in
        /// user.</param>
        /// <param name="scope">A space-separated list of the claim values for
        /// delegated permissions which should be included in access tokens for
        /// the resource application (the API). For example, openid User.Read
        /// GroupMember.Read.All. Each claim value should match the value field
        /// of one of the delegated permissions defined by the API, listed in
        /// the publishedPermissionScopes property of the resource service
        /// principal.</param>
        public MicrosoftGraphOAuth2PermissionGrant(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), string clientId = default(string), string consentType = default(string), string principalId = default(string), string resourceId = default(string), string scope = default(string))
            : base(additionalProperties, id)
        {
            ClientId = clientId;
            ConsentType = consentType;
            PrincipalId = principalId;
            ResourceId = resourceId;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the client service principal for the
        /// application which is authorized to act on behalf of a signed-in
        /// user when accessing an API. Required. Supports $filter (eq only).
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets indicates whether authorization is granted for the
        /// client application to impersonate all users or only a specific
        /// user. AllPrincipals indicates authorization to impersonate all
        /// users. Principal indicates authorization to impersonate a specific
        /// user. Consent on behalf of all users can be granted by an
        /// administrator. Non-admin users may be authorized to consent on
        /// behalf of themselves in some cases, for some delegated permissions.
        /// Required. Supports $filter (eq only).
        /// </summary>
        [JsonProperty(PropertyName = "consentType")]
        public string ConsentType { get; set; }

        /// <summary>
        /// Gets or sets the id of the user on behalf of whom the client is
        /// authorized to access the resource, when consentType is Principal.
        /// If consentType is AllPrincipals this value is null. Required when
        /// consentType is Principal.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the id of the resource service principal to which
        /// access is authorized. This identifies the API which the client is
        /// authorized to attempt to call on behalf of a signed-in user.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets a space-separated list of the claim values for
        /// delegated permissions which should be included in access tokens for
        /// the resource application (the API). For example, openid User.Read
        /// GroupMember.Read.All. Each claim value should match the value field
        /// of one of the delegated permissions defined by the API, listed in
        /// the publishedPermissionScopes property of the resource service
        /// principal.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

    }
}