using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ScheduledPayments : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<ScheduledPayment> scheduledPayments;

        /// <summary>
        /// List of scheduled payments for a payee account
        /// </summary>
        [JsonProperty("scheduledPayments")]
        public List<ScheduledPayment> ScheduledPaymentsProp 
        { 
            get => scheduledPayments;
            set 
            {
                scheduledPayments = value;
                OnPropertyChanged("ScheduledPaymentsProp");
            }
        }
    }
} 