using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class CurrencyAndAmount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string currency;
        private long minorUnits;

        /// <summary>
        /// ISO-4217 3 character currency code
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
        /// Amount in the minor units of the given currency; eg pence in GBP, cents in EUR
        /// </summary>
        [JsonProperty("minorUnits")]
        public long MinorUnits 
        { 
            get => minorUnits;
            set 
            {
                minorUnits = value;
                OnPropertyChanged("MinorUnits");
            }
        }
    }
} 