using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum DayEnum
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
    /// Helper for the enum type DayEnum
    /// </summary>
    public static class DayEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };

        /// <summary>
        /// Converts a DayEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The DayEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(DayEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case DayEnum.MONDAY:
                case DayEnum.TUESDAY:
                case DayEnum.WEDNESDAY:
                case DayEnum.THURSDAY:
                case DayEnum.FRIDAY:
                case DayEnum.SATURDAY:
                case DayEnum.SUNDAY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of DayEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of DayEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<DayEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into DayEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed DayEnum value</returns>
        public static DayEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type DayEnum");

            return (DayEnum) index;
        }
    }
} 