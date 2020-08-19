using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class UpdateSpendingCategory : BaseModel 
    {
        // These fields hold the values for the public properties.
        private SpendingCategoryEnum spendingCategory;
        private bool? permanentSpendingCategoryUpdate;
        private bool? previousSpendingCategoryReferencesUpdate;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategoryEnum SpendingCategory 
        { 
            get => spendingCategory;
            set 
            {
                spendingCategory = value;
                OnPropertyChanged("SpendingCategory");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("permanentSpendingCategoryUpdate")]
        public bool? PermanentSpendingCategoryUpdate 
        { 
            get => permanentSpendingCategoryUpdate;
            set 
            {
                permanentSpendingCategoryUpdate = value;
                OnPropertyChanged("PermanentSpendingCategoryUpdate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("previousSpendingCategoryReferencesUpdate")]
        public bool? PreviousSpendingCategoryReferencesUpdate 
        { 
            get => previousSpendingCategoryReferencesUpdate;
            set 
            {
                previousSpendingCategoryReferencesUpdate = value;
                OnPropertyChanged("PreviousSpendingCategoryReferencesUpdate");
            }
        }
    }
} 