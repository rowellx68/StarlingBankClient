using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class PayeePayment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? paymentUid;
        private CurrencyAndAmount amount;
        private string reference;
        private DateTime? createdAt;
        private SpendingCategory8Enum? spendingCategory;
        private CurrencyAndAmount paymentAmount;

        /// <summary>
        /// Unique identifier of the payment
        /// </summary>
        [JsonProperty("paymentUid")]
        public Guid? PaymentUid 
        { 
            get => paymentUid;
            set 
            {
                paymentUid = value;
                OnPropertyChanged("PaymentUid");
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
        /// Payment reference
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
        /// Date when payment was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt 
        { 
            get => createdAt;
            set 
            {
                createdAt = value;
                OnPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// Spending category
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory8Enum? SpendingCategory 
        { 
            get => spendingCategory;
            set 
            {
                spendingCategory = value;
                OnPropertyChanged("SpendingCategory");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("paymentAmount")]
        public CurrencyAndAmount PaymentAmount 
        { 
            get => paymentAmount;
            set 
            {
                paymentAmount = value;
                OnPropertyChanged("PaymentAmount");
            }
        }
    }
} 