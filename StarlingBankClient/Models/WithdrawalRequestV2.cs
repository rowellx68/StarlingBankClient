using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class WithdrawalRequestV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private CurrencyAndAmount amount;

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