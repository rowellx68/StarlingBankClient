using System;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class LastPayment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime? lastDate;
        private CurrencyAndAmount lastAmount;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("lastDate")]
        public DateTime? LastDate 
        { 
            get => lastDate;
            set 
            {
                lastDate = value;
                OnPropertyChanged("LastDate");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("lastAmount")]
        public CurrencyAndAmount LastAmount 
        { 
            get => lastAmount;
            set 
            {
                lastAmount = value;
                OnPropertyChanged("LastAmount");
            }
        }
    }
} 