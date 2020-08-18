using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class PayeeAccountCreationRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string description;
        private bool defaultAccount;
        private string countryCode;
        private string accountIdentifier;
        private string bankIdentifier;
        private BankIdentifierType1Enum bankIdentifierType;

        /// <summary>
        /// Account description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get => description;
            set 
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Is this the default account for the owning payee
        /// </summary>
        [JsonProperty("defaultAccount")]
        public bool DefaultAccount 
        { 
            get => defaultAccount;
            set 
            {
                defaultAccount = value;
                OnPropertyChanged("DefaultAccount");
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
        /// The account identifier
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
        /// The bank identifier
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
        /// The bank identifier type
        /// </summary>
        [JsonProperty("bankIdentifierType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BankIdentifierType1Enum BankIdentifierType 
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