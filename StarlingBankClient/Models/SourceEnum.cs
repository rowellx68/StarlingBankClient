using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SourceEnum
    {
        ELECTRONIC, //TODO: Write general description for this method
        PAPER, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SourceEnum
    /// </summary>
    public static class SourceEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ELECTRONIC", "PAPER" };

        /// <summary>
        /// Converts a SourceEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SourceEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SourceEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SourceEnum.ELECTRONIC:
                case SourceEnum.PAPER:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SourceEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SourceEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SourceEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SourceEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SourceEnum value</returns>
        public static SourceEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SourceEnum");

            return (SourceEnum) index;
        }
    }
} 