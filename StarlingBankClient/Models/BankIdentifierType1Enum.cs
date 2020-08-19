using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BankIdentifierType1Enum
    {
        SORT_CODE, //TODO: Write general description for this method
        SWIFT, //TODO: Write general description for this method
        IBAN, //TODO: Write general description for this method
        ABA, //TODO: Write general description for this method
        ABA_WIRE, //TODO: Write general description for this method
        ABA_ACH, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BankIdentifierType1Enum
    /// </summary>
    public static class BankIdentifierType1EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "SORT_CODE", "SWIFT", "IBAN", "ABA", "ABA_WIRE", "ABA_ACH" };

        /// <summary>
        /// Converts a BankIdentifierType1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BankIdentifierType1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BankIdentifierType1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BankIdentifierType1Enum.SORT_CODE:
                case BankIdentifierType1Enum.SWIFT:
                case BankIdentifierType1Enum.IBAN:
                case BankIdentifierType1Enum.ABA:
                case BankIdentifierType1Enum.ABA_WIRE:
                case BankIdentifierType1Enum.ABA_ACH:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BankIdentifierType1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BankIdentifierType1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BankIdentifierType1Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BankIdentifierType1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BankIdentifierType1Enum value</returns>
        public static BankIdentifierType1Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BankIdentifierType1Enum");

            return (BankIdentifierType1Enum) index;
        }
    }
} 