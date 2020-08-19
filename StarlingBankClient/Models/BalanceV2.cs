using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class BalanceV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private CurrencyAndAmount clearedBalance;
        private CurrencyAndAmount effectiveBalance;
        private CurrencyAndAmount pendingTransactions;
        private CurrencyAndAmount acceptedOverdraft;
        private CurrencyAndAmount amount;

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("clearedBalance")]
        public CurrencyAndAmount ClearedBalance 
        { 
            get => clearedBalance;
            set 
            {
                clearedBalance = value;
                OnPropertyChanged("ClearedBalance");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("effectiveBalance")]
        public CurrencyAndAmount EffectiveBalance 
        { 
            get => effectiveBalance;
            set 
            {
                effectiveBalance = value;
                OnPropertyChanged("EffectiveBalance");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("pendingTransactions")]
        public CurrencyAndAmount PendingTransactions 
        { 
            get => pendingTransactions;
            set 
            {
                pendingTransactions = value;
                OnPropertyChanged("PendingTransactions");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("acceptedOverdraft")]
        public CurrencyAndAmount AcceptedOverdraft 
        { 
            get => acceptedOverdraft;
            set 
            {
                acceptedOverdraft = value;
                OnPropertyChanged("AcceptedOverdraft");
            }
        }

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