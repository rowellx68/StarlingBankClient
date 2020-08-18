using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class LocalTime : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? hour;
        private int? minute;
        private int? second;
        private int? nano;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("hour")]
        public int? Hour 
        { 
            get => hour;
            set 
            {
                hour = value;
                OnPropertyChanged("Hour");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("minute")]
        public int? Minute 
        { 
            get => minute;
            set 
            {
                minute = value;
                OnPropertyChanged("Minute");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("second")]
        public int? Second 
        { 
            get => second;
            set 
            {
                second = value;
                OnPropertyChanged("Second");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nano")]
        public int? Nano 
        { 
            get => nano;
            set 
            {
                nano = value;
                OnPropertyChanged("Nano");
            }
        }
    }
} 