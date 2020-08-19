using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class SpendingCounterPartySummary : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string period;
        private double? totalSpent;
        private double? totalReceived;
        private double? netSpend;
        private double? totalSpendNetOut;
        private double? totalReceivedNetIn;
        private CurrencyEnum? currency;
        private DirectionEnum? direction;
        private List<SpendingCounterPartyBreakdown> breakdown;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("period")]
        public string Period 
        { 
            get => period;
            set 
            {
                period = value;
                OnPropertyChanged("Period");
            }
        }

        /// <summary>
        /// Amount spent from the account in the month
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
        /// Amount received to the account in the month
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
        /// |totalReceived - totalSpent|, i.e. how much the balance has changed in the month
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
        /// Sum of netSpend for counter parties whose net direction for the month is OUT
        /// </summary>
        [JsonProperty("totalSpendNetOut")]
        public double? TotalSpendNetOut 
        { 
            get => totalSpendNetOut;
            set 
            {
                totalSpendNetOut = value;
                OnPropertyChanged("TotalSpendNetOut");
            }
        }

        /// <summary>
        /// Sum of netSpend for counter parties whose net direction for the month is IN
        /// </summary>
        [JsonProperty("totalReceivedNetIn")]
        public double? TotalReceivedNetIn 
        { 
            get => totalReceivedNetIn;
            set 
            {
                totalReceivedNetIn = value;
                OnPropertyChanged("TotalReceivedNetIn");
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
        /// IN if totalReceived > totalSpent else OUT
        /// </summary>
        [JsonProperty("direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public DirectionEnum? Direction 
        { 
            get => direction;
            set 
            {
                direction = value;
                OnPropertyChanged("Direction");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("breakdown")]
        public List<SpendingCounterPartyBreakdown> Breakdown 
        { 
            get => breakdown;
            set 
            {
                breakdown = value;
                OnPropertyChanged("Breakdown");
            }
        }
    }
} 