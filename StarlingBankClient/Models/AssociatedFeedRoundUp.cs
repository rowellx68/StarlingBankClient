using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class AssociatedFeedRoundUp : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? goalCategoryUid;
        private CurrencyAndAmount amount;

        /// <summary>
        /// Unique identifier of associated category
        /// </summary>
        [JsonProperty("goalCategoryUid")]
        public Guid? GoalCategoryUid 
        { 
            get => goalCategoryUid;
            set 
            {
                goalCategoryUid = value;
                OnPropertyChanged("GoalCategoryUid");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount 
        { 
            get => amount;
            set 
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }
    }
} 