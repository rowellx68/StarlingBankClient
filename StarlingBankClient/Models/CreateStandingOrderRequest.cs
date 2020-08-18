using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class CreateStandingOrderRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string externalIdentifier;
        private Guid destinationPayeeAccountUid;
        private string reference;
        private CurrencyAndAmount amount;
        private StandingOrderRecurrence standingOrderRecurrence;
        private SpendingCategory4Enum? spendingCategory;

        /// <summary>
        /// External identifier for the standing order request
        /// </summary>
        [JsonProperty("externalIdentifier")]
        public string ExternalIdentifier 
        { 
            get => externalIdentifier;
            set 
            {
                externalIdentifier = value;
                OnPropertyChanged("ExternalIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("destinationPayeeAccountUid")]
        public Guid DestinationPayeeAccountUid 
        { 
            get => destinationPayeeAccountUid;
            set 
            {
                destinationPayeeAccountUid = value;
                OnPropertyChanged("DestinationPayeeAccountUid");
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