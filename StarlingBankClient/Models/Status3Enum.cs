using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Status3Enum
    {
        ACTIVE, //TODO: Write general description for this method
        INACTIVE, //TODO: Write general description for this method
        CLOSED, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Status3Enum
    /// </summary>
    public static class Status3EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ACTIVE", "INACTIVE", "CLOSED" };

        /// <summary>
        /// Converts a Status3Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status3Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status3Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status3Enum.ACTIVE:
                case Status3Enum.INACTIVE:
                case Status3Enum.CLOSED:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status3Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status3Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status3Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Status3Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status3Enum value</returns>
        public static Status3Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Status3Enum");

            return (Status3Enum) index;
        }
    }
} 