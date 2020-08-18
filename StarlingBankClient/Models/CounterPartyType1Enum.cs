using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CounterPartyType1Enum
    {
        CATEGORY, //TODO: Write general description for this method
        CHEQUE, //TODO: Write general description for this method
        CUSTOMER, //TODO: Write general description for this method
        PAYEE, //TODO: Write general description for this method
        MERCHANT, //TODO: Write general description for this method
        SENDER, //TODO: Write general description for this method
        STARLING, //TODO: Write general description for this method
        LOAN, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type CounterPartyType1Enum
    /// </summary>
    public static class CounterPartyType1EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CATEGORY", "CHEQUE", "CUSTOMER", "PAYEE", "MERCHANT", "SENDER", "STARLING", "LOAN" };

        /// <summary>
        /// Converts a CounterPartyType1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CounterPartyType1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CounterPartyType1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CounterPartyType1Enum.CATEGORY:
                case CounterPartyType1Enum.CHEQUE:
                case CounterPartyType1Enum.CUSTOMER:
                case CounterPartyType1Enum.PAYEE:
                case CounterPartyType1Enum.MERCHANT:
                case CounterPartyType1Enum.SENDER:
                case CounterPartyType1Enum.STARLING:
                case CounterPartyType1Enum.LOAN:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CounterPartyType1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CounterPartyType1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CounterPartyType1Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into CounterPartyType1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CounterPartyType1Enum value</returns>
        public static CounterPartyType1Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CounterPartyType1Enum");

            return (CounterPartyType1Enum) index;
        }
    }
} 