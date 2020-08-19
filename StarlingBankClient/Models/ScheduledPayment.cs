using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class ScheduledPayment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountHolderUid;
        private Guid? paymentOrderUid;
        private Guid? categoryUid;
        private CurrencyAndAmount nextPaymentAmount;
        private string reference;
        private Guid? payeeUid;
        private Guid? payeeAccountUid;
        private string recipientName;
        private RecurrenceRule recurrenceRule;
        private DateTime? startDate;
        private DateTime? nextDate;
        private DateTime? endDate;
        private PaymentTypeEnum? paymentType;
        private SpendingCategory8Enum? spendingCategory;

        /// <summary>
        /// Unique identifier for account holder
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid 
        { 
            get => accountHolderUid;
            set 
            {
                accountHolderUid = value;
                OnPropertyChanged("AccountHolderUid");
            }
        }

        /// <summary>
        /// Unique identifier of the scheduled payment order
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
        /// Unique identifier of the category from which the payment will be taken
        /// </summary>
        [JsonProperty("categoryUid")]
        public Guid? CategoryUid 
        { 
            get => categoryUid;
            set 
            {
                categoryUid = value;
                OnPropertyChanged("CategoryUid");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("nextPaymentAmount")]
        public CurrencyAndAmount NextPaymentAmount 
        { 
            get => nextPaymentAmount;
            set 
            {
                nextPaymentAmount = value;
                OnPropertyChanged("NextPaymentAmount");
            }
        }

        /// <summary>
        /// Payment order reference
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
        /// Unique identifier of the payee
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid? PayeeUid 
        { 
            get => payeeUid;
            set 
            {
                payeeUid = value;
                OnPropertyChanged("PayeeUid");
            }
        }

        /// <summary>
        /// Unique identifier of the payee account
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public Guid? PayeeAccountUid 
        { 
            get => payeeAccountUid;
            set 
            {
                payeeAccountUid = value;
                OnPropertyChanged("PayeeAccountUid");
            }
        }

        /// <summary>
        /// Recipient name
        /// </summary>
        [JsonProperty("recipientName")]
        public string RecipientName 
        { 
            get => recipientName;
            set 
            {
                recipientName = value;
                OnPropertyChanged("RecipientName");
            }
        }

        /// <summary>
        /// How often is the payment made
        /// </summary>
        [JsonProperty("recurrenceRule")]
        public RecurrenceRule RecurrenceRule 
        { 
            get => recurrenceRule;
            set 
            {
                recurrenceRule = value;
                OnPropertyChanged("RecurrenceRule");
            }
        }

        /// <summary>
        /// Date when the payment order has been created
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("startDate")]
        public DateTime? StartDate 
        { 
            get => startDate;
            set 
            {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// Date of the next payment order
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextDate")]
        public DateTime? NextDate 
        { 
            get => nextDate;
            set 
            {
                nextDate = value;
                OnPropertyChanged("NextDate");
            }
        }

        /// <summary>
        /// Date when payment order ends
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("endDate")]
        public DateTime? EndDate 
        { 
            get => endDate;
            set 
            {
                endDate = value;
                OnPropertyChanged("EndDate");
            }
        }

        /// <summary>
        /// Payment type
        /// </summary>
        [JsonProperty("paymentType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PaymentTypeEnum? PaymentType 
        { 
            get => paymentType;
            set 
            {
                paymentType = value;
                OnPropertyChanged("PaymentType");
            }
        }

        /// <summary>
        /// Spending category
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory8Enum? SpendingCategory 
        { 
            get => spendingCategory;
            set 
            {
                spendingCategory = value;
                OnPropertyChanged("SpendingCategory");
            }
        }
    }
} 