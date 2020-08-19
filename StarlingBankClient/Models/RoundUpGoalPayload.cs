using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class RoundUpGoalPayload : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid roundUpGoalUid;
        private int roundUpMultiplier;

        /// <summary>
        /// UID of the account category to send round-ups to
        /// </summary>
        [JsonProperty("roundUpGoalUid")]
        public Guid RoundUpGoalUid 
        { 
            get => roundUpGoalUid;
            set 
            {
                roundUpGoalUid = value;
                OnPropertyChanged("RoundUpGoalUid");
            }
        }

        /// <summary>
        /// How much to multiply the rounded-up amount by before transfer. Must be an integer between 1 and 10 (inclusive)
        /// </summary>
        [JsonProperty("roundUpMultiplier")]
        public int RoundUpMultiplier 
        { 
            get => roundUpMultiplier;
            set 
            {
                roundUpMultiplier = value;
                OnPropertyChanged("RoundUpMultiplier");
            }
        }
    }
} 