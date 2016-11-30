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

    public partial class CrsRecord
    {
        /// <summary>
        /// Initializes a new instance of the CrsRecord class.
        /// </summary>
        public CrsRecord() { }

        /// <summary>
        /// Initializes a new instance of the CrsRecord class.
        /// </summary>
        public CrsRecord(string stationName = default(string), string crsCode = default(string))
        {
            StationName = stationName;
            CrsCode = crsCode;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stationName")]
        public string StationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crsCode")]
        public string CrsCode { get; set; }

    }
}