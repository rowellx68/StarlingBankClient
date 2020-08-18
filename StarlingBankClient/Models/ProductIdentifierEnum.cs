using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum ProductIdentifierEnum
    {
        EUR_BUSINESS_CURRENT_ACCOUNT, //TODO: Write general description for this method
        USD_BUSINESS_CURRENT_ACCOUNT, //TODO: Write general description for this method
        SOLE_TRADER_TOOLKIT, //TODO: Write general description for this method
        BUSINESS_TOOLKIT, //TODO: Write general description for this method
        CHILD_SPACE, //TODO: Write general description for this method
        GBP_INDIVIDUAL_ADDITIONAL_ACCOUNT, //TODO: Write general description for this method
        GBP_JOINT_ADDITIONAL_ACCOUNT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ProductIdentifierEnum
    /// </summary>
    public static class ProductIdentifierEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "EUR_BUSINESS_CURRENT_ACCOUNT", "USD_BUSINESS_CURRENT_ACCOUNT", "SOLE_TRADER_TOOLKIT", "BUSINESS_TOOLKIT", "CHILD_SPACE", "GBP_INDIVIDUAL_ADDITIONAL_ACCOUNT", "GBP_JOINT_ADDITIONAL_ACCOUNT" };

        /// <summary>
        /// Converts a ProductIdentifierEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ProductIdentifierEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ProductIdentifierEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ProductIdentifierEnum.EUR_BUSINESS_CURRENT_ACCOUNT:
                case ProductIdentifierEnum.USD_BUSINESS_CURRENT_ACCOUNT:
                case ProductIdentifierEnum.SOLE_TRADER_TOOLKIT:
                case ProductIdentifierEnum.BUSINESS_TOOLKIT:
                case ProductIdentifierEnum.CHILD_SPACE:
                case ProductIdentifierEnum.GBP_INDIVIDUAL_ADDITIONAL_ACCOUNT:
                case ProductIdentifierEnum.GBP_JOINT_ADDITIONAL_ACCOUNT:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ProductIdentifierEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ProductIdentifierEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ProductIdentifierEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into ProductIdentifierEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ProductIdentifierEnum value</returns>
        public static ProductIdentifierEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type ProductIdentifierEnum");

            return (ProductIdentifierEnum) index;
        }
    }
} 