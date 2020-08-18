using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class AccountStatementPeriod : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string period;
        private bool mpartial;
        private DateTime? endsAt;

        /// <summary>
        /// The period for which the statement is available
        /// </summary>
        [JsonProperty("period")]
        public string Period 
        { 
            get => period;
            set 
            {
                period = value;
                OnPropertyChanged("Period");
            }
        }

        /// <summary>
        /// Is the statement for this period partial
        /// </summary>
        [JsonProperty("partial")]
        public bool Partial 
        { 
            get => mpartial;
            set 
            {
                mpartial = value;
                OnPropertyChanged("Partial");
            }
        }

        /// <summary>
        /// End timestamp for the period
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endsAt")]
        public DateTime? EndsAt 
        { 
            get => endsAt;
            set 
            {
                endsAt = value;
                OnPropertyChanged("EndsAt");
            }
        }
    }
} 