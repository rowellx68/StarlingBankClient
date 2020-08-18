using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum DescriptionEnum
    {
        ACCEPTED, //TODO: Write general description for this method
        QUALIFIED_ACCEPT_WITHIN_TWO_HOURS, //TODO: Write general description for this method
        QUALIFIED_ACCEPT_UNSPECIFIED_DAY, //TODO: Write general description for this method
        QUALIFIED_ACCEPT_SAME_DAY, //TODO: Write general description for this method
        QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY, //TODO: Write general description for this method
        QUALIFIED_ACCEPT_NEXT_WORKING_DAY, //TODO: Write general description for this method
        QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY, //TODO: Write general description for this method
        DESTINATION_ACCOUNT_INVALID, //TODO: Write general description for this method
        DESTINATION_ACCOUNT_NAME_MISMATCH, //TODO: Write general description for this method
        REFERENCE_INFORMATION_INCORRECT, //TODO: Write general description for this method
        DESTINATION_ACCOUNT_UNAVAILABLE, //TODO: Write general description for this method
        PENDING, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type DescriptionEnum
    /// </summary>
    public static class DescriptionEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ACCEPTED", "QUALIFIED_ACCEPT_WITHIN_TWO_HOURS", "QUALIFIED_ACCEPT_UNSPECIFIED_DAY", "QUALIFIED_ACCEPT_SAME_DAY", "QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY", "QUALIFIED_ACCEPT_NEXT_WORKING_DAY", "QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY", "DESTINATION_ACCOUNT_INVALID", "DESTINATION_ACCOUNT_NAME_MISMATCH", "REFERENCE_INFORMATION_INCORRECT", "DESTINATION_ACCOUNT_UNAVAILABLE", "PENDING" };

        /// <summary>
        /// Converts a DescriptionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The DescriptionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(DescriptionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case DescriptionEnum.ACCEPTED:
                case DescriptionEnum.QUALIFIED_ACCEPT_WITHIN_TWO_HOURS:
                case DescriptionEnum.QUALIFIED_ACCEPT_UNSPECIFIED_DAY:
                case DescriptionEnum.QUALIFIED_ACCEPT_SAME_DAY:
                case DescriptionEnum.QUALIFIED_ACCEPT_NEXT_CALENDAR_DAY:
                case DescriptionEnum.QUALIFIED_ACCEPT_NEXT_WORKING_DAY:
                case DescriptionEnum.QUALIFIED_ACCEPT_AFTER_NEXT_WORKING_DAY:
                case DescriptionEnum.DESTINATION_ACCOUNT_INVALID:
                case DescriptionEnum.DESTINATION_ACCOUNT_NAME_MISMATCH:
                case DescriptionEnum.REFERENCE_INFORMATION_INCORRECT:
                case DescriptionEnum.DESTINATION_ACCOUNT_UNAVAILABLE:
                case DescriptionEnum.PENDING:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of DescriptionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of DescriptionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<DescriptionEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into DescriptionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed DescriptionEnum value</returns>
        public static DescriptionEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type DescriptionEnum");

            return (DescriptionEnum) index;
        }
    }
} 