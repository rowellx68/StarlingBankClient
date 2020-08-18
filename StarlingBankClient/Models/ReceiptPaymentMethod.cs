using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ReceiptPaymentMethod : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? paymentMethodUid;
        private string description;
        private double amount;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentMethodUid")]
        public Guid? PaymentMethodUid 
        { 
            get => paymentMethodUid;
            set 
            {
                paymentMethodUid = value;
                OnPropertyChanged("PaymentMethodUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get => description;
            set 
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double Amount 
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