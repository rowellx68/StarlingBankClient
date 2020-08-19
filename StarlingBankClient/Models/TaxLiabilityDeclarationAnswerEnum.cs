using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum TaxLiabilityDeclarationAnswerEnum
    {
        YES, //TODO: Write general description for this method
        NO, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type TaxLiabilityDeclarationAnswerEnum
    /// </summary>
    public static class TaxLiabilityDeclarationAnswerEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "YES", "NO" };

        /// <summary>
        /// Converts a TaxLiabilityDeclarationAnswerEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The TaxLiabilityDeclarationAnswerEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(TaxLiabilityDeclarationAnswerEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case TaxLiabilityDeclarationAnswerEnum.YES:
                case TaxLiabilityDeclarationAnswerEnum.NO:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of TaxLiabilityDeclarationAnswerEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of TaxLiabilityDeclarationAnswerEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<TaxLiabilityDeclarationAnswerEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into TaxLiabilityDeclarationAnswerEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed TaxLiabilityDeclarationAnswerEnum value</returns>
        public static TaxLiabilityDeclarationAnswerEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type TaxLiabilityDeclarationAnswerEnum");

            return (TaxLiabilityDeclarationAnswerEnum) index;
        }
    }
} 