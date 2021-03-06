// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LiveEventResourceState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LiveEventResourceState
    {
        [EnumMember(Value = "Stopped")]
        Stopped,
        [EnumMember(Value = "Starting")]
        Starting,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Stopping")]
        Stopping,
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    internal static class LiveEventResourceStateEnumExtension
    {
        internal static string ToSerializedValue(this LiveEventResourceState? value)
        {
            return value == null ? null : ((LiveEventResourceState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LiveEventResourceState value)
        {
            switch( value )
            {
                case LiveEventResourceState.Stopped:
                    return "Stopped";
                case LiveEventResourceState.Starting:
                    return "Starting";
                case LiveEventResourceState.Running:
                    return "Running";
                case LiveEventResourceState.Stopping:
                    return "Stopping";
                case LiveEventResourceState.Deleting:
                    return "Deleting";
            }
            return null;
        }

        internal static LiveEventResourceState? ParseLiveEventResourceState(this string value)
        {
            switch( value )
            {
                case "Stopped":
                    return LiveEventResourceState.Stopped;
                case "Starting":
                    return LiveEventResourceState.Starting;
                case "Running":
                    return LiveEventResourceState.Running;
                case "Stopping":
                    return LiveEventResourceState.Stopping;
                case "Deleting":
                    return LiveEventResourceState.Deleting;
            }
            return null;
        }
    }
}
