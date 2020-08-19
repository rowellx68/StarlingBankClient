using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategory2Enum
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
    /// Helper for the enum type SpendingCategory2Enum
    /// </summary>
    public static class SpendingCategory2EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BILLS_AND_SERVICES", "CHARITY", "EATING_OUT", "ENTERTAINMENT", "EXPENSES", "FAMILY", "GENERAL", "GIFTS", "GROCERIES", "HOME", "INCOME", "SAVING", "SHOPPING", "HOLIDAYS", "PAYMENTS", "PETS", "TRANSPORT", "LIFESTYLE", "NONE", "REVENUE", "OTHER_INCOME", "CLIENT_REFUNDS", "INVENTORY", "STAFF", "TRAVEL", "WORKPLACE", "REPAIRS_AND_MAINTENANCE", "ADMIN", "MARKETING", "BUSINESS_ENTERTAINMENT", "INTEREST_PAYMENTS", "BANK_CHARGES", "OTHER", "FOOD_AND_DRINK", "EQUIPMENT", "PROFESSIONAL_SERVICES", "PHONE_AND_INTERNET", "VEHICLES", "DIRECTORS_WAGES", "VAT", "CORPORATION_TAX", "SELF_ASSESSMENT_TAX", "INVESTMENT_CAPITAL", "TRANSFERS", "LOAN_PRINCIPAL", "PERSONAL", "DIVIDENDS" };

        /// <summary>
        /// Converts a SpendingCategory2Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategory2Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategory2Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategory2Enum.BILLS_AND_SERVICES:
                case SpendingCategory2Enum.CHARITY:
                case SpendingCategory2Enum.EATING_OUT:
                case SpendingCategory2Enum.ENTERTAINMENT:
                case SpendingCategory2Enum.EXPENSES:
                case SpendingCategory2Enum.FAMILY:
                case SpendingCategory2Enum.GENERAL:
                case SpendingCategory2Enum.GIFTS:
                case SpendingCategory2Enum.GROCERIES:
                case SpendingCategory2Enum.HOME:
                case SpendingCategory2Enum.INCOME:
                case SpendingCategory2Enum.SAVING:
                case SpendingCategory2Enum.SHOPPING:
                case SpendingCategory2Enum.HOLIDAYS:
                case SpendingCategory2Enum.PAYMENTS:
                case SpendingCategory2Enum.PETS:
                case SpendingCategory2Enum.TRANSPORT:
                case SpendingCategory2Enum.LIFESTYLE:
                case SpendingCategory2Enum.NONE:
                case SpendingCategory2Enum.REVENUE:
                case SpendingCategory2Enum.OTHER_INCOME:
                case SpendingCategory2Enum.CLIENT_REFUNDS:
                case SpendingCategory2Enum.INVENTORY:
                case SpendingCategory2Enum.STAFF:
                case SpendingCategory2Enum.TRAVEL:
                case SpendingCategory2Enum.WORKPLACE:
                case SpendingCategory2Enum.REPAIRS_AND_MAINTENANCE:
                case SpendingCategory2Enum.ADMIN:
                case SpendingCategory2Enum.MARKETING:
                case SpendingCategory2Enum.BUSINESS_ENTERTAINMENT:
                case SpendingCategory2Enum.INTEREST_PAYMENTS:
                case SpendingCategory2Enum.BANK_CHARGES:
                case SpendingCategory2Enum.OTHER:
                case SpendingCategory2Enum.FOOD_AND_DRINK:
                case SpendingCategory2Enum.EQUIPMENT:
                case SpendingCategory2Enum.PROFESSIONAL_SERVICES:
                case SpendingCategory2Enum.PHONE_AND_INTERNET:
                case SpendingCategory2Enum.VEHICLES:
                case SpendingCategory2Enum.DIRECTORS_WAGES:
                case SpendingCategory2Enum.VAT:
                case SpendingCategory2Enum.CORPORATION_TAX:
                case SpendingCategory2Enum.SELF_ASSESSMENT_TAX:
                case SpendingCategory2Enum.INVESTMENT_CAPITAL:
                case SpendingCategory2Enum.TRANSFERS:
                case SpendingCategory2Enum.LOAN_PRINCIPAL:
                case SpendingCategory2Enum.PERSONAL:
                case SpendingCategory2Enum.DIVIDENDS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategory2Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategory2Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategory2Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SpendingCategory2Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategory2Enum value</returns>
        public static SpendingCategory2Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategory2Enum");

            return (SpendingCategory2Enum) index;
        }
    }
} 