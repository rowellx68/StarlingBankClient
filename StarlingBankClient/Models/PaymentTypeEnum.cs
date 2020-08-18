using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PaymentTypeEnum
    {
        DIRECT_DEBIT, //TODO: Write general description for this method
        STANDING_ORDER, //TODO: Write general description for this method
        INTERNAL_TRANSFER, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PaymentTypeEnum
    /// </summary>
    public static class PaymentTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "DIRECT_DEBIT", "STANDING_ORDER", "INTERNAL_TRANSFER" };

        /// <summary>
        /// Converts a PaymentTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PaymentTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PaymentTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PaymentTypeEnum.DIRECT_DEBIT:
                case PaymentTypeEnum.STANDING_ORDER:
                case PaymentTypeEnum.INTERNAL_TRANSFER:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PaymentTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PaymentTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PaymentTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into PaymentTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PaymentTypeEnum value</returns>
        public static PaymentTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PaymentTypeEnum");

            return (PaymentTypeEnum) index;
        }
    }
} 