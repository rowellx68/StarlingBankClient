using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class RoundUpGoalDetails : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid primaryCategoryUid;
        private Guid roundUpGoalUid;
        private double roundUpMultiplier;
        private DateTime activatedAt;
        private Guid activatedBy;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("primaryCategoryUid")]
        public Guid PrimaryCategoryUid 
        { 
            get => primaryCategoryUid;
            set 
            {
                primaryCategoryUid = value;
                OnPropertyChanged("PrimaryCategoryUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("roundUpMultiplier")]
        public double RoundUpMultiplier 
        { 
            get => roundUpMultiplier;
            set 
            {
                roundUpMultiplier = value;
                OnPropertyChanged("RoundUpMultiplier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("activatedAt")]
        public DateTime ActivatedAt 
        { 
            get => activatedAt;
            set 
            {
                activatedAt = value;
                OnPropertyChanged("ActivatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("activatedBy")]
        public Guid ActivatedBy 
        { 
            get => activatedBy;
            set 
            {
                activatedBy = value;
                OnPropertyChanged("ActivatedBy");
            }
        }
    }
} 