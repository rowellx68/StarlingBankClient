using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class StandingOrder : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? paymentOrderUid;
        private CurrencyAndAmount amount;
        private string reference;
        private Guid? payeeUid;
        private Guid? payeeAccountUid;
        private StandingOrderRecurrence standingOrderRecurrence;
        private DateTime? nextDate;
        private DateTime? cancelledAt;
        private DateTime? updatedAt;
        private SpendingCategory7Enum? spendingCategory;

        /// <summary>
        /// UID of this payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid 
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
        /// The ID of the payee receiving the payments
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid? PayeeUid 
        { 
            get => payeeUid;
            set 
            {
                payeeUid = value;
                OnPropertyChanged("PayeeUid");
            }
        }

        /// <summary>
        /// The account ID of the payee account receiving the payments
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid? PayeeAccountUid 
        { 
            get => payeeAccountUid;
            set 
            {
                payeeAccountUid = value;
                OnPropertyChanged("PayeeAccountUid");
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
        /// Date on which the next standing order payment will be made
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextDate")]
        public DateTime? NextDate 
        { 
            get => nextDate;
            set 
            {
                nextDate = value;
                OnPropertyChanged("NextDate");
            }
        }

        /// <summary>
        /// The time the standing order is cancelled at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cancelledAt")]
        public DateTime? CancelledAt 
        { 
            get => cancelledAt;
            set 
            {
                cancelledAt = value;
                OnPropertyChanged("CancelledAt");
            }
        }

        /// <summary>
        /// The time the standing order is updated at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt 
        { 
            get => updatedAt;
            set 
            {
                updatedAt = value;
                OnPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// Optional spending category for the standing order
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory7Enum? SpendingCategory 
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