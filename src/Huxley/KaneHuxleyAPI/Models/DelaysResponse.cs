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

    public partial class DelaysResponse
    {
        /// <summary>
        /// Initializes a new instance of the DelaysResponse class.
        /// </summary>
        public DelaysResponse() { }

        /// <summary>
        /// Initializes a new instance of the DelaysResponse class.
        /// </summary>
        public DelaysResponse(DateTime? generatedAt = default(DateTime?), string locationName = default(string), string crs = default(string), string filterLocationName = default(string), string filtercrs = default(string), bool? delays = default(bool?), int? totalTrainsDelayed = default(int?), int? totalDelayMinutes = default(int?), int? totalTrains = default(int?), IList<ServiceItem> delayedTrains = default(IList<ServiceItem>))
        {
            GeneratedAt = generatedAt;
            LocationName = locationName;
            Crs = crs;
            FilterLocationName = filterLocationName;
            Filtercrs = filtercrs;
            Delays = delays;
            TotalTrainsDelayed = totalTrainsDelayed;
            TotalDelayMinutes = totalDelayMinutes;
            TotalTrains = totalTrains;
            DelayedTrains = delayedTrains;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "generatedAt")]
        public DateTime? GeneratedAt { get; set; }

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
        [JsonProperty(PropertyName = "filterLocationName")]
        public string FilterLocationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filtercrs")]
        public string Filtercrs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delays")]
        public bool? Delays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalTrainsDelayed")]
        public int? TotalTrainsDelayed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalDelayMinutes")]
        public int? TotalDelayMinutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalTrains")]
        public int? TotalTrains { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delayedTrains")]
        public IList<ServiceItem> DelayedTrains { get; set; }

    }
}