using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SourceOfFundEnum
    {
        BENEFITS, //TODO: Write general description for this method
        FRIENDS_AND_FAMILY, //TODO: Write general description for this method
        INVESTMENT, //TODO: Write general description for this method
        LOANS, //TODO: Write general description for this method
        MONTHLY_SALARY, //TODO: Write general description for this method
        PENSION, //TODO: Write general description for this method
        PROPERTY, //TODO: Write general description for this method
        WEEKLY_WAGES, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SourceOfFundEnum
    /// </summary>
    public static class SourceOfFundEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BENEFITS", "FRIENDS_AND_FAMILY", "INVESTMENT", "LOANS", "MONTHLY_SALARY", "PENSION", "PROPERTY", "WEEKLY_WAGES" };

        /// <summary>
        /// Converts a SourceOfFundEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SourceOfFundEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SourceOfFundEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SourceOfFundEnum.BENEFITS:
                case SourceOfFundEnum.FRIENDS_AND_FAMILY:
                case SourceOfFundEnum.INVESTMENT:
                case SourceOfFundEnum.LOANS:
                case SourceOfFundEnum.MONTHLY_SALARY:
                case SourceOfFundEnum.PENSION:
                case SourceOfFundEnum.PROPERTY:
                case SourceOfFundEnum.WEEKLY_WAGES:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SourceOfFundEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SourceOfFundEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SourceOfFundEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SourceOfFundEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SourceOfFundEnum value</returns>
        public static SourceOfFundEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SourceOfFundEnum");

            return (SourceOfFundEnum) index;
        }
    }
} 