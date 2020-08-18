using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Type1Enum
    {
        PURCHASE, //TODO: Write general description for this method
        SERVICE_FEE, //TODO: Write general description for this method
        GRATUITY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Type1Enum
    /// </summary>
    public static class Type1EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "PURCHASE", "SERVICE_FEE", "GRATUITY" };

        /// <summary>
        /// Converts a Type1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Type1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Type1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Type1Enum.PURCHASE:
                case Type1Enum.SERVICE_FEE:
                case Type1Enum.GRATUITY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Type1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Type1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Type1Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Type1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Type1Enum value</returns>
        public static Type1Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Type1Enum");

            return (Type1Enum) index;
        }
    }
} 