using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BenefitTypeEnum
    {
        EUR_BUSINESS_CURRENT_ACCOUNT, //TODO: Write general description for this method
        USD_BUSINESS_CURRENT_ACCOUNT, //TODO: Write general description for this method
        BUSINESS_INVOICE_TOOLS, //TODO: Write general description for this method
        BUSINESS_BOOKKEEPING_TOOLS, //TODO: Write general description for this method
        BUSINESS_EXPENSE_TOOLS, //TODO: Write general description for this method
        BUSINESS_VAT_TOOLS, //TODO: Write general description for this method
        BUSINESS_SA_TAX_TOOLS, //TODO: Write general description for this method
        BUSINESS_BULK_PAYMENT_TOOLS, //TODO: Write general description for this method
        IZETTLE_BOOKKEEPING_TOOLS, //TODO: Write general description for this method
        CHILD_SPACE, //TODO: Write general description for this method
        GBP_INDIVIDUAL_ADDITIONAL_ACCOUNT, //TODO: Write general description for this method
        GBP_JOINT_ADDITIONAL_ACCOUNT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BenefitTypeEnum
    /// </summary>
    public static class BenefitTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "EUR_BUSINESS_CURRENT_ACCOUNT", "USD_BUSINESS_CURRENT_ACCOUNT", "BUSINESS_INVOICE_TOOLS", "BUSINESS_BOOKKEEPING_TOOLS", "BUSINESS_EXPENSE_TOOLS", "BUSINESS_VAT_TOOLS", "BUSINESS_SA_TAX_TOOLS", "BUSINESS_BULK_PAYMENT_TOOLS", "IZETTLE_BOOKKEEPING_TOOLS", "CHILD_SPACE", "GBP_INDIVIDUAL_ADDITIONAL_ACCOUNT", "GBP_JOINT_ADDITIONAL_ACCOUNT" };

        /// <summary>
        /// Converts a BenefitTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BenefitTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BenefitTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BenefitTypeEnum.EUR_BUSINESS_CURRENT_ACCOUNT:
                case BenefitTypeEnum.USD_BUSINESS_CURRENT_ACCOUNT:
                case BenefitTypeEnum.BUSINESS_INVOICE_TOOLS:
                case BenefitTypeEnum.BUSINESS_BOOKKEEPING_TOOLS:
                case BenefitTypeEnum.BUSINESS_EXPENSE_TOOLS:
                case BenefitTypeEnum.BUSINESS_VAT_TOOLS:
                case BenefitTypeEnum.BUSINESS_SA_TAX_TOOLS:
                case BenefitTypeEnum.BUSINESS_BULK_PAYMENT_TOOLS:
                case BenefitTypeEnum.IZETTLE_BOOKKEEPING_TOOLS:
                case BenefitTypeEnum.CHILD_SPACE:
                case BenefitTypeEnum.GBP_INDIVIDUAL_ADDITIONAL_ACCOUNT:
                case BenefitTypeEnum.GBP_JOINT_ADDITIONAL_ACCOUNT:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BenefitTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BenefitTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BenefitTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BenefitTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BenefitTypeEnum value</returns>
        public static BenefitTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BenefitTypeEnum");

            return (BenefitTypeEnum) index;
        }
    }
} 