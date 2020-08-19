using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PayeeType2Enum
    {
        BUSINESS, //TODO: Write general description for this method
        INDIVIDUAL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PayeeType2Enum
    /// </summary>
    public static class PayeeType2EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BUSINESS", "INDIVIDUAL" };

        /// <summary>
        /// Converts a PayeeType2Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PayeeType2Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PayeeType2Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PayeeType2Enum.BUSINESS:
                case PayeeType2Enum.INDIVIDUAL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PayeeType2Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PayeeType2Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PayeeType2Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into PayeeType2Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PayeeType2Enum value</returns>
        public static PayeeType2Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PayeeType2Enum");

            return (PayeeType2Enum) index;
        }
    }
} 