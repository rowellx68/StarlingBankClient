using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategoryEnum
    {
        BILLS_AND_SERVICES, //TODO: Write general description for this method
        CHARITY, //TODO: Write general description for this method
        EATING_OUT, //TODO: Write general description for this method
        ENTERTAINMENT, //TODO: Write general description for this method
        EXPENSES, //TODO: Write general description for this method
        FAMILY, //TODO: Write general description for this method
        GENERAL, //TODO: Write general description for this method
        GIFTS, //TODO: Write general description for this method
        GROCERIES, //TODO: Write general description for this method
        HOME, //TODO: Write general description for this method
        INCOME, //TODO: Write general description for this method
        SAVING, //TODO: Write general description for this method
        SHOPPING, //TODO: Write general description for this method
        HOLIDAYS, //TODO: Write general description for this method
        PAYMENTS, //TODO: Write general description for this method
        PETS, //TODO: Write general description for this method
        TRANSPORT, //TODO: Write general description for this method
        LIFESTYLE, //TODO: Write general description for this method
        NONE, //TODO: Write general description for this method
        REVENUE, //TODO: Write general description for this method
        OTHER_INCOME, //TODO: Write general description for this method
        CLIENT_REFUNDS, //TODO: Write general description for this method
        INVENTORY, //TODO: Write general description for this method
        STAFF, //TODO: Write general description for this method
        TRAVEL, //TODO: Write general description for this method
        WORKPLACE, //TODO: Write general description for this method
        REPAIRS_AND_MAINTENANCE, //TODO: Write general description for this method
        ADMIN, //TODO: Write general description for this method
        MARKETING, //TODO: Write general description for this method
        BUSINESS_ENTERTAINMENT, //TODO: Write general description for this method
        INTEREST_PAYMENTS, //TODO: Write general description for this method
        BANK_CHARGES, //TODO: Write general description for this method
        OTHER, //TODO: Write general description for this method
        FOOD_AND_DRINK, //TODO: Write general description for this method
        EQUIPMENT, //TODO: Write general description for this method
        PROFESSIONAL_SERVICES, //TODO: Write general description for this method
        PHONE_AND_INTERNET, //TODO: Write general description for this method
        VEHICLES, //TODO: Write general description for this method
        DIRECTORS_WAGES, //TODO: Write general description for this method
        VAT, //TODO: Write general description for this method
        CORPORATION_TAX, //TODO: Write general description for this method
        SELF_ASSESSMENT_TAX, //TODO: Write general description for this method
        INVESTMENT_CAPITAL, //TODO: Write general description for this method
        TRANSFERS, //TODO: Write general description for this method
        LOAN_PRINCIPAL, //TODO: Write general description for this method
        PERSONAL, //TODO: Write general description for this method
        DIVIDENDS, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SpendingCategoryEnum
    /// </summary>
    public static class SpendingCategoryEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BILLS_AND_SERVICES", "CHARITY", "EATING_OUT", "ENTERTAINMENT", "EXPENSES", "FAMILY", "GENERAL", "GIFTS", "GROCERIES", "HOME", "INCOME", "SAVING", "SHOPPING", "HOLIDAYS", "PAYMENTS", "PETS", "TRANSPORT", "LIFESTYLE", "NONE", "REVENUE", "OTHER_INCOME", "CLIENT_REFUNDS", "INVENTORY", "STAFF", "TRAVEL", "WORKPLACE", "REPAIRS_AND_MAINTENANCE", "ADMIN", "MARKETING", "BUSINESS_ENTERTAINMENT", "INTEREST_PAYMENTS", "BANK_CHARGES", "OTHER", "FOOD_AND_DRINK", "EQUIPMENT", "PROFESSIONAL_SERVICES", "PHONE_AND_INTERNET", "VEHICLES", "DIRECTORS_WAGES", "VAT", "CORPORATION_TAX", "SELF_ASSESSMENT_TAX", "INVESTMENT_CAPITAL", "TRANSFERS", "LOAN_PRINCIPAL", "PERSONAL", "DIVIDENDS" };

        /// <summary>
        /// Converts a SpendingCategoryEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategoryEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategoryEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategoryEnum.BILLS_AND_SERVICES:
                case SpendingCategoryEnum.CHARITY:
                case SpendingCategoryEnum.EATING_OUT:
                case SpendingCategoryEnum.ENTERTAINMENT:
                case SpendingCategoryEnum.EXPENSES:
                case SpendingCategoryEnum.FAMILY:
                case SpendingCategoryEnum.GENERAL:
                case SpendingCategoryEnum.GIFTS:
                case SpendingCategoryEnum.GROCERIES:
                case SpendingCategoryEnum.HOME:
                case SpendingCategoryEnum.INCOME:
                case SpendingCategoryEnum.SAVING:
                case SpendingCategoryEnum.SHOPPING:
                case SpendingCategoryEnum.HOLIDAYS:
                case SpendingCategoryEnum.PAYMENTS:
                case SpendingCategoryEnum.PETS:
                case SpendingCategoryEnum.TRANSPORT:
                case SpendingCategoryEnum.LIFESTYLE:
                case SpendingCategoryEnum.NONE:
                case SpendingCategoryEnum.REVENUE:
                case SpendingCategoryEnum.OTHER_INCOME:
                case SpendingCategoryEnum.CLIENT_REFUNDS:
                case SpendingCategoryEnum.INVENTORY:
                case SpendingCategoryEnum.STAFF:
                case SpendingCategoryEnum.TRAVEL:
                case SpendingCategoryEnum.WORKPLACE:
                case SpendingCategoryEnum.REPAIRS_AND_MAINTENANCE:
                case SpendingCategoryEnum.ADMIN:
                case SpendingCategoryEnum.MARKETING:
                case SpendingCategoryEnum.BUSINESS_ENTERTAINMENT:
                case SpendingCategoryEnum.INTEREST_PAYMENTS:
                case SpendingCategoryEnum.BANK_CHARGES:
                case SpendingCategoryEnum.OTHER:
                case SpendingCategoryEnum.FOOD_AND_DRINK:
                case SpendingCategoryEnum.EQUIPMENT:
                case SpendingCategoryEnum.PROFESSIONAL_SERVICES:
                case SpendingCategoryEnum.PHONE_AND_INTERNET:
                case SpendingCategoryEnum.VEHICLES:
                case SpendingCategoryEnum.DIRECTORS_WAGES:
                case SpendingCategoryEnum.VAT:
                case SpendingCategoryEnum.CORPORATION_TAX:
                case SpendingCategoryEnum.SELF_ASSESSMENT_TAX:
                case SpendingCategoryEnum.INVESTMENT_CAPITAL:
                case SpendingCategoryEnum.TRANSFERS:
                case SpendingCategoryEnum.LOAN_PRINCIPAL:
                case SpendingCategoryEnum.PERSONAL:
                case SpendingCategoryEnum.DIVIDENDS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategoryEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategoryEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategoryEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SpendingCategoryEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategoryEnum value</returns>
        public static SpendingCategoryEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategoryEnum");

            return (SpendingCategoryEnum) index;
        }
    }
} 