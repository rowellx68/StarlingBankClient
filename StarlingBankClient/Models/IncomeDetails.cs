using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class IncomeDetails : BaseModel 
    {
        // These fields hold the values for the public properties.
        private CurrencyAndAmount annualIncome;
        private List<SourceOfFundEnum> sourceOfFunds;

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("annualIncome")]
        public CurrencyAndAmount AnnualIncome 
        { 
            get => annualIncome;
            set 
            {
                annualIncome = value;
                OnPropertyChanged("AnnualIncome");
            }
        }

        /// <summary>
        /// Account holder's source of funds
        /// </summary>
        [JsonProperty("sourceOfFunds", ItemConverterType = typeof(StringValuedEnumConverter))]
        public List<SourceOfFundEnum> SourceOfFunds 
        { 
            get => sourceOfFunds;
            set 
            {
                sourceOfFunds = value;
                OnPropertyChanged("SourceOfFunds");
            }
        }
    }
} 