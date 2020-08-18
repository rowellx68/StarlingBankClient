using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class SavingsGoalRequestV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string currency;
        private CurrencyAndAmount target;
        private string base64EncodedPhoto;

        /// <summary>
        /// Name of the savings goal
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get => name;
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// ISO-4217 3 character currency code of the savings goal
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get => currency;
            set 
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("target")]
        public CurrencyAndAmount Target 
        { 
            get => target;
            set 
            {
                target = value;
                OnPropertyChanged("Target");
            }
        }

        /// <summary>
        /// A text (base 64) encoded picture to associate with the savings goal
        /// </summary>
        [JsonProperty("base64EncodedPhoto")]
        public string Base64EncodedPhoto 
        { 
            get => base64EncodedPhoto;
            set 
            {
                base64EncodedPhoto = value;
                OnPropertyChanged("Base64EncodedPhoto");
            }
        }
    }
} 