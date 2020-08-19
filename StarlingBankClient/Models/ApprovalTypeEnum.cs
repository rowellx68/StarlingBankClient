using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum ApprovalTypeEnum
    {
        NONE_REQUIRED, //TODO: Write general description for this method
        IN_APP_APPROVAL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ApprovalTypeEnum
    /// </summary>
    public static class ApprovalTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "NONE_REQUIRED", "IN_APP_APPROVAL" };

        /// <summary>
        /// Converts a ApprovalTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ApprovalTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ApprovalTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ApprovalTypeEnum.NONE_REQUIRED:
                case ApprovalTypeEnum.IN_APP_APPROVAL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ApprovalTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ApprovalTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ApprovalTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into ApprovalTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ApprovalTypeEnum value</returns>
        public static ApprovalTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type ApprovalTypeEnum");

            return (ApprovalTypeEnum) index;
        }
    }
} 