using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum WeekStartEnum
    {
        MONDAY, //TODO: Write general description for this method
        TUESDAY, //TODO: Write general description for this method
        WEDNESDAY, //TODO: Write general description for this method
        THURSDAY, //TODO: Write general description for this method
        FRIDAY, //TODO: Write general description for this method
        SATURDAY, //TODO: Write general description for this method
        SUNDAY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type WeekStartEnum
    /// </summary>
    public static class WeekStartEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };

        /// <summary>
        /// Converts a WeekStartEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The WeekStartEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(WeekStartEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case WeekStartEnum.MONDAY:
                case WeekStartEnum.TUESDAY:
                case WeekStartEnum.WEDNESDAY:
                case WeekStartEnum.THURSDAY:
                case WeekStartEnum.FRIDAY:
                case WeekStartEnum.SATURDAY:
                case WeekStartEnum.SUNDAY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of WeekStartEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of WeekStartEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<WeekStartEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into WeekStartEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed WeekStartEnum value</returns>
        public static WeekStartEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type WeekStartEnum");

            return (WeekStartEnum) index;
        }
    }
} 