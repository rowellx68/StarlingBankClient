using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum OnboardingStageEnum
    {
        ONBOARDING_REQUEST_SUBMITTED, //TODO: Write general description for this method
        ONBOARDING_COMPLETE, //TODO: Write general description for this method
        ONBOARDING_REJECTED, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type OnboardingStageEnum
    /// </summary>
    public static class OnboardingStageEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "ONBOARDING_REQUEST_SUBMITTED", "ONBOARDING_COMPLETE", "ONBOARDING_REJECTED" };

        /// <summary>
        /// Converts a OnboardingStageEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OnboardingStageEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OnboardingStageEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OnboardingStageEnum.ONBOARDING_REQUEST_SUBMITTED:
                case OnboardingStageEnum.ONBOARDING_COMPLETE:
                case OnboardingStageEnum.ONBOARDING_REJECTED:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OnboardingStageEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OnboardingStageEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OnboardingStageEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into OnboardingStageEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OnboardingStageEnum value</returns>
        public static OnboardingStageEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type OnboardingStageEnum");

            return (OnboardingStageEnum) index;
        }
    }
} 