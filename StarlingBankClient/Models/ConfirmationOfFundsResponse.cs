using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ConfirmationOfFundsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? requestedAmountAvailableToSpend;
        private bool? accountWouldBeInOverdraftIfRequestedAmountSpent;

        /// <summary>
        /// True if requested amount is available to spend
        /// </summary>
        [JsonProperty("requestedAmountAvailableToSpend")]
        public bool? RequestedAmountAvailableToSpend 
        { 
            get => requestedAmountAvailableToSpend;
            set 
            {
                requestedAmountAvailableToSpend = value;
                OnPropertyChanged("RequestedAmountAvailableToSpend");
            }
        }

        /// <summary>
        /// True if spending the requested amount would put the account in overdraft
        /// </summary>
        [JsonProperty("accountWouldBeInOverdraftIfRequestedAmountSpent")]
        public bool? AccountWouldBeInOverdraftIfRequestedAmountSpent 
        { 
            get => accountWouldBeInOverdraftIfRequestedAmountSpent;
            set 
            {
                accountWouldBeInOverdraftIfRequestedAmountSpent = value;
                OnPropertyChanged("AccountWouldBeInOverdraftIfRequestedAmountSpent");
            }
        }
    }
} 