using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PaymentStatusEnum
    {
        ACCEPTED, //TODO: Write general description for this method
        REJECTED, //TODO: Write general description for this method
        PENDING, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PaymentStatusEnum
    /// </summary>
    public static class PaymentStatusEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ACCEPTED", "REJECTED", "PENDING" };

        /// <summary>
        /// Converts a PaymentStatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PaymentStatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PaymentStatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PaymentStatusEnum.ACCEPTED:
                case PaymentStatusEnum.REJECTED:
                case PaymentStatusEnum.PENDING:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PaymentStatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PaymentStatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PaymentStatusEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into PaymentStatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PaymentStatusEnum value</returns>
        public static PaymentStatusEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PaymentStatusEnum");

            return (PaymentStatusEnum) index;
        }
    }
} 