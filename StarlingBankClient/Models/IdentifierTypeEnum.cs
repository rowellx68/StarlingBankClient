using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum IdentifierTypeEnum
    {
        SORT_CODE, //TODO: Write general description for this method
        IBAN_BIC, //TODO: Write general description for this method
        ABA_ACH, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type IdentifierTypeEnum
    /// </summary>
    public static class IdentifierTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "SORT_CODE", "IBAN_BIC", "ABA_ACH" };

        /// <summary>
        /// Converts a IdentifierTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The IdentifierTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(IdentifierTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case IdentifierTypeEnum.SORT_CODE:
                case IdentifierTypeEnum.IBAN_BIC:
                case IdentifierTypeEnum.ABA_ACH:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of IdentifierTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of IdentifierTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<IdentifierTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into IdentifierTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed IdentifierTypeEnum value</returns>
        public static IdentifierTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type IdentifierTypeEnum");

            return (IdentifierTypeEnum) index;
        }
    }
} 