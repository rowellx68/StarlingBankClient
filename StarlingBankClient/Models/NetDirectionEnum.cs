using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum NetDirectionEnum
    {
        IN, //TODO: Write general description for this method
        OUT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type NetDirectionEnum
    /// </summary>
    public static class NetDirectionEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "IN", "OUT" };

        /// <summary>
        /// Converts a NetDirectionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The NetDirectionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(NetDirectionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case NetDirectionEnum.IN:
                case NetDirectionEnum.OUT:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of NetDirectionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of NetDirectionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<NetDirectionEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into NetDirectionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed NetDirectionEnum value</returns>
        public static NetDirectionEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type NetDirectionEnum");

            return (NetDirectionEnum) index;
        }
    }
} 