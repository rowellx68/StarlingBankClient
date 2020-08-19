using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum ProductSubscriptionStatusEnum
    {
        CREATED, //TODO: Write general description for this method
        ACTIVATED, //TODO: Write general description for this method
        CANCELLED, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ProductSubscriptionStatusEnum
    /// </summary>
    public static class ProductSubscriptionStatusEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CREATED", "ACTIVATED", "CANCELLED" };

        /// <summary>
        /// Converts a ProductSubscriptionStatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ProductSubscriptionStatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ProductSubscriptionStatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ProductSubscriptionStatusEnum.CREATED:
                case ProductSubscriptionStatusEnum.ACTIVATED:
                case ProductSubscriptionStatusEnum.CANCELLED:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ProductSubscriptionStatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ProductSubscriptionStatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ProductSubscriptionStatusEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into ProductSubscriptionStatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ProductSubscriptionStatusEnum value</returns>
        public static ProductSubscriptionStatusEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type ProductSubscriptionStatusEnum");

            return (ProductSubscriptionStatusEnum) index;
        }
    }
} 