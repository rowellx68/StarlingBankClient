using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class MastercardFeedItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string merchantIdentifier;
        private int? mcc;
        private LocalTime posTimestamp;
        private string authorisationCode;
        private string cardLast4;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("merchantIdentifier")]
        public string MerchantIdentifier 
        { 
            get => merchantIdentifier;
            set 
            {
                merchantIdentifier = value;
                OnPropertyChanged("MerchantIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mcc")]
        public int? Mcc 
        { 
            get => mcc;
            set 
            {
                mcc = value;
                OnPropertyChanged("Mcc");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("posTimestamp")]
        public LocalTime PosTimestamp 
        { 
            get => posTimestamp;
            set 
            {
                posTimestamp = value;
                OnPropertyChanged("PosTimestamp");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authorisationCode")]
        public string AuthorisationCode 
        { 
            get => authorisationCode;
            set 
            {
                authorisationCode = value;
                OnPropertyChanged("AuthorisationCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cardLast4")]
        public string CardLast4 
        { 
            get => cardLast4;
            set 
            {
                cardLast4 = value;
                OnPropertyChanged("CardLast4");
            }
        }
    }
} 