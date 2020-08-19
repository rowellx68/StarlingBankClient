using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class InstructLocalPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string externalIdentifier;
        private Guid? destinationPayeeAccountUid;
        private PaymentRecipient paymentRecipient;
        private string reference;
        private CurrencyAndAmount amount;
        private SpendingCategory4Enum? spendingCategory;

        /// <summary>
        /// External identifier for the payment request
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
        /// The desired payment recipient. Either paymentRecipient or destinationPayeeAccountUid must be present
        /// </summary>
        [JsonProperty("destinationPayeeAccountUid")]
        public Guid? DestinationPayeeAccountUid 
        { 
            get => destinationPayeeAccountUid;
            set 
            {
                destinationPayeeAccountUid = value;
                OnPropertyChanged("DestinationPayeeAccountUid");
            }
        }

        /// <summary>
        /// The desired payment recipient. Either paymentRecipient or destinationPayeeAccountUid must be present
        /// </summary>
        [JsonProperty("paymentRecipient")]
        public PaymentRecipient PaymentRecipient 
        { 
            get => paymentRecipient;
            set 
            {
                paymentRecipient = value;
                OnPropertyChanged("PaymentRecipient");
            }
        }

        /// <summary>
        /// The payment reference. The 35 character limit applies to SEPA payments (Euro accounts). For FPS payments (GBP accounts), the limit is 18 characters
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