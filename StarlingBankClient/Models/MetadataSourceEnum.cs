using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum MetadataSourceEnum
    {
        CUSTOMER, //TODO: Write general description for this method
        STARLING, //TODO: Write general description for this method
        PARTNER, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type MetadataSourceEnum
    /// </summary>
    public static class MetadataSourceEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CUSTOMER", "STARLING", "PARTNER" };

        /// <summary>
        /// Converts a MetadataSourceEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The MetadataSourceEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(MetadataSourceEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case MetadataSourceEnum.CUSTOMER:
                case MetadataSourceEnum.STARLING:
                case MetadataSourceEnum.PARTNER:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of MetadataSourceEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of MetadataSourceEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<MetadataSourceEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into MetadataSourceEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed MetadataSourceEnum value</returns>
        public static MetadataSourceEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type MetadataSourceEnum");

            return (MetadataSourceEnum) index;
        }
    }
} 