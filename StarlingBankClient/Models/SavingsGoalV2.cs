using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SavingsGoalV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? savingsGoalUid;
        private string name;
        private CurrencyAndAmount target;
        private CurrencyAndAmount totalSaved;
        private int? savedPercentage;

        /// <summary>
        /// Unique identifier of the savings goal
        /// </summary>
        [JsonProperty("savingsGoalUid")]
        public Guid? SavingsGoalUid 
        { 
            get => savingsGoalUid;
            set 
            {
                savingsGoalUid = value;
                OnPropertyChanged("SavingsGoalUid");
            }
        }

        /// <summary>
        /// Name of the savings goal
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get => name;
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("target")]
        public CurrencyAndAmount Target 
        { 
            get => target;
            set 
            {
                target = value;
                OnPropertyChanged("Target");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("totalSaved")]
        public CurrencyAndAmount TotalSaved 
        { 
            get => totalSaved;
            set 
            {
                totalSaved = value;
                OnPropertyChanged("TotalSaved");
            }
        }

        /// <summary>
        /// Percentage of target currently deposited in the savings goal
        /// </summary>
        [JsonProperty("savedPercentage")]
        public int? SavedPercentage 
        { 
            get => savedPercentage;
            set 
            {
                savedPercentage = value;
                OnPropertyChanged("SavedPercentage");
            }
        }
    }
} 