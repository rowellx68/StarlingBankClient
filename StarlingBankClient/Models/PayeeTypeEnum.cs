using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PayeeTypeEnum
    {
        BUSINESS, //TODO: Write general description for this method
        INDIVIDUAL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PayeeTypeEnum
    /// </summary>
    public static class PayeeTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BUSINESS", "INDIVIDUAL" };

        /// <summary>
        /// Converts a PayeeTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PayeeTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PayeeTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PayeeTypeEnum.BUSINESS:
                case PayeeTypeEnum.INDIVIDUAL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PayeeTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PayeeTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PayeeTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into PayeeTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PayeeTypeEnum value</returns>
        public static PayeeTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PayeeTypeEnum");

            return (PayeeTypeEnum) index;
        }
    }
} 