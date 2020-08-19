using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SettleUpProfile : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Status3Enum status;
        private string starlingPayLink;
        private string settleUpLink;

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status3Enum Status 
        { 
            get => status;
            set 
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("starlingPayLink")]
        public string StarlingPayLink 
        { 
            get => starlingPayLink;
            set 
            {
                starlingPayLink = value;
                OnPropertyChanged("StarlingPayLink");
            }
        }

        /// <summary>
        /// Settle Up link
        /// </summary>
        [JsonProperty("settleUpLink")]
        public string SettleUpLink 
        { 
            get => settleUpLink;
            set 
            {
                settleUpLink = value;
                OnPropertyChanged("SettleUpLink");
            }
        }
    }
} 