using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ScheduledSavingsPaymentRequestV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private RecurrenceRuleV2 recurrenceRule;
        private CurrencyAndAmount amount;

        /// <summary>
        /// The schedule definition
        /// </summary>
        [JsonProperty("recurrenceRule")]
        public RecurrenceRuleV2 RecurrenceRule 
        { 
            get => recurrenceRule;
            set 
            {
                recurrenceRule = value;
                OnPropertyChanged("RecurrenceRule");
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