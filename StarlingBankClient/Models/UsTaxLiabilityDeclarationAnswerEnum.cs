using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum UsTaxLiabilityDeclarationAnswerEnum
    {
        YES, //TODO: Write general description for this method
        NO, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type UsTaxLiabilityDeclarationAnswerEnum
    /// </summary>
    public static class UsTaxLiabilityDeclarationAnswerEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "YES", "NO" };

        /// <summary>
        /// Converts a UsTaxLiabilityDeclarationAnswerEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The UsTaxLiabilityDeclarationAnswerEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(UsTaxLiabilityDeclarationAnswerEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case UsTaxLiabilityDeclarationAnswerEnum.YES:
                case UsTaxLiabilityDeclarationAnswerEnum.NO:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of UsTaxLiabilityDeclarationAnswerEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of UsTaxLiabilityDeclarationAnswerEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<UsTaxLiabilityDeclarationAnswerEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into UsTaxLiabilityDeclarationAnswerEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed UsTaxLiabilityDeclarationAnswerEnum value</returns>
        public static UsTaxLiabilityDeclarationAnswerEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type UsTaxLiabilityDeclarationAnswerEnum");

            return (UsTaxLiabilityDeclarationAnswerEnum) index;
        }
    }
} 