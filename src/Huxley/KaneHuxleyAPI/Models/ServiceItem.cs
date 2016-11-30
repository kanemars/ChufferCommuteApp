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

    public partial class ServiceItem
    {
        /// <summary>
        /// Initializes a new instance of the ServiceItem class.
        /// </summary>
        public ServiceItem() { }

        /// <summary>
        /// Initializes a new instance of the ServiceItem class.
        /// </summary>
        public ServiceItem(IList<ServiceLocation> origin = default(IList<ServiceLocation>), IList<ServiceLocation> destination = default(IList<ServiceLocation>), IList<ServiceLocation> currentOrigins = default(IList<ServiceLocation>), IList<ServiceLocation> currentDestinations = default(IList<ServiceLocation>), string rsid = default(string), string sta = default(string), string eta = default(string), string std = default(string), string etd = default(string), string platform = default(string), string operatorProperty = default(string), string operatorCode = default(string), bool? isCircularRoute = default(bool?), bool? isCancelled = default(bool?), bool? filterLocationCancelled = default(bool?), int? serviceType = default(int?), int? length = default(int?), bool? detachFront = default(bool?), bool? isReverseFormation = default(bool?), string cancelReason = default(string), string delayReason = default(string), string serviceID = default(string), string serviceIdPercentEncoded = default(string), string serviceIdGuid = default(string), string serviceIdUrlSafe = default(string), IList<string> adhocAlerts = default(IList<string>))
        {
            Origin = origin;
            Destination = destination;
            CurrentOrigins = currentOrigins;
            CurrentDestinations = currentDestinations;
            Rsid = rsid;
            Sta = sta;
            Eta = eta;
            Std = std;
            Etd = etd;
            Platform = platform;
            OperatorProperty = operatorProperty;
            OperatorCode = operatorCode;
            IsCircularRoute = isCircularRoute;
            IsCancelled = isCancelled;
            FilterLocationCancelled = filterLocationCancelled;
            ServiceType = serviceType;
            Length = length;
            DetachFront = detachFront;
            IsReverseFormation = isReverseFormation;
            CancelReason = cancelReason;
            DelayReason = delayReason;
            ServiceID = serviceID;
            ServiceIdPercentEncoded = serviceIdPercentEncoded;
            ServiceIdGuid = serviceIdGuid;
            ServiceIdUrlSafe = serviceIdUrlSafe;
            AdhocAlerts = adhocAlerts;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public IList<ServiceLocation> Origin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public IList<ServiceLocation> Destination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentOrigins")]
        public IList<ServiceLocation> CurrentOrigins { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentDestinations")]
        public IList<ServiceLocation> CurrentDestinations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rsid")]
        public string Rsid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sta")]
        public string Sta { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eta")]
        public string Eta { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "std")]
        public string Std { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "etd")]
        public string Etd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatorCode")]
        public string OperatorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCircularRoute")]
        public bool? IsCircularRoute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isCancelled")]
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filterLocationCancelled")]
        public bool? FilterLocationCancelled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceType")]
        public int? ServiceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public int? Length { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "detachFront")]
        public bool? DetachFront { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isReverseFormation")]
        public bool? IsReverseFormation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancelReason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delayReason")]
        public string DelayReason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceID")]
        public string ServiceID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceIdPercentEncoded")]
        public string ServiceIdPercentEncoded { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceIdGuid")]
        public string ServiceIdGuid { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceIdUrlSafe")]
        public string ServiceIdUrlSafe { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adhocAlerts")]
        public IList<string> AdhocAlerts { get; set; }

    }
}
