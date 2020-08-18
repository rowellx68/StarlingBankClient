using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class SavingsGoalsV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<SavingsGoalV2> savingsGoalList;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("savingsGoalList")]
        public List<SavingsGoalV2> SavingsGoalList 
        { 
            get => savingsGoalList;
            set 
            {
                savingsGoalList = value;
                OnPropertyChanged("SavingsGoalList");
            }
        }
    }
} 