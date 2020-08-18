using System;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class ScheduledSavingsPaymentV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid transferUid;
        private RecurrenceRuleV2 recurrenceRule;
        private CurrencyAndAmount currencyAndAmount;
        private DateTime nextPaymentDate;

        /// <summary>
        /// Unique identifier of the transfer
        /// </summary>
        [JsonProperty("transferUid")]
        public Guid TransferUid 
        { 
            get => transferUid;
            set 
            {
                transferUid = value;
                OnPropertyChanged("TransferUid");
            }
        }

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
        [JsonProperty("currencyAndAmount")]
        public CurrencyAndAmount CurrencyAndAmount 
        { 
            get => currencyAndAmount;
            set 
            {
                currencyAndAmount = value;
                OnPropertyChanged("CurrencyAndAmount");
            }
        }

        /// <summary>
        /// The next date the payment will be made on
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextPaymentDate")]
        public DateTime NextPaymentDate 
        { 
            get => nextPaymentDate;
            set 
            {
                nextPaymentDate = value;
                OnPropertyChanged("NextPaymentDate");
            }
        }
    }
} 