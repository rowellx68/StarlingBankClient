using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class DirectDebitPaymentsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<DirectDebitPayment> directDebitPayments;

        /// <summary>
        /// List of processed direct debit mandate payments
        /// </summary>
        [JsonProperty("directDebitPayments")]
        public List<DirectDebitPayment> DirectDebitPayments 
        { 
            get => directDebitPayments;
            set 
            {
                directDebitPayments = value;
                OnPropertyChanged("DirectDebitPayments");
            }
        }
    }
} 