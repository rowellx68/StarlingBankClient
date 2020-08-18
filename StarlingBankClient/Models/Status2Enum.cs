using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Status2Enum
    {
        UPCOMING, //TODO: Write general description for this method
        PENDING, //TODO: Write general description for this method
        REVERSED, //TODO: Write general description for this method
        SETTLED, //TODO: Write general description for this method
        DECLINED, //TODO: Write general description for this method
        REFUNDED, //TODO: Write general description for this method
        RETRYING, //TODO: Write general description for this method
        ACCOUNT_CHECK, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Status2Enum
    /// </summary>
    public static class Status2EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "UPCOMING", "PENDING", "REVERSED", "SETTLED", "DECLINED", "REFUNDED", "RETRYING", "ACCOUNT_CHECK" };

        /// <summary>
        /// Converts a Status2Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status2Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status2Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status2Enum.UPCOMING:
                case Status2Enum.PENDING:
                case Status2Enum.REVERSED:
                case Status2Enum.SETTLED:
                case Status2Enum.DECLINED:
                case Status2Enum.REFUNDED:
                case Status2Enum.RETRYING:
                case Status2Enum.ACCOUNT_CHECK:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status2Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status2Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status2Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Status2Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status2Enum value</returns>
        public static Status2Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Status2Enum");

            return (Status2Enum) index;
        }
    }
} 