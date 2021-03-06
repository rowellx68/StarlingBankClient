using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class InstructLocalPaymentResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? paymentOrderUid;
        private ConsentInformation consentInformation;

        /// <summary>
        /// The uid of the payment order created by the instruction. N.B. this will not be the uid of any payment which is created by the payment order
        /// </summary>
        [JsonProperty("paymentOrderUid")]
        public Guid? PaymentOrderUid 
        { 
            get => paymentOrderUid;
            set 
            {
                paymentOrderUid = value;
                OnPropertyChanged("PaymentOrderUid");
            }
        }

        /// <summary>
        /// Denotes whether a request has been paused in order for the user to approve it.
        /// </summary>
        [JsonProperty("consentInformation")]
        public ConsentInformation ConsentInformation 
        { 
            get => consentInformation;
            set 
            {
                consentInformation = value;
                OnPropertyChanged("ConsentInformation");
            }
        }
    }
} 