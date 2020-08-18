using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class AccountIdentifier : BaseModel 
    {
        // These fields hold the values for the public properties.
        private IdentifierTypeEnum? identifierType;
        private string bankIdentifier;
        private string accountIdentifier;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("identifierType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public IdentifierTypeEnum? IdentifierType 
        { 
            get => identifierType;
            set 
            {
                identifierType = value;
                OnPropertyChanged("IdentifierType");
            }
        }

        /// <summary>
        /// Identifier to uniquely identify the bank, e.g. a sort code or BIC
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
        /// Identifier to uniquely identify the account at the bank, e.g. an account number or IBAN
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifierProp 
        { 
            get => accountIdentifier;
            set 
            {
                accountIdentifier = value;
                OnPropertyChanged("AccountIdentifierProp");
            }
        }
    }
} 