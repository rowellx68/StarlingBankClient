using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Status1Enum
    {
        CANCELLED, //TODO: Write general description for this method
        LIVE, //TODO: Write general description for this method
        PENDING_CAS, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Status1Enum
    /// </summary>
    public static class Status1EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CANCELLED", "LIVE", "PENDING_CAS" };

        /// <summary>
        /// Converts a Status1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status1Enum.CANCELLED:
                case Status1Enum.LIVE:
                case Status1Enum.PENDING_CAS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status1Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Status1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status1Enum value</returns>
        public static Status1Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Status1Enum");

            return (Status1Enum) index;
        }
    }
} 