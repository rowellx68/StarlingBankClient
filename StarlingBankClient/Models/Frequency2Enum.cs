using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Frequency2Enum
    {
        DAILY, //TODO: Write general description for this method
        WEEKLY, //TODO: Write general description for this method
        MONTHLY, //TODO: Write general description for this method
        YEARLY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Frequency2Enum
    /// </summary>
    public static class Frequency2EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "DAILY", "WEEKLY", "MONTHLY", "YEARLY" };

        /// <summary>
        /// Converts a Frequency2Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Frequency2Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Frequency2Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Frequency2Enum.DAILY:
                case Frequency2Enum.WEEKLY:
                case Frequency2Enum.MONTHLY:
                case Frequency2Enum.YEARLY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Frequency2Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Frequency2Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Frequency2Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Frequency2Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Frequency2Enum value</returns>
        public static Frequency2Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Frequency2Enum");

            return (Frequency2Enum) index;
        }
    }
} 