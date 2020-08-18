using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum DirectionEnum
    {
        IN, //TODO: Write general description for this method
        OUT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type DirectionEnum
    /// </summary>
    public static class DirectionEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "IN", "OUT" };

        /// <summary>
        /// Converts a DirectionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The DirectionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(DirectionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case DirectionEnum.IN:
                case DirectionEnum.OUT:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of DirectionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of DirectionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<DirectionEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into DirectionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed DirectionEnum value</returns>
        public static DirectionEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type DirectionEnum");

            return (DirectionEnum) index;
        }
    }
} 