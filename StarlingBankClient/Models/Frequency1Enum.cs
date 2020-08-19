using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Frequency1Enum
    {
        SECONDLY, //TODO: Write general description for this method
        MINUTELY, //TODO: Write general description for this method
        HOURLY, //TODO: Write general description for this method
        DAILY, //TODO: Write general description for this method
        WEEKLY, //TODO: Write general description for this method
        MONTHLY, //TODO: Write general description for this method
        YEARLY, //TODO: Write general description for this method
        MILLENNIALY, //TODO: Write general description for this method
        WORKING_DAILY, //TODO: Write general description for this method
        SCOTTISH_QUARTERLY, //TODO: Write general description for this method
        ENGLISH_QUARTERLY, //TODO: Write general description for this method
        RECEIVED_QUARTERLY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Frequency1Enum
    /// </summary>
    public static class Frequency1EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "SECONDLY", "MINUTELY", "HOURLY", "DAILY", "WEEKLY", "MONTHLY", "YEARLY", "MILLENNIALY", "WORKING_DAILY", "SCOTTISH_QUARTERLY", "ENGLISH_QUARTERLY", "RECEIVED_QUARTERLY" };

        /// <summary>
        /// Converts a Frequency1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Frequency1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Frequency1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Frequency1Enum.SECONDLY:
                case Frequency1Enum.MINUTELY:
                case Frequency1Enum.HOURLY:
                case Frequency1Enum.DAILY:
                case Frequency1Enum.WEEKLY:
                case Frequency1Enum.MONTHLY:
                case Frequency1Enum.YEARLY:
                case Frequency1Enum.MILLENNIALY:
                case Frequency1Enum.WORKING_DAILY:
                case Frequency1Enum.SCOTTISH_QUARTERLY:
                case Frequency1Enum.ENGLISH_QUARTERLY:
                case Frequency1Enum.RECEIVED_QUARTERLY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Frequency1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Frequency1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Frequency1Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Frequency1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Frequency1Enum value</returns>
        public static Frequency1Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Frequency1Enum");

            return (Frequency1Enum) index;
        }
    }
} 