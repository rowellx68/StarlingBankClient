using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum MonthEnum
    {
        JANUARY, //TODO: Write general description for this method
        FEBRUARY, //TODO: Write general description for this method
        MARCH, //TODO: Write general description for this method
        APRIL, //TODO: Write general description for this method
        MAY, //TODO: Write general description for this method
        JUNE, //TODO: Write general description for this method
        JULY, //TODO: Write general description for this method
        AUGUST, //TODO: Write general description for this method
        SEPTEMBER, //TODO: Write general description for this method
        OCTOBER, //TODO: Write general description for this method
        NOVEMBER, //TODO: Write general description for this method
        DECEMBER, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type MonthEnum
    /// </summary>
    public static class MonthEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" };

        /// <summary>
        /// Converts a MonthEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The MonthEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(MonthEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case MonthEnum.JANUARY:
                case MonthEnum.FEBRUARY:
                case MonthEnum.MARCH:
                case MonthEnum.APRIL:
                case MonthEnum.MAY:
                case MonthEnum.JUNE:
                case MonthEnum.JULY:
                case MonthEnum.AUGUST:
                case MonthEnum.SEPTEMBER:
                case MonthEnum.OCTOBER:
                case MonthEnum.NOVEMBER:
                case MonthEnum.DECEMBER:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of MonthEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of MonthEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<MonthEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into MonthEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed MonthEnum value</returns>
        public static MonthEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type MonthEnum");

            return (MonthEnum) index;
        }
    }
} 