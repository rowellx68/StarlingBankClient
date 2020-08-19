using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SoleTrader : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string tradingAsName;
        private BusinessCategoryEnum? businessCategory;
        private BusinessSubCategoryEnum? businessSubCategory;

        /// <summary>
        /// Trading as name
        /// </summary>
        [JsonProperty("tradingAsName")]
        public string TradingAsName 
        { 
            get => tradingAsName;
            set 
            {
                tradingAsName = value;
                OnPropertyChanged("TradingAsName");
            }
        }

        /// <summary>
        /// Business category
        /// </summary>
        [JsonProperty("businessCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BusinessCategoryEnum? BusinessCategory 
        { 
            get => businessCategory;
            set 
            {
                businessCategory = value;
                OnPropertyChanged("BusinessCategory");
            }
        }

        /// <summary>
        /// Business subcategory
        /// </summary>
        [JsonProperty("businessSubCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BusinessSubCategoryEnum? BusinessSubCategory 
        { 
            get => businessSubCategory;
            set 
            {
                businessSubCategory = value;
                OnPropertyChanged("BusinessSubCategory");
            }
        }
    }
} 