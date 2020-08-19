using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategory4Enum
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
    /// Helper for the enum type SpendingCategory4Enum
    /// </summary>
    public static class SpendingCategory4EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BILLS_AND_SERVICES", "CHARITY", "EATING_OUT", "ENTERTAINMENT", "EXPENSES", "FAMILY", "GENERAL", "GIFTS", "GROCERIES", "HOME", "INCOME", "SAVING", "SHOPPING", "HOLIDAYS", "PAYMENTS", "PETS", "TRANSPORT", "LIFESTYLE", "NONE", "REVENUE", "OTHER_INCOME", "CLIENT_REFUNDS", "INVENTORY", "STAFF", "TRAVEL", "WORKPLACE", "REPAIRS_AND_MAINTENANCE", "ADMIN", "MARKETING", "BUSINESS_ENTERTAINMENT", "INTEREST_PAYMENTS", "BANK_CHARGES", "OTHER", "FOOD_AND_DRINK", "EQUIPMENT", "PROFESSIONAL_SERVICES", "PHONE_AND_INTERNET", "VEHICLES", "DIRECTORS_WAGES", "VAT", "CORPORATION_TAX", "SELF_ASSESSMENT_TAX", "INVESTMENT_CAPITAL", "TRANSFERS", "LOAN_PRINCIPAL", "PERSONAL", "DIVIDENDS" };

        /// <summary>
        /// Converts a SpendingCategory4Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategory4Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategory4Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategory4Enum.BILLS_AND_SERVICES:
                case SpendingCategory4Enum.CHARITY:
                case SpendingCategory4Enum.EATING_OUT:
                case SpendingCategory4Enum.ENTERTAINMENT:
                case SpendingCategory4Enum.EXPENSES:
                case SpendingCategory4Enum.FAMILY:
                case SpendingCategory4Enum.GENERAL:
                case SpendingCategory4Enum.GIFTS:
                case SpendingCategory4Enum.GROCERIES:
                case SpendingCategory4Enum.HOME:
                case SpendingCategory4Enum.INCOME:
                case SpendingCategory4Enum.SAVING:
                case SpendingCategory4Enum.SHOPPING:
                case SpendingCategory4Enum.HOLIDAYS:
                case SpendingCategory4Enum.PAYMENTS:
                case SpendingCategory4Enum.PETS:
                case SpendingCategory4Enum.TRANSPORT:
                case SpendingCategory4Enum.LIFESTYLE:
                case SpendingCategory4Enum.NONE:
                case SpendingCategory4Enum.REVENUE:
                case SpendingCategory4Enum.OTHER_INCOME:
                case SpendingCategory4Enum.CLIENT_REFUNDS:
                case SpendingCategory4Enum.INVENTORY:
                case SpendingCategory4Enum.STAFF:
                case SpendingCategory4Enum.TRAVEL:
                case SpendingCategory4Enum.WORKPLACE:
                case SpendingCategory4Enum.REPAIRS_AND_MAINTENANCE:
                case SpendingCategory4Enum.ADMIN:
                case SpendingCategory4Enum.MARKETING:
                case SpendingCategory4Enum.BUSINESS_ENTERTAINMENT:
                case SpendingCategory4Enum.INTEREST_PAYMENTS:
                case SpendingCategory4Enum.BANK_CHARGES:
                case SpendingCategory4Enum.OTHER:
                case SpendingCategory4Enum.FOOD_AND_DRINK:
                case SpendingCategory4Enum.EQUIPMENT:
                case SpendingCategory4Enum.PROFESSIONAL_SERVICES:
                case SpendingCategory4Enum.PHONE_AND_INTERNET:
                case SpendingCategory4Enum.VEHICLES:
                case SpendingCategory4Enum.DIRECTORS_WAGES:
                case SpendingCategory4Enum.VAT:
                case SpendingCategory4Enum.CORPORATION_TAX:
                case SpendingCategory4Enum.SELF_ASSESSMENT_TAX:
                case SpendingCategory4Enum.INVESTMENT_CAPITAL:
                case SpendingCategory4Enum.TRANSFERS:
                case SpendingCategory4Enum.LOAN_PRINCIPAL:
                case SpendingCategory4Enum.PERSONAL:
                case SpendingCategory4Enum.DIVIDENDS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategory4Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategory4Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategory4Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SpendingCategory4Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategory4Enum value</returns>
        public static SpendingCategory4Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategory4Enum");

            return (SpendingCategory4Enum) index;
        }
    }
} 