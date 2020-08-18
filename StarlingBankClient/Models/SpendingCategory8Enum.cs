using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategory8Enum
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
    /// Helper for the enum type SpendingCategory8Enum
    /// </summary>
    public static class SpendingCategory8EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BILLS_AND_SERVICES", "CHARITY", "EATING_OUT", "ENTERTAINMENT", "EXPENSES", "FAMILY", "GENERAL", "GIFTS", "GROCERIES", "HOME", "INCOME", "SAVING", "SHOPPING", "HOLIDAYS", "PAYMENTS", "PETS", "TRANSPORT", "LIFESTYLE", "NONE", "REVENUE", "OTHER_INCOME", "CLIENT_REFUNDS", "INVENTORY", "STAFF", "TRAVEL", "WORKPLACE", "REPAIRS_AND_MAINTENANCE", "ADMIN", "MARKETING", "BUSINESS_ENTERTAINMENT", "INTEREST_PAYMENTS", "BANK_CHARGES", "OTHER", "FOOD_AND_DRINK", "EQUIPMENT", "PROFESSIONAL_SERVICES", "PHONE_AND_INTERNET", "VEHICLES", "DIRECTORS_WAGES", "VAT", "CORPORATION_TAX", "SELF_ASSESSMENT_TAX", "INVESTMENT_CAPITAL", "TRANSFERS", "LOAN_PRINCIPAL", "PERSONAL", "DIVIDENDS" };

        /// <summary>
        /// Converts a SpendingCategory8Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategory8Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategory8Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategory8Enum.BILLS_AND_SERVICES:
                case SpendingCategory8Enum.CHARITY:
                case SpendingCategory8Enum.EATING_OUT:
                case SpendingCategory8Enum.ENTERTAINMENT:
                case SpendingCategory8Enum.EXPENSES:
                case SpendingCategory8Enum.FAMILY:
                case SpendingCategory8Enum.GENERAL:
                case SpendingCategory8Enum.GIFTS:
                case SpendingCategory8Enum.GROCERIES:
                case SpendingCategory8Enum.HOME:
                case SpendingCategory8Enum.INCOME:
                case SpendingCategory8Enum.SAVING:
                case SpendingCategory8Enum.SHOPPING:
                case SpendingCategory8Enum.HOLIDAYS:
                case SpendingCategory8Enum.PAYMENTS:
                case SpendingCategory8Enum.PETS:
                case SpendingCategory8Enum.TRANSPORT:
                case SpendingCategory8Enum.LIFESTYLE:
                case SpendingCategory8Enum.NONE:
                case SpendingCategory8Enum.REVENUE:
                case SpendingCategory8Enum.OTHER_INCOME:
                case SpendingCategory8Enum.CLIENT_REFUNDS:
                case SpendingCategory8Enum.INVENTORY:
                case SpendingCategory8Enum.STAFF:
                case SpendingCategory8Enum.TRAVEL:
                case SpendingCategory8Enum.WORKPLACE:
                case SpendingCategory8Enum.REPAIRS_AND_MAINTENANCE:
                case SpendingCategory8Enum.ADMIN:
                case SpendingCategory8Enum.MARKETING:
                case SpendingCategory8Enum.BUSINESS_ENTERTAINMENT:
                case SpendingCategory8Enum.INTEREST_PAYMENTS:
                case SpendingCategory8Enum.BANK_CHARGES:
                case SpendingCategory8Enum.OTHER:
                case SpendingCategory8Enum.FOOD_AND_DRINK:
                case SpendingCategory8Enum.EQUIPMENT:
                case SpendingCategory8Enum.PROFESSIONAL_SERVICES:
                case SpendingCategory8Enum.PHONE_AND_INTERNET:
                case SpendingCategory8Enum.VEHICLES:
                case SpendingCategory8Enum.DIRECTORS_WAGES:
                case SpendingCategory8Enum.VAT:
                case SpendingCategory8Enum.CORPORATION_TAX:
                case SpendingCategory8Enum.SELF_ASSESSMENT_TAX:
                case SpendingCategory8Enum.INVESTMENT_CAPITAL:
                case SpendingCategory8Enum.TRANSFERS:
                case SpendingCategory8Enum.LOAN_PRINCIPAL:
                case SpendingCategory8Enum.PERSONAL:
                case SpendingCategory8Enum.DIVIDENDS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategory8Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategory8Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategory8Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SpendingCategory8Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategory8Enum value</returns>
        public static SpendingCategory8Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategory8Enum");

            return (SpendingCategory8Enum) index;
        }
    }
} 