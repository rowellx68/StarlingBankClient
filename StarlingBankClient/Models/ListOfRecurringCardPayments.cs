using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ListOfRecurringCardPayments : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<RecurringCardPayment> recurringPayments;

        /// <summary>
        /// List of recurring card payments
        /// </summary>
        [JsonProperty("recurringPayments")]
        public List<RecurringCardPayment> RecurringPayments 
        { 
            get => recurringPayments;
            set 
            {
                recurringPayments = value;
                OnPropertyChanged("RecurringPayments");
            }
        }
    }
} 