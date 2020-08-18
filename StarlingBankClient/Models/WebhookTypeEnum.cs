using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum WebhookTypeEnum
    {
        INTEREST_CHARGE, //TODO: Write general description for this method
        SCHEDULED_PAYMENT_CANCELLED, //TODO: Write general description for this method
        SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS, //TODO: Write general description for this method
        TRANSACTION_CARD, //TODO: Write general description for this method
        TRANSACTION_CASH_WITHDRAWAL, //TODO: Write general description for this method
        TRANSACTION_MOBILE_WALLET, //TODO: Write general description for this method
        TRANSACTION_DIRECT_CREDIT, //TODO: Write general description for this method
        TRANSACTION_DIRECT_DEBIT, //TODO: Write general description for this method
        TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS, //TODO: Write general description for this method
        TRANSACTION_DIRECT_DEBIT_DISPUTE, //TODO: Write general description for this method
        TRANSACTION_FASTER_PAYMENT_IN, //TODO: Write general description for this method
        TRANSACTION_FASTER_PAYMENT_OUT, //TODO: Write general description for this method
        TRANSACTION_FASTER_PAYMENT_REVERSAL, //TODO: Write general description for this method
        TRANSACTION_INTEREST_PAYMENT, //TODO: Write general description for this method
        TRANSACTION_INTERNAL_TRANSFER, //TODO: Write general description for this method
        TRANSACTION_NOSTRO_DEPOSIT, //TODO: Write general description for this method
        TRANSACTION_ON_US_PAYMENT_IN, //TODO: Write general description for this method
        TRANSACTION_ON_US_PAYMENT_OUT, //TODO: Write general description for this method
        TRANSACTION_INTEREST_WAIVED_DEPOSIT, //TODO: Write general description for this method
        TRANSACTION_STRIPE_FUNDING, //TODO: Write general description for this method
        TRANSACTION_DECLINED_INSUFFICIENT_FUNDS, //TODO: Write general description for this method
        TRANSACTION_AUTH_DECLINED, //TODO: Write general description for this method
        TRANSACTION_AUTH_PARTIAL_REVERSAL, //TODO: Write general description for this method
        TRANSACTION_AUTH_FULL_REVERSAL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type WebhookTypeEnum
    /// </summary>
    public static class WebhookTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "INTEREST_CHARGE", "SCHEDULED_PAYMENT_CANCELLED", "SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS", "TRANSACTION_CARD", "TRANSACTION_CASH_WITHDRAWAL", "TRANSACTION_MOBILE_WALLET", "TRANSACTION_DIRECT_CREDIT", "TRANSACTION_DIRECT_DEBIT", "TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS", "TRANSACTION_DIRECT_DEBIT_DISPUTE", "TRANSACTION_FASTER_PAYMENT_IN", "TRANSACTION_FASTER_PAYMENT_OUT", "TRANSACTION_FASTER_PAYMENT_REVERSAL", "TRANSACTION_INTEREST_PAYMENT", "TRANSACTION_INTERNAL_TRANSFER", "TRANSACTION_NOSTRO_DEPOSIT", "TRANSACTION_ON_US_PAYMENT_IN", "TRANSACTION_ON_US_PAYMENT_OUT", "TRANSACTION_INTEREST_WAIVED_DEPOSIT", "TRANSACTION_STRIPE_FUNDING", "TRANSACTION_DECLINED_INSUFFICIENT_FUNDS", "TRANSACTION_AUTH_DECLINED", "TRANSACTION_AUTH_PARTIAL_REVERSAL", "TRANSACTION_AUTH_FULL_REVERSAL" };

        /// <summary>
        /// Converts a WebhookTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The WebhookTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(WebhookTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case WebhookTypeEnum.INTEREST_CHARGE:
                case WebhookTypeEnum.SCHEDULED_PAYMENT_CANCELLED:
                case WebhookTypeEnum.SCHEDULED_PAYMENT_INSUFFICIENT_FUNDS:
                case WebhookTypeEnum.TRANSACTION_CARD:
                case WebhookTypeEnum.TRANSACTION_CASH_WITHDRAWAL:
                case WebhookTypeEnum.TRANSACTION_MOBILE_WALLET:
                case WebhookTypeEnum.TRANSACTION_DIRECT_CREDIT:
                case WebhookTypeEnum.TRANSACTION_DIRECT_DEBIT:
                case WebhookTypeEnum.TRANSACTION_DIRECT_DEBIT_INSUFFICIENT_FUNDS:
                case WebhookTypeEnum.TRANSACTION_DIRECT_DEBIT_DISPUTE:
                case WebhookTypeEnum.TRANSACTION_FASTER_PAYMENT_IN:
                case WebhookTypeEnum.TRANSACTION_FASTER_PAYMENT_OUT:
                case WebhookTypeEnum.TRANSACTION_FASTER_PAYMENT_REVERSAL:
                case WebhookTypeEnum.TRANSACTION_INTEREST_PAYMENT:
                case WebhookTypeEnum.TRANSACTION_INTERNAL_TRANSFER:
                case WebhookTypeEnum.TRANSACTION_NOSTRO_DEPOSIT:
                case WebhookTypeEnum.TRANSACTION_ON_US_PAYMENT_IN:
                case WebhookTypeEnum.TRANSACTION_ON_US_PAYMENT_OUT:
                case WebhookTypeEnum.TRANSACTION_INTEREST_WAIVED_DEPOSIT:
                case WebhookTypeEnum.TRANSACTION_STRIPE_FUNDING:
                case WebhookTypeEnum.TRANSACTION_DECLINED_INSUFFICIENT_FUNDS:
                case WebhookTypeEnum.TRANSACTION_AUTH_DECLINED:
                case WebhookTypeEnum.TRANSACTION_AUTH_PARTIAL_REVERSAL:
                case WebhookTypeEnum.TRANSACTION_AUTH_FULL_REVERSAL:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of WebhookTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of WebhookTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<WebhookTypeEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into WebhookTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed WebhookTypeEnum value</returns>
        public static WebhookTypeEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type WebhookTypeEnum");

            return (WebhookTypeEnum) index;
        }
    }
} 