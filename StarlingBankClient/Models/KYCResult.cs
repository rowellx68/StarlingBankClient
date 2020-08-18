using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class KYCResult : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime? issuedTimestamp;
        private string fraudDecision;
        private string amlDecision;
        private string bureau;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("issuedTimestamp")]
        public DateTime? IssuedTimestamp 
        { 
            get => issuedTimestamp;
            set 
            {
                issuedTimestamp = value;
                OnPropertyChanged("IssuedTimestamp");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fraudDecision")]
        public string FraudDecision 
        { 
            get => fraudDecision;
            set 
            {
                fraudDecision = value;
                OnPropertyChanged("FraudDecision");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amlDecision")]
        public string AmlDecision 
        { 
            get => amlDecision;
            set 
            {
                amlDecision = value;
                OnPropertyChanged("AmlDecision");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bureau")]
        public string Bureau 
        { 
            get => bureau;
            set 
            {
                bureau = value;
                OnPropertyChanged("Bureau");
            }
        }
    }
} 