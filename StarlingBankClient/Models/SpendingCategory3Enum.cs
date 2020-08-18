using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SpendingCategory3Enum
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
    /// Helper for the enum type SpendingCategory3Enum
    /// </summary>
    public static class SpendingCategory3EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "BILLS_AND_SERVICES", "CHARITY", "EATING_OUT", "ENTERTAINMENT", "EXPENSES", "FAMILY", "GENERAL", "GIFTS", "GROCERIES", "HOME", "INCOME", "SAVING", "SHOPPING", "HOLIDAYS", "PAYMENTS", "PETS", "TRANSPORT", "LIFESTYLE", "NONE", "REVENUE", "OTHER_INCOME", "CLIENT_REFUNDS", "INVENTORY", "STAFF", "TRAVEL", "WORKPLACE", "REPAIRS_AND_MAINTENANCE", "ADMIN", "MARKETING", "BUSINESS_ENTERTAINMENT", "INTEREST_PAYMENTS", "BANK_CHARGES", "OTHER", "FOOD_AND_DRINK", "EQUIPMENT", "PROFESSIONAL_SERVICES", "PHONE_AND_INTERNET", "VEHICLES", "DIRECTORS_WAGES", "VAT", "CORPORATION_TAX", "SELF_ASSESSMENT_TAX", "INVESTMENT_CAPITAL", "TRANSFERS", "LOAN_PRINCIPAL", "PERSONAL", "DIVIDENDS" };

        /// <summary>
        /// Converts a SpendingCategory3Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SpendingCategory3Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SpendingCategory3Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SpendingCategory3Enum.BILLS_AND_SERVICES:
                case SpendingCategory3Enum.CHARITY:
                case SpendingCategory3Enum.EATING_OUT:
                case SpendingCategory3Enum.ENTERTAINMENT:
                case SpendingCategory3Enum.EXPENSES:
                case SpendingCategory3Enum.FAMILY:
                case SpendingCategory3Enum.GENERAL:
                case SpendingCategory3Enum.GIFTS:
                case SpendingCategory3Enum.GROCERIES:
                case SpendingCategory3Enum.HOME:
                case SpendingCategory3Enum.INCOME:
                case SpendingCategory3Enum.SAVING:
                case SpendingCategory3Enum.SHOPPING:
                case SpendingCategory3Enum.HOLIDAYS:
                case SpendingCategory3Enum.PAYMENTS:
                case SpendingCategory3Enum.PETS:
                case SpendingCategory3Enum.TRANSPORT:
                case SpendingCategory3Enum.LIFESTYLE:
                case SpendingCategory3Enum.NONE:
                case SpendingCategory3Enum.REVENUE:
                case SpendingCategory3Enum.OTHER_INCOME:
                case SpendingCategory3Enum.CLIENT_REFUNDS:
                case SpendingCategory3Enum.INVENTORY:
                case SpendingCategory3Enum.STAFF:
                case SpendingCategory3Enum.TRAVEL:
                case SpendingCategory3Enum.WORKPLACE:
                case SpendingCategory3Enum.REPAIRS_AND_MAINTENANCE:
                case SpendingCategory3Enum.ADMIN:
                case SpendingCategory3Enum.MARKETING:
                case SpendingCategory3Enum.BUSINESS_ENTERTAINMENT:
                case SpendingCategory3Enum.INTEREST_PAYMENTS:
                case SpendingCategory3Enum.BANK_CHARGES:
                case SpendingCategory3Enum.OTHER:
                case SpendingCategory3Enum.FOOD_AND_DRINK:
                case SpendingCategory3Enum.EQUIPMENT:
                case SpendingCategory3Enum.PROFESSIONAL_SERVICES:
                case SpendingCategory3Enum.PHONE_AND_INTERNET:
                case SpendingCategory3Enum.VEHICLES:
                case SpendingCategory3Enum.DIRECTORS_WAGES:
                case SpendingCategory3Enum.VAT:
                case SpendingCategory3Enum.CORPORATION_TAX:
                case SpendingCategory3Enum.SELF_ASSESSMENT_TAX:
                case SpendingCategory3Enum.INVESTMENT_CAPITAL:
                case SpendingCategory3Enum.TRANSFERS:
                case SpendingCategory3Enum.LOAN_PRINCIPAL:
                case SpendingCategory3Enum.PERSONAL:
                case SpendingCategory3Enum.DIVIDENDS:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SpendingCategory3Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SpendingCategory3Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SpendingCategory3Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into SpendingCategory3Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SpendingCategory3Enum value</returns>
        public static SpendingCategory3Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type SpendingCategory3Enum");

            return (SpendingCategory3Enum) index;
        }
    }
} 