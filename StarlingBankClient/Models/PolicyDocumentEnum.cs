using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum PolicyDocumentEnum
    {
        ACCOUNT_TERMS, //TODO: Write general description for this method
        STARLING_PRIVACY_POLICY, //TODO: Write general description for this method
        FSCS_INFORMATION, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PolicyDocumentEnum
    /// </summary>
    public static class PolicyDocumentEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ACCOUNT_TERMS", "STARLING_PRIVACY_POLICY", "FSCS_INFORMATION" };

        /// <summary>
        /// Converts a PolicyDocumentEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PolicyDocumentEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PolicyDocumentEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PolicyDocumentEnum.ACCOUNT_TERMS:
                case PolicyDocumentEnum.STARLING_PRIVACY_POLICY:
                case PolicyDocumentEnum.FSCS_INFORMATION:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PolicyDocumentEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PolicyDocumentEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PolicyDocumentEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into PolicyDocumentEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PolicyDocumentEnum value</returns>
        public static PolicyDocumentEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type PolicyDocumentEnum");

            return (PolicyDocumentEnum) index;
        }
    }
} 