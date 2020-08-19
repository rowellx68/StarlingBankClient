using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Payments : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<PayeePayment> payments;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payments")]
        public List<PayeePayment> PaymentsProp 
        { 
            get => payments;
            set 
            {
                payments = value;
                OnPropertyChanged("PaymentsProp");
            }
        }
    }
} 