using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum FrequencyEnum
    {
        DAILY, //TODO: Write general description for this method
        WEEKLY, //TODO: Write general description for this method
        MONTHLY, //TODO: Write general description for this method
        YEARLY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type FrequencyEnum
    /// </summary>
    public static class FrequencyEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "DAILY", "WEEKLY", "MONTHLY", "YEARLY" };

        /// <summary>
        /// Converts a FrequencyEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The FrequencyEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(FrequencyEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case FrequencyEnum.DAILY:
                case FrequencyEnum.WEEKLY:
                case FrequencyEnum.MONTHLY:
                case FrequencyEnum.YEARLY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of FrequencyEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of FrequencyEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<FrequencyEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into FrequencyEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed FrequencyEnum value</returns>
        public static FrequencyEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type FrequencyEnum");

            return (FrequencyEnum) index;
        }
    }
} 