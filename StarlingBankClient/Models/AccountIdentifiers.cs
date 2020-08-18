using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class AccountIdentifiers : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountIdentifier;
        private string bankIdentifier;
        private string iban;
        private string bic;
        private List<AccountIdentifier> accountIdentifiers;

        /// <summary>
        /// Identifier to uniquely identify the account at the bank
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
        /// Identifier to uniquely identify the bank
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
        /// International identifier to uniquely identify the account at the bank
        /// </summary>
        [JsonProperty("iban")]
        public string Iban 
        { 
            get => iban;
            set 
            {
                iban = value;
                OnPropertyChanged("Iban");
            }
        }

        /// <summary>
        /// International identifier to uniquely identify the bank
        /// </summary>
        [JsonProperty("bic")]
        public string Bic 
        { 
            get => bic;
            set 
            {
                bic = value;
                OnPropertyChanged("Bic");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountIdentifiers")]
        public List<AccountIdentifier> AccountIdentifiersProp 
        { 
            get => accountIdentifiers;
            set 
            {
                accountIdentifiers = value;
                OnPropertyChanged("AccountIdentifiersProp");
            }
        }
    }
} 