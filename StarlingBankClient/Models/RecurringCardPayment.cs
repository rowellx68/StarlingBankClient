using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class RecurringCardPayment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? recurringPaymentUid;
        private Guid? accountUid;
        private Guid? counterPartyUid;
        private string counterPartyName;
        private StatusEnum? status;
        private Guid? latestFeedItemUid;
        private DateTime? latestPaymentDate;
        private CurrencyAndAmount latestPaymentAmount;
        private Guid? mostRecentFeedItem;
        private DateTime? mostRecentPaymentDate;
        private Money mostRecentPaymentAmount;

        /// <summary>
        /// Unique identifier for the recurring card payment
        /// </summary>
        [JsonProperty("recurringPaymentUid")]
        public Guid? RecurringPaymentUid 
        { 
            get => recurringPaymentUid;
            set 
            {
                recurringPaymentUid = value;
                OnPropertyChanged("RecurringPaymentUid");
            }
        }

        /// <summary>
        /// Unique identifier for the account
        /// </summary>
        [JsonProperty("accountUid")]
        public Guid? AccountUid 
        { 
            get => accountUid;
            set 
            {
                accountUid = value;
                OnPropertyChanged("AccountUid");
            }
        }

        /// <summary>
        /// Unique identifier for the counterparty
        /// </summary>
        [JsonProperty("counterPartyUid")]
        public Guid? CounterPartyUid 
        { 
            get => counterPartyUid;
            set 
            {
                counterPartyUid = value;
                OnPropertyChanged("CounterPartyUid");
            }
        }

        /// <summary>
        /// Counterparty name
        /// </summary>
        [JsonProperty("counterPartyName")]
        public string CounterPartyName 
        { 
            get => counterPartyName;
            set 
            {
                counterPartyName = value;
                OnPropertyChanged("CounterPartyName");
            }
        }

        /// <summary>
        /// Recurring payment status
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public StatusEnum? Status 
        { 
            get => status;
            set 
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Unique identifier for the latest feed item
        /// </summary>
        [JsonProperty("latestFeedItemUid")]
        public Guid? LatestFeedItemUid 
        { 
            get => latestFeedItemUid;
            set 
            {
                latestFeedItemUid = value;
                OnPropertyChanged("LatestFeedItemUid");
            }
        }

        /// <summary>
        /// Latest payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("latestPaymentDate")]
        public DateTime? LatestPaymentDate 
        { 
            get => latestPaymentDate;
            set 
            {
                latestPaymentDate = value;
                OnPropertyChanged("LatestPaymentDate");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("latestPaymentAmount")]
        public CurrencyAndAmount LatestPaymentAmount 
        { 
            get => latestPaymentAmount;
            set 
            {
                latestPaymentAmount = value;
                OnPropertyChanged("LatestPaymentAmount");
            }
        }

        /// <summary>
        /// Unique identifier for the feed item
        /// </summary>
        [JsonProperty("mostRecentFeedItem")]
        public Guid? MostRecentFeedItem 
        { 
            get => mostRecentFeedItem;
            set 
            {
                mostRecentFeedItem = value;
                OnPropertyChanged("MostRecentFeedItem");
            }
        }

        /// <summary>
        /// Most recent payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("mostRecentPaymentDate")]
        public DateTime? MostRecentPaymentDate 
        { 
            get => mostRecentPaymentDate;
            set 
            {
                mostRecentPaymentDate = value;
                OnPropertyChanged("MostRecentPaymentDate");
            }
        }

        /// <summary>
        /// The next billing amount
        /// </summary>
        [JsonProperty("mostRecentPaymentAmount")]
        public Money MostRecentPaymentAmount 
        { 
            get => mostRecentPaymentAmount;
            set 
            {
                mostRecentPaymentAmount = value;
                OnPropertyChanged("MostRecentPaymentAmount");
            }
        }
    }
} 