using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class PaymentOrderPaymentsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<PaymentOrderPayment> payments;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payments")]
        public List<PaymentOrderPayment> Payments 
        { 
            get => payments;
            set 
            {
                payments = value;
                OnPropertyChanged("Payments");
            }
        }
    }
} 