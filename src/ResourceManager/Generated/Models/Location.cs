// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Internal.Subscriptions.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Location information.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location() { }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location(string id = default(string), string subscriptionId = default(string), string name = default(string), string displayName = default(string), string latitude = default(string), string longitude = default(string))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Name = name;
            DisplayName = displayName;
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// The fully qualified ID of the location. For example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000/locations/westus.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// The subscription ID.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// The location name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// The display name of the location.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// The latitude of the location.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; private set; }

        /// <summary>
        /// The longitude of the location.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; private set; }

    }
}