using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum StatusEnum
    {
        ACTIVE, //TODO: Write general description for this method
        CANCELLED, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type StatusEnum
    /// </summary>
    public static class StatusEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ACTIVE", "CANCELLED" };

        /// <summary>
        /// Converts a StatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The StatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(StatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case StatusEnum.ACTIVE:
                case StatusEnum.CANCELLED:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of StatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of StatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<StatusEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into StatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed StatusEnum value</returns>
        public static StatusEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type StatusEnum");

            return (StatusEnum) index;
        }
    }
} 