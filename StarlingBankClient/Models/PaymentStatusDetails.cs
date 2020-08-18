using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class PaymentStatusDetails : BaseModel 
    {
        // These fields hold the values for the public properties.
        private PaymentStatusEnum? paymentStatus;
        private DescriptionEnum? description;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentStatus", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PaymentStatusEnum? PaymentStatus 
        { 
            get => paymentStatus;
            set 
            {
                paymentStatus = value;
                OnPropertyChanged("PaymentStatus");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description", ItemConverterType = typeof(StringValuedEnumConverter))]
        public DescriptionEnum? Description 
        { 
            get => description;
            set 
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
    }
} 