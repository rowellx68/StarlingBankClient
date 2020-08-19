using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class DirectDebitPayment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private CurrencyAndAmount paymentAmount;
        private DateTime? createdAt;

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("paymentAmount")]
        public CurrencyAndAmount PaymentAmount 
        { 
            get => paymentAmount;
            set 
            {
                paymentAmount = value;
                OnPropertyChanged("PaymentAmount");
            }
        }

        /// <summary>
        /// Date when direct debit payment was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt 
        { 
            get => createdAt;
            set 
            {
                createdAt = value;
                OnPropertyChanged("CreatedAt");
            }
        }
    }
} 