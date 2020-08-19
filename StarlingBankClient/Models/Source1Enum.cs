using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Source1Enum
    {
        CASH_DEPOSIT, //TODO: Write general description for this method
        CASH_DEPOSIT_CHARGE, //TODO: Write general description for this method
        CASH_WITHDRAWAL, //TODO: Write general description for this method
        CASH_WITHDRAWAL_CHARGE, //TODO: Write general description for this method
        CHAPS, //TODO: Write general description for this method
        CHEQUE, //TODO: Write general description for this method
        CICS_CHEQUE, //TODO: Write general description for this method
        CURRENCY_CLOUD, //TODO: Write general description for this method
        DIRECT_CREDIT, //TODO: Write general description for this method
        DIRECT_DEBIT, //TODO: Write general description for this method
        DIRECT_DEBIT_DISPUTE, //TODO: Write general description for this method
        INTERNAL_TRANSFER, //TODO: Write general description for this method
        MASTER_CARD, //TODO: Write general description for this method
        MASTERCARD_MONEYSEND, //TODO: Write general description for this method
        MASTERCARD_CHARGEBACK, //TODO: Write general description for this method
        FASTER_PAYMENTS_IN, //TODO: Write general description for this method
        FASTER_PAYMENTS_OUT, //TODO: Write general description for this method
        FASTER_PAYMENTS_REVERSAL, //TODO: Write general description for this method
        STRIPE_FUNDING, //TODO: Write general description for this method
        INTEREST_PAYMENT, //TODO: Write general description for this method
        NOSTRO_DEPOSIT, //TODO: Write general description for this method
        OVERDRAFT, //TODO: Write general description for this method
        OVERDRAFT_INTEREST_WAIVED, //TODO: Write general description for this method
        FASTER_PAYMENTS_REFUND, //TODO: Write general description for this method
        STARLING_PAY_STRIPE, //TODO: Write general description for this method
        ON_US_PAY_ME, //TODO: Write general description for this method
        LOAN_PRINCIPAL_PAYMENT, //TODO: Write general description for this method
        LOAN_REPAYMENT, //TODO: Write general description for this method
        LOAN_OVERPAYMENT, //TODO: Write general description for this method
        LOAN_LATE_PAYMENT, //TODO: Write general description for this method
        SEPA_CREDIT_TRANSFER, //TODO: Write general description for this method
        SEPA_DIRECT_DEBIT, //TODO: Write general description for this method
        TARGET2_CUSTOMER_PAYMENT, //TODO: Write general description for this method
        FX_TRANSFER, //TODO: Write general description for this method
        ISS_PAYMENT, //TODO: Write general description for this method
        STARLING_PAYMENT, //TODO: Write general description for this method
        SUBSCRIPTION_CHARGE, //TODO: Write general description for this method
        OVERDRAFT_FEE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Source1Enum
    /// </summary>
    public static class Source1EnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "CASH_DEPOSIT", "CASH_DEPOSIT_CHARGE", "CASH_WITHDRAWAL", "CASH_WITHDRAWAL_CHARGE", "CHAPS", "CHEQUE", "CICS_CHEQUE", "CURRENCY_CLOUD", "DIRECT_CREDIT", "DIRECT_DEBIT", "DIRECT_DEBIT_DISPUTE", "INTERNAL_TRANSFER", "MASTER_CARD", "MASTERCARD_MONEYSEND", "MASTERCARD_CHARGEBACK", "FASTER_PAYMENTS_IN", "FASTER_PAYMENTS_OUT", "FASTER_PAYMENTS_REVERSAL", "STRIPE_FUNDING", "INTEREST_PAYMENT", "NOSTRO_DEPOSIT", "OVERDRAFT", "OVERDRAFT_INTEREST_WAIVED", "FASTER_PAYMENTS_REFUND", "STARLING_PAY_STRIPE", "ON_US_PAY_ME", "LOAN_PRINCIPAL_PAYMENT", "LOAN_REPAYMENT", "LOAN_OVERPAYMENT", "LOAN_LATE_PAYMENT", "SEPA_CREDIT_TRANSFER", "SEPA_DIRECT_DEBIT", "TARGET2_CUSTOMER_PAYMENT", "FX_TRANSFER", "ISS_PAYMENT", "STARLING_PAYMENT", "SUBSCRIPTION_CHARGE", "OVERDRAFT_FEE" };

        /// <summary>
        /// Converts a Source1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Source1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Source1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Source1Enum.CASH_DEPOSIT:
                case Source1Enum.CASH_DEPOSIT_CHARGE:
                case Source1Enum.CASH_WITHDRAWAL:
                case Source1Enum.CASH_WITHDRAWAL_CHARGE:
                case Source1Enum.CHAPS:
                case Source1Enum.CHEQUE:
                case Source1Enum.CICS_CHEQUE:
                case Source1Enum.CURRENCY_CLOUD:
                case Source1Enum.DIRECT_CREDIT:
                case Source1Enum.DIRECT_DEBIT:
                case Source1Enum.DIRECT_DEBIT_DISPUTE:
                case Source1Enum.INTERNAL_TRANSFER:
                case Source1Enum.MASTER_CARD:
                case Source1Enum.MASTERCARD_MONEYSEND:
                case Source1Enum.MASTERCARD_CHARGEBACK:
                case Source1Enum.FASTER_PAYMENTS_IN:
                case Source1Enum.FASTER_PAYMENTS_OUT:
                case Source1Enum.FASTER_PAYMENTS_REVERSAL:
                case Source1Enum.STRIPE_FUNDING:
                case Source1Enum.INTEREST_PAYMENT:
                case Source1Enum.NOSTRO_DEPOSIT:
                case Source1Enum.OVERDRAFT:
                case Source1Enum.OVERDRAFT_INTEREST_WAIVED:
                case Source1Enum.FASTER_PAYMENTS_REFUND:
                case Source1Enum.STARLING_PAY_STRIPE:
                case Source1Enum.ON_US_PAY_ME:
                case Source1Enum.LOAN_PRINCIPAL_PAYMENT:
                case Source1Enum.LOAN_REPAYMENT:
                case Source1Enum.LOAN_OVERPAYMENT:
                case Source1Enum.LOAN_LATE_PAYMENT:
                case Source1Enum.SEPA_CREDIT_TRANSFER:
                case Source1Enum.SEPA_DIRECT_DEBIT:
                case Source1Enum.TARGET2_CUSTOMER_PAYMENT:
                case Source1Enum.FX_TRANSFER:
                case Source1Enum.ISS_PAYMENT:
                case Source1Enum.STARLING_PAYMENT:
                case Source1Enum.SUBSCRIPTION_CHARGE:
                case Source1Enum.OVERDRAFT_FEE:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Source1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Source1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Source1Enum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into Source1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Source1Enum value</returns>
        public static Source1Enum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type Source1Enum");

            return (Source1Enum) index;
        }
    }
} 