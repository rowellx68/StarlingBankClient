using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AccountHolderTypeEnum
    {
        INDIVIDUAL, //TODO: Write general description for this method
        BUSINESS, //TODO: Write general description for this method
        SOLE_TRADER, //TODO: Write general description for this method
        JOINT, //TODO: Write general description for this method
        BANKING_AS_A_SERVICE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type AccountHolderTypeEnum
    /// </summary>
    public static class AccountHolderTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "INDIVIDUAL", "BUSINESS", "SOLE_TRADER", "JOINT", "BANKING_AS_A_SERVICE" };

        /// <summary>
        /// Converts a AccountHolderTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AccountHolderTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AccountHolderTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AccountHolderTypeEnum.INDIVIDUAL:
                case AccountHolderTypeEnum.BUSINESS:
                case AccountHolderTypeEnum.SOLE_TRADER:
                case AccountHolderTypeEnum.JOINT:
                case AccountHolderTypeEnum.BANKING_AS_A_SERVICE:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AccountHolderTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AccountHolderTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AccountHolderTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into AccountHolderTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AccountHolderTypeEnum value</returns>
        public static AccountHolderTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type AccountHolderTypeEnum");

            return (AccountHolderTypeEnum) index;
        }
    }
} 