﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace KaneHuxleyAPI.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ServiceLocation
    {
        /// <summary>
        /// Initializes a new instance of the ServiceLocation class.
        /// </summary>
        public ServiceLocation() { }

        /// <summary>
        /// Initializes a new instance of the ServiceLocation class.
        /// </summary>
        public ServiceLocation(string locationName = default(string), string crs = default(string), string via = default(string), string futureChangeTo = default(string), bool? assocIsCancelled = default(bool?))
        {
            LocationName = locationName;
            Crs = crs;
            Via = via;
            FutureChangeTo = futureChangeTo;
            AssocIsCancelled = assocIsCancelled;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crs")]
        public string Crs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "via")]
        public string Via { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "futureChangeTo")]
        public string FutureChangeTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assocIsCancelled")]
        public bool? AssocIsCancelled { get; set; }

    }
}