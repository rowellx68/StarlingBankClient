using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class PaymentRecipient : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string payeeName;
        private PayeeTypeEnum payeeType;
        private string countryCode;
        private string accountIdentifier;
        private string bankIdentifier;
        private BankIdentifierTypeEnum bankIdentifierType;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payeeName")]
        public string PayeeName 
        { 
            get => payeeName;
            set 
            {
                payeeName = value;
                OnPropertyChanged("PayeeName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payeeType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PayeeTypeEnum PayeeType 
        { 
            get => payeeType;
            set 
            {
                payeeType = value;
                OnPropertyChanged("PayeeType");
            }
        }

        /// <summary>
        /// The country code for the account (ISO 3166-1 alpha-2)
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode 
        { 
            get => countryCode;
            set 
            {
                countryCode = value;
                OnPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier 
        { 
            get => accountIdentifier;
            set 
            {
                accountIdentifier = value;
                OnPropertyChanged("AccountIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bankIdentifier")]
        public string BankIdentifier 
        { 
            get => bankIdentifier;
            set 
            {
                bankIdentifier = value;
                OnPropertyChanged("BankIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bankIdentifierType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BankIdentifierTypeEnum BankIdentifierType 
        { 
            get => bankIdentifierType;
            set 
            {
                bankIdentifierType = value;
                OnPropertyChanged("BankIdentifierType");
            }
        }
    }
} 