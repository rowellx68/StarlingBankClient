using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SpendingCategoryBreakdown : BaseModel 
    {
        // These fields hold the values for the public properties.
        private SpendingCategoryEnum? spendingCategory;
        private double? totalSpent;
        private double? totalReceived;
        private double? netSpend;
        private NetDirectionEnum? netDirection;
        private CurrencyEnum? currency;
        private double? percentage;
        private long? transactionCount;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategoryEnum? SpendingCategory 
        { 
            get => spendingCategory;
            set 
            {
                spendingCategory = value;
                OnPropertyChanged("SpendingCategory");
            }
        }

        /// <summary>
        /// Amount spent under this spending category
        /// </summary>
        [JsonProperty("totalSpent")]
        public double? TotalSpent 
        { 
            get => totalSpent;
            set 
            {
                totalSpent = value;
                OnPropertyChanged("TotalSpent");
            }
        }

        /// <summary>
        /// Amount received under this spending category
        /// </summary>
        [JsonProperty("totalReceived")]
        public double? TotalReceived 
        { 
            get => totalReceived;
            set 
            {
                totalReceived = value;
                OnPropertyChanged("TotalReceived");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("netSpend")]
        public double? NetSpend 
        { 
            get => netSpend;
            set 
            {
                netSpend = value;
                OnPropertyChanged("NetSpend");
            }
        }

        /// <summary>
        /// IN if totalReceived > totalSpent else OUT
        /// </summary>
        [JsonProperty("netDirection", ItemConverterType = typeof(StringValuedEnumConverter))]
        public NetDirectionEnum? NetDirection 
        { 
            get => netDirection;
            set 
            {
                netDirection = value;
                OnPropertyChanged("NetDirection");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CurrencyEnum? Currency 
        { 
            get => currency;
            set 
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Percentage that the netSpend makes up of the sum of the netSpends of breakdowns in the same period with the same netDirection
        /// </summary>
        [JsonProperty("percentage")]
        public double? Percentage 
        { 
            get => percentage;
            set 
            {
                percentage = value;
                OnPropertyChanged("Percentage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transactionCount")]
        public long? TransactionCount 
        { 
            get => transactionCount;
            set 
            {
                transactionCount = value;
                OnPropertyChanged("TransactionCount");
            }
        }
    }
} 