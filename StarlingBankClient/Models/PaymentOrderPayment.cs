using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class PaymentOrderPayment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid paymentUid;
        private CurrencyAndAmount amount;
        private string reference;
        private Guid payeeUid;
        private Guid payeeAccountUid;
        private DateTime createdAt;
        private DateTime? completedAt;
        private DateTime? rejectedAt;
        private PaymentStatusDetails paymentStatusDetails;

        /// <summary>
        /// UID of this payment
        /// </summary>
        [JsonProperty("paymentUid")]
        public Guid PaymentUid 
        { 
            get => paymentUid;
            set 
            {
                paymentUid = value;
                OnPropertyChanged("PaymentUid");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("amount")]
        public CurrencyAndAmount Amount 
        { 
            get => amount;
            set 
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Reference of this payment
        /// </summary>
        [JsonProperty("reference")]
        public string Reference 
        { 
            get => reference;
            set 
            {
                reference = value;
                OnPropertyChanged("Reference");
            }
        }

        /// <summary>
        /// The ID of the payee receiving this payment
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid PayeeUid 
        { 
            get => payeeUid;
            set 
            {
                payeeUid = value;
                OnPropertyChanged("PayeeUid");
            }
        }

        /// <summary>
        /// The account ID of the payee account receiving this payment
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid PayeeAccountUid 
        { 
            get => payeeAccountUid;
            set 
            {
                payeeAccountUid = value;
                OnPropertyChanged("PayeeAccountUid");
            }
        }

        /// <summary>
        /// When this payment was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt 
        { 
            get => createdAt;
            set 
            {
                createdAt = value;
                OnPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// When this payment was completed, if it completed
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt 
        { 
            get => completedAt;
            set 
            {
                completedAt = value;
                OnPropertyChanged("CompletedAt");
            }
        }

        /// <summary>
        /// When this payment was rejected, if it was rejected
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("rejectedAt")]
        public DateTime? RejectedAt 
        { 
            get => rejectedAt;
            set 
            {
                rejectedAt = value;
                OnPropertyChanged("RejectedAt");
            }
        }

        /// <summary>
        /// Status details of a payment
        /// </summary>
        [JsonProperty("paymentStatusDetails")]
        public PaymentStatusDetails PaymentStatusDetails 
        { 
            get => paymentStatusDetails;
            set 
            {
                paymentStatusDetails = value;
                OnPropertyChanged("PaymentStatusDetails");
            }
        }
    }
} 