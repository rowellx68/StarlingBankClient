using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class PaymentOrderV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid paymentOrderUid;
        private CurrencyAndAmount amount;
        private string reference;
        private Guid payeeUid;
        private Guid payeeAccountUid;
        private SpendingCategory3Enum? spendingCategory;

        /// <summary>
        /// UID of this payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid PaymentOrderUid 
        { 
            get => paymentOrderUid;
            set 
            {
                paymentOrderUid = value;
                OnPropertyChanged("PaymentOrderUid");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount 
        { 
            get => amount;
            set 
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// The reference set by the payer
        /// </summary>
        [JsonProperty("reference")]
        public string Reference 
        { 
            get => reference;
            set 
            {
                reference = value;
                OnPropertyChanged("Reference");
            }
        }

        /// <summary>
        /// The ID of the payee receiving this payment
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid PayeeUid 
        { 
            get => payeeUid;
            set 
            {
                payeeUid = value;
                OnPropertyChanged("PayeeUid");
            }
        }

        /// <summary>
        /// The account ID of the payee account receiving this payment
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid PayeeAccountUid 
        { 
            get => payeeAccountUid;
            set 
            {
                payeeAccountUid = value;
                OnPropertyChanged("PayeeAccountUid");
            }
        }

        /// <summary>
        /// Spending category for the payment order
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory3Enum? SpendingCategory 
        { 
            get => spendingCategory;
            set 
            {
                spendingCategory = value;
                OnPropertyChanged("SpendingCategory");
            }
        }
    }
} 