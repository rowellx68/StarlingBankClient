using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SourceSubTypeEnum
    {
        CONTACTLESS, //TODO: Write general description for this method
        MAGNETIC_STRIP, //TODO: Write general description for this method
        MANUAL_KEY_ENTRY, //TODO: Write general description for this method
        CHIP_AND_PIN, //TODO: Write general description for this method
        ONLINE, //TODO: Write general description for this method
        ATM, //TODO: Write general description for this method
        CREDIT_AUTH, //TODO: Write general description for this method
        APPLE_PAY, //TODO: Write general description for this method
        ANDROID_PAY, //TODO: Write general description for this method
        FITBIT_PAY, //TODO: Write general description for this method
        GARMIN_PAY, //TODO: Write general description for this method
        SAMSUNG_PAY, //TODO: Write general description for this method
        OTHER_WALLET, //TODO: Write general description for this method
        NOT_APPLICABLE, //TODO: Write general description for this method
        UNKNOWN, //TODO: Write general description for this method
        DEPOSIT, //TODO: Write general description for this method
        OVERDRAFT, //TODO: Write general description for this method
        SETTLE_UP, //TODO: Write general description for this method
        NEARBY, //TODO: Write general description for this method
        TRANSFER_SAME_CURRENCY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SourceSubTypeEnum
    /// </summary>
    public static class SourceSubTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CONTACTLESS", "MAGNETIC_STRIP", "MANUAL_KEY_ENTRY", "CHIP_AND_PIN", "ONLINE", "ATM", "CREDIT_AUTH", "APPLE_PAY", "ANDROID_PAY", "FITBIT_PAY", "GARMIN_PAY", "SAMSUNG_PAY", "OTHER_WALLET", "NOT_APPLICABLE", "UNKNOWN", "DEPOSIT", "OVERDRAFT", "SETTLE_UP", "NEARBY", "TRANSFER_SAME_CURRENCY" };

        /// <summary>
        /// Converts a SourceSubTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SourceSubTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SourceSubTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SourceSubTypeEnum.CONTACTLESS:
                case SourceSubTypeEnum.MAGNETIC_STRIP:
                case SourceSubTypeEnum.MANUAL_KEY_ENTRY:
                case SourceSubTypeEnum.CHIP_AND_PIN:
                case SourceSubTypeEnum.ONLINE:
                case SourceSubTypeEnum.ATM:
                case SourceSubTypeEnum.CREDIT_AUTH:
                case SourceSubTypeEnum.APPLE_PAY:
                case SourceSubTypeEnum.ANDROID_PAY:
                case SourceSubTypeEnum.FITBIT_PAY:
                case SourceSubTypeEnum.GARMIN_PAY:
                case SourceSubTypeEnum.SAMSUNG_PAY:
                case SourceSubTypeEnum.OTHER_WALLET:
                case SourceSubTypeEnum.NOT_APPLICABLE:
                case SourceSubTypeEnum.UNKNOWN:
                case SourceSubTypeEnum.DEPOSIT:
                case SourceSubTypeEnum.OVERDRAFT:
                case SourceSubTypeEnum.SETTLE_UP:
                case SourceSubTypeEnum.NEARBY:
                case SourceSubTypeEnum.TRANSFER_SAME_CURRENCY:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SourceSubTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SourceSubTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SourceSubTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SourceSubTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SourceSubTypeEnum value</returns>
        public static SourceSubTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SourceSubTypeEnum");

            return (SourceSubTypeEnum) index;
        }
    }
} 