using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class StandingOrderRecurrence : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime startDate;
        private FrequencyEnum frequency;
        private int? interval;
        private int? count;
        private DateTime? untilDate;

        /// <summary>
        /// Date that the first standing order payment should be made
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime StartDate 
        { 
            get => startDate;
            set 
            {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// Frequency of which payments should be made
        /// </summary>
        [JsonProperty("frequency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public FrequencyEnum Frequency 
        { 
            get => frequency;
            set 
            {
                frequency = value;
                OnPropertyChanged("Frequency");
            }
        }

        /// <summary>
        /// Interval of specified frequency on which payments should be made
        /// </summary>
        [JsonProperty("interval")]
        public int? Interval 
        { 
            get => interval;
            set 
            {
                interval = value;
                OnPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// Number of payments that should be made before standing order is stopped
        /// </summary>
        [JsonProperty("count")]
        public int? Count 
        { 
            get => count;
            set 
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }

        /// <summary>
        /// Date on which to stop standing order
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("untilDate")]
        public DateTime? UntilDate 
        { 
            get => untilDate;
            set 
            {
                untilDate = value;
                OnPropertyChanged("UntilDate");
            }
        }
    }
} 