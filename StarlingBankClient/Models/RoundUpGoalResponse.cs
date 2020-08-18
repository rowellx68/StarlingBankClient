using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class RoundUpGoalResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? active;
        private RoundUpGoalDetails roundUpGoal;
        private RoundUpGoalDetails roundUpGoalDetails;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("active")]
        public bool? Active 
        { 
            get => active;
            set 
            {
                active = value;
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpGoal")]
        public RoundUpGoalDetails RoundUpGoal 
        { 
            get => roundUpGoal;
            set 
            {
                roundUpGoal = value;
                OnPropertyChanged("RoundUpGoal");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpGoalDetails")]
        public RoundUpGoalDetails RoundUpGoalDetails 
        { 
            get => roundUpGoalDetails;
            set 
            {
                roundUpGoalDetails = value;
                OnPropertyChanged("RoundUpGoalDetails");
            }
        }
    }
} 