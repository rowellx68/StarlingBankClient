using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class SpendingCountryBreakdown : BaseModel 
    {
        // These fields hold the values for the public properties.
        private CountryCodeEnum? countryCode;
        private double? totalSpent;
        private double? totalReceived;
        private double? netSpend;
        private NetDirectionEnum? netDirection;
        private CurrencyEnum? currency;
        private double? percentage;
        private long? transactionCount;

        /// <summary>
        /// The country code for this spending insights entry (ISO 3166-1 alpha-2)
        /// </summary>
        [JsonProperty("countryCode", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CountryCodeEnum? CountryCode 
        { 
            get => countryCode;
            set 
            {
                countryCode = value;
                OnPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// Amount spent in/sent to this country
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
        /// Amount received from this country
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