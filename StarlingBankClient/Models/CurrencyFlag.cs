using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class CurrencyFlag : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool enabled;
        private string currency;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled 
        { 
            get => enabled;
            set 
            {
                enabled = value;
                OnPropertyChanged("Enabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
    }
} 