// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The availability result info
    /// </summary>
    public partial class EventsAvailabilityResultInfo
    {
        /// <summary>
        /// Initializes a new instance of the EventsAvailabilityResultInfo
        /// class.
        /// </summary>
        public EventsAvailabilityResultInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsAvailabilityResultInfo
        /// class.
        /// </summary>
        /// <param name="name">The name of the availability result</param>
        /// <param name="success">Indicates if the availability result was
        /// successful</param>
        /// <param name="duration">The duration of the availability
        /// result</param>
        /// <param name="performanceBucket">The performance bucket of the
        /// availability result</param>
        /// <param name="message">The message of the availability
        /// result</param>
        /// <param name="location">The location of the availability
        /// result</param>
        /// <param name="id">The ID of the availability result</param>
        /// <param name="size">The size of the availability result</param>
        public EventsAvailabilityResultInfo(string name = default(string), string success = default(string), long? duration = default(long?), string performanceBucket = default(string), string message = default(string), string location = default(string), string id = default(string), string size = default(string))
        {
            Name = name;
            Success = success;
            Duration = duration;
            PerformanceBucket = performanceBucket;
            Message = message;
            Location = location;
            Id = id;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets indicates if the availability result was successful
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public string Success { get; set; }

        /// <summary>
        /// Gets or sets the duration of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or sets the performance bucket of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "performanceBucket")]
        public string PerformanceBucket { get; set; }

        /// <summary>
        /// Gets or sets the message of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the location of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the ID of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the size of the availability result
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

    }
}