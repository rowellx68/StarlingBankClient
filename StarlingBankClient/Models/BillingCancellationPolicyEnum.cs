using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BillingCancellationPolicyEnum
    {
        AFTER_FIRST_PAYMENT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BillingCancellationPolicyEnum
    /// </summary>
    public static class BillingCancellationPolicyEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "AFTER_FIRST_PAYMENT" };

        /// <summary>
        /// Converts a BillingCancellationPolicyEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BillingCancellationPolicyEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BillingCancellationPolicyEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BillingCancellationPolicyEnum.AFTER_FIRST_PAYMENT:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BillingCancellationPolicyEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BillingCancellationPolicyEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BillingCancellationPolicyEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BillingCancellationPolicyEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BillingCancellationPolicyEnum value</returns>
        public static BillingCancellationPolicyEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BillingCancellationPolicyEnum");

            return (BillingCancellationPolicyEnum) index;
        }
    }
} 