using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategory7Enum
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
    /// Helper for the enum type SpendingCategory7Enum
    /// </summary>
    public static class SpendingCategory7EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BILLS_AND_SERVICES", "CHARITY", "EATING_OUT", "ENTERTAINMENT", "EXPENSES", "FAMILY", "GENERAL", "GIFTS", "GROCERIES", "HOME", "INCOME", "SAVING", "SHOPPING", "HOLIDAYS", "PAYMENTS", "PETS", "TRANSPORT", "LIFESTYLE", "NONE", "REVENUE", "OTHER_INCOME", "CLIENT_REFUNDS", "INVENTORY", "STAFF", "TRAVEL", "WORKPLACE", "REPAIRS_AND_MAINTENANCE", "ADMIN", "MARKETING", "BUSINESS_ENTERTAINMENT", "INTEREST_PAYMENTS", "BANK_CHARGES", "OTHER", "FOOD_AND_DRINK", "EQUIPMENT", "PROFESSIONAL_SERVICES", "PHONE_AND_INTERNET", "VEHICLES", "DIRECTORS_WAGES", "VAT", "CORPORATION_TAX", "SELF_ASSESSMENT_TAX", "INVESTMENT_CAPITAL", "TRANSFERS", "LOAN_PRINCIPAL", "PERSONAL", "DIVIDENDS" };

        /// <summary>
        /// Converts a SpendingCategory7Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategory7Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategory7Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategory7Enum.BILLS_AND_SERVICES:
                case SpendingCategory7Enum.CHARITY:
                case SpendingCategory7Enum.EATING_OUT:
                case SpendingCategory7Enum.ENTERTAINMENT:
                case SpendingCategory7Enum.EXPENSES:
                case SpendingCategory7Enum.FAMILY:
                case SpendingCategory7Enum.GENERAL:
                case SpendingCategory7Enum.GIFTS:
                case SpendingCategory7Enum.GROCERIES:
                case SpendingCategory7Enum.HOME:
                case SpendingCategory7Enum.INCOME:
                case SpendingCategory7Enum.SAVING:
                case SpendingCategory7Enum.SHOPPING:
                case SpendingCategory7Enum.HOLIDAYS:
                case SpendingCategory7Enum.PAYMENTS:
                case SpendingCategory7Enum.PETS:
                case SpendingCategory7Enum.TRANSPORT:
                case SpendingCategory7Enum.LIFESTYLE:
                case SpendingCategory7Enum.NONE:
                case SpendingCategory7Enum.REVENUE:
                case SpendingCategory7Enum.OTHER_INCOME:
                case SpendingCategory7Enum.CLIENT_REFUNDS:
                case SpendingCategory7Enum.INVENTORY:
                case SpendingCategory7Enum.STAFF:
                case SpendingCategory7Enum.TRAVEL:
                case SpendingCategory7Enum.WORKPLACE:
                case SpendingCategory7Enum.REPAIRS_AND_MAINTENANCE:
                case SpendingCategory7Enum.ADMIN:
                case SpendingCategory7Enum.MARKETING:
                case SpendingCategory7Enum.BUSINESS_ENTERTAINMENT:
                case SpendingCategory7Enum.INTEREST_PAYMENTS:
                case SpendingCategory7Enum.BANK_CHARGES:
                case SpendingCategory7Enum.OTHER:
                case SpendingCategory7Enum.FOOD_AND_DRINK:
                case SpendingCategory7Enum.EQUIPMENT:
                case SpendingCategory7Enum.PROFESSIONAL_SERVICES:
                case SpendingCategory7Enum.PHONE_AND_INTERNET:
                case SpendingCategory7Enum.VEHICLES:
                case SpendingCategory7Enum.DIRECTORS_WAGES:
                case SpendingCategory7Enum.VAT:
                case SpendingCategory7Enum.CORPORATION_TAX:
                case SpendingCategory7Enum.SELF_ASSESSMENT_TAX:
                case SpendingCategory7Enum.INVESTMENT_CAPITAL:
                case SpendingCategory7Enum.TRANSFERS:
                case SpendingCategory7Enum.LOAN_PRINCIPAL:
                case SpendingCategory7Enum.PERSONAL:
                case SpendingCategory7Enum.DIVIDENDS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategory7Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategory7Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategory7Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SpendingCategory7Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategory7Enum value</returns>
        public static SpendingCategory7Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategory7Enum");

            return (SpendingCategory7Enum) index;
        }
    }
} 