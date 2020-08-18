using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum ProductTypeEnum
    {
        BASE, //TODO: Write general description for this method
        ADD_ON, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ProductTypeEnum
    /// </summary>
    public static class ProductTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BASE", "ADD_ON" };

        /// <summary>
        /// Converts a ProductTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ProductTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ProductTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ProductTypeEnum.BASE:
                case ProductTypeEnum.ADD_ON:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ProductTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ProductTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ProductTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into ProductTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ProductTypeEnum value</returns>
        public static ProductTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type ProductTypeEnum");

            return (ProductTypeEnum) index;
        }
    }
} 