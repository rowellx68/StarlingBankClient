using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UpdateStandingOrderRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid paymentOrderUid;
        private string reference;
        private CurrencyAndAmount amount;
        private StandingOrderRecurrence standingOrderRecurrence;
        private SpendingCategory4Enum? spendingCategory;

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
        /// The payment reference
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
        /// Recurrence rules of a standing order
        /// </summary>
        [JsonProperty("standingOrderRecurrence")]
        public StandingOrderRecurrence StandingOrderRecurrence 
        { 
            get => standingOrderRecurrence;
            set 
            {
                standingOrderRecurrence = value;
                OnPropertyChanged("StandingOrderRecurrence");
            }
        }

        /// <summary>
        /// Optional spending category to associate with this payment
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory4Enum? SpendingCategory 
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