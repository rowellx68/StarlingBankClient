using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Direction3Enum
    {
        IN, //TODO: Write general description for this method
        OUT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Direction3Enum
    /// </summary>
    public static class Direction3EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "IN", "OUT" };

        /// <summary>
        /// Converts a Direction3Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Direction3Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Direction3Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Direction3Enum.IN:
                case Direction3Enum.OUT:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Direction3Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Direction3Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Direction3Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Direction3Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Direction3Enum value</returns>
        public static Direction3Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Direction3Enum");

            return (Direction3Enum) index;
        }
    }
} 