using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BankIdentifierTypeEnum
    {
        SORT_CODE, //TODO: Write general description for this method
        SWIFT, //TODO: Write general description for this method
        IBAN, //TODO: Write general description for this method
        ABA, //TODO: Write general description for this method
        ABA_WIRE, //TODO: Write general description for this method
        ABA_ACH, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BankIdentifierTypeEnum
    /// </summary>
    public static class BankIdentifierTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "SORT_CODE", "SWIFT", "IBAN", "ABA", "ABA_WIRE", "ABA_ACH" };

        /// <summary>
        /// Converts a BankIdentifierTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BankIdentifierTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BankIdentifierTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BankIdentifierTypeEnum.SORT_CODE:
                case BankIdentifierTypeEnum.SWIFT:
                case BankIdentifierTypeEnum.IBAN:
                case BankIdentifierTypeEnum.ABA:
                case BankIdentifierTypeEnum.ABA_WIRE:
                case BankIdentifierTypeEnum.ABA_ACH:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BankIdentifierTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BankIdentifierTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BankIdentifierTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BankIdentifierTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BankIdentifierTypeEnum value</returns>
        public static BankIdentifierTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BankIdentifierTypeEnum");

            return (BankIdentifierTypeEnum) index;
        }
    }
} 