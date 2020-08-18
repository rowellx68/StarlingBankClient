using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class SpendingCounterPartyBreakdown : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? counterPartyUid;
        private CounterPartyTypeEnum? counterPartyType;
        private string counterPartyName;
        private string imageIdentifier;
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
        [JsonProperty("counterPartyUid")]
        public Guid? CounterPartyUid 
        { 
            get => counterPartyUid;
            set 
            {
                counterPartyUid = value;
                OnPropertyChanged("CounterPartyUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counterPartyType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CounterPartyTypeEnum? CounterPartyType 
        { 
            get => counterPartyType;
            set 
            {
                counterPartyType = value;
                OnPropertyChanged("CounterPartyType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counterPartyName")]
        public string CounterPartyName 
        { 
            get => counterPartyName;
            set 
            {
                counterPartyName = value;
                OnPropertyChanged("CounterPartyName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("imageIdentifier")]
        public string ImageIdentifier 
        { 
            get => imageIdentifier;
            set 
            {
                imageIdentifier = value;
                OnPropertyChanged("ImageIdentifier");
            }
        }

        /// <summary>
        /// Amount spent at/sent to this counter party
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
        /// Amount received from this counter party
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