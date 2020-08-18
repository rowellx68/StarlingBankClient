using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BillingPeriodEnum
    {
        DAILY, //TODO: Write general description for this method
        MONTHLY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BillingPeriodEnum
    /// </summary>
    public static class BillingPeriodEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "DAILY", "MONTHLY" };

        /// <summary>
        /// Converts a BillingPeriodEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BillingPeriodEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BillingPeriodEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BillingPeriodEnum.DAILY:
                case BillingPeriodEnum.MONTHLY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BillingPeriodEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BillingPeriodEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BillingPeriodEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BillingPeriodEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BillingPeriodEnum value</returns>
        public static BillingPeriodEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BillingPeriodEnum");

            return (BillingPeriodEnum) index;
        }
    }
} 