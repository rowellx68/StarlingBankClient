using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum CounterPartyTypeEnum
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
    /// Helper for the enum type CounterPartyTypeEnum
    /// </summary>
    public static class CounterPartyTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CATEGORY", "CHEQUE", "CUSTOMER", "PAYEE", "MERCHANT", "SENDER", "STARLING", "LOAN" };

        /// <summary>
        /// Converts a CounterPartyTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The CounterPartyTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(CounterPartyTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case CounterPartyTypeEnum.CATEGORY:
                case CounterPartyTypeEnum.CHEQUE:
                case CounterPartyTypeEnum.CUSTOMER:
                case CounterPartyTypeEnum.PAYEE:
                case CounterPartyTypeEnum.MERCHANT:
                case CounterPartyTypeEnum.SENDER:
                case CounterPartyTypeEnum.STARLING:
                case CounterPartyTypeEnum.LOAN:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of CounterPartyTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of CounterPartyTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<CounterPartyTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into CounterPartyTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed CounterPartyTypeEnum value</returns>
        public static CounterPartyTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type CounterPartyTypeEnum");

            return (CounterPartyTypeEnum) index;
        }
    }
} 