using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class FeedItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? feedItemUid;
        private Guid? categoryUid;
        private CurrencyAndAmount amount;
        private CurrencyAndAmount sourceAmount;
        private Direction3Enum? direction;
        private DateTime? updatedAt;
        private DateTime? transactionTime;
        private DateTime? settlementTime;
        private DateTime? retryAllocationUntilTime;
        private Source1Enum? source;
        private SourceSubTypeEnum? sourceSubType;
        private Status2Enum? status;
        private Guid? transactingApplicationUserUid;
        private CounterPartyType1Enum? counterPartyType;
        private Guid? counterPartyUid;
        private string counterPartyName;
        private Guid? counterPartySubEntityUid;
        private string counterPartySubEntityName;
        private string counterPartySubEntityIdentifier;
        private string counterPartySubEntitySubIdentifier;
        private double? exchangeRate;
        private double? totalFees;
        private CurrencyAndAmount totalFeeAmount;
        private string reference;
        private CountryEnum? country;
        private SpendingCategory2Enum? spendingCategory;
        private string userNote;
        private AssociatedFeedRoundUp roundUp;
        private bool? hasAttachment;

        /// <summary>
        /// Unique identifier for this item
        /// </summary>
        [JsonProperty("feedItemUid")]
        public Guid? FeedItemUid 
        { 
            get => feedItemUid;
            set 
            {
                feedItemUid = value;
                OnPropertyChanged("FeedItemUid");
            }
        }

        /// <summary>
        /// The category on which the transaction happened
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
        /// Representation of money
        /// </summary>
        [JsonProperty("sourceAmount")]
        public CurrencyAndAmount SourceAmount 
        { 
            get => sourceAmount;
            set 
            {
                sourceAmount = value;
                OnPropertyChanged("SourceAmount");
            }
        }

        /// <summary>
        /// Was this an inbound or outbound transaction
        /// </summary>
        [JsonProperty("direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Direction3Enum? Direction 
        { 
            get => direction;
            set 
            {
                direction = value;
                OnPropertyChanged("Direction");
            }
        }

        /// <summary>
        /// The time the transaction was last updated at
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt 
        { 
            get => updatedAt;
            set 
            {
                updatedAt = value;
                OnPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// The time of the transaction
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transactionTime")]
        public DateTime? TransactionTime 
        { 
            get => transactionTime;
            set 
            {
                transactionTime = value;
                OnPropertyChanged("TransactionTime");
            }
        }

        /// <summary>
        /// The time the transaction settled
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("settlementTime")]
        public DateTime? SettlementTime 
        { 
            get => settlementTime;
            set 
            {
                settlementTime = value;
                OnPropertyChanged("SettlementTime");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("retryAllocationUntilTime")]
        public DateTime? RetryAllocationUntilTime 
        { 
            get => retryAllocationUntilTime;
            set 
            {
                retryAllocationUntilTime = value;
                OnPropertyChanged("RetryAllocationUntilTime");
            }
        }

        /// <summary>
        /// The source of the transaction
        /// </summary>
        [JsonProperty("source", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Source1Enum? Source 
        { 
            get => source;
            set 
            {
                source = value;
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// The source subtype of the transaction
        /// </summary>
        [JsonProperty("sourceSubType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SourceSubTypeEnum? SourceSubType 
        { 
            get => sourceSubType;
            set 
            {
                sourceSubType = value;
                OnPropertyChanged("SourceSubType");
            }
        }

        /// <summary>
        /// The status of the transaction
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status2Enum? Status 
        { 
            get => status;
            set 
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The application user that made the transaction
        /// </summary>
        [JsonProperty("transactingApplicationUserUid")]
        public Guid? TransactingApplicationUserUid 
        { 
            get => transactingApplicationUserUid;
            set 
            {
                transactingApplicationUserUid = value;
                OnPropertyChanged("TransactingApplicationUserUid");
            }
        }

        /// <summary>
        /// The type of counter party for this transaction
        /// </summary>
        [JsonProperty("counterPartyType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CounterPartyType1Enum? CounterPartyType 
        { 
            get => counterPartyType;
            set 
            {
                counterPartyType = value;
                OnPropertyChanged("CounterPartyType");
            }
        }

        /// <summary>
        /// The unique identifier for the counter party. eg for MERCHANT this will be the merchant uid, for PAYEE this will be the payee uid
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
        /// The name of the counter party
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
        /// An identifier for the counter party sub entity. eg for MERCHANT this will be the merchant location uid, for PAYEE this will be the payee account uid
        /// </summary>
        [JsonProperty("counterPartySubEntityUid")]
        public Guid? CounterPartySubEntityUid 
        { 
            get => counterPartySubEntityUid;
            set 
            {
                counterPartySubEntityUid = value;
                OnPropertyChanged("CounterPartySubEntityUid");
            }
        }

        /// <summary>
        /// A name for the counter party sub entity, for PAYEE this will be the name set for the payee account
        /// </summary>
        [JsonProperty("counterPartySubEntityName")]
        public string CounterPartySubEntityName 
        { 
            get => counterPartySubEntityName;
            set 
            {
                counterPartySubEntityName = value;
                OnPropertyChanged("CounterPartySubEntityName");
            }
        }

        /// <summary>
        /// An external identifier for the sub entity, for PAYEE this will be the sort code of the account
        /// </summary>
        [JsonProperty("counterPartySubEntityIdentifier")]
        public string CounterPartySubEntityIdentifier 
        { 
            get => counterPartySubEntityIdentifier;
            set 
            {
                counterPartySubEntityIdentifier = value;
                OnPropertyChanged("CounterPartySubEntityIdentifier");
            }
        }

        /// <summary>
        /// An external sub identifier for the sub entity, for PAYEE this will be the account number of the account
        /// </summary>
        [JsonProperty("counterPartySubEntitySubIdentifier")]
        public string CounterPartySubEntitySubIdentifier 
        { 
            get => counterPartySubEntitySubIdentifier;
            set 
            {
                counterPartySubEntitySubIdentifier = value;
                OnPropertyChanged("CounterPartySubEntitySubIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exchangeRate")]
        public double? ExchangeRate 
        { 
            get => exchangeRate;
            set 
            {
                exchangeRate = value;
                OnPropertyChanged("ExchangeRate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("totalFees")]
        public double? TotalFees 
        { 
            get => totalFees;
            set 
            {
                totalFees = value;
                OnPropertyChanged("TotalFees");
            }
        }

        /// <summary>
        /// Representation of money
        /// </summary>
        [JsonProperty("totalFeeAmount")]
        public CurrencyAndAmount TotalFeeAmount 
        { 
            get => totalFeeAmount;
            set 
            {
                totalFeeAmount = value;
                OnPropertyChanged("TotalFeeAmount");
            }
        }

        /// <summary>
        /// The reference for the transaction
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
        /// The country in which the transaction took place. ISO 3166-1 alpha-2
        /// </summary>
        [JsonProperty("country", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CountryEnum? Country 
        { 
            get => country;
            set 
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        /// <summary>
        /// The category of the transaction
        /// </summary>
        [JsonProperty("spendingCategory", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SpendingCategory2Enum? SpendingCategory 
        { 
            get => spendingCategory;
            set 
            {
                spendingCategory = value;
                OnPropertyChanged("SpendingCategory");
            }
        }

        /// <summary>
        /// The user-provided transaction note
        /// </summary>
        [JsonProperty("userNote")]
        public string UserNote 
        { 
            get => userNote;
            set 
            {
                userNote = value;
                OnPropertyChanged("UserNote");
            }
        }

        /// <summary>
        /// Round up details associated with a feed item
        /// </summary>
        [JsonProperty("roundUp")]
        public AssociatedFeedRoundUp RoundUp 
        { 
            get => roundUp;
            set 
            {
                roundUp = value;
                OnPropertyChanged("RoundUp");
            }
        }

        /// <summary>
        /// Attachment present
        /// </summary>
        [JsonProperty("hasAttachment")]
        public bool? HasAttachment 
        { 
            get => hasAttachment;
            set 
            {
                hasAttachment = value;
                OnPropertyChanged("HasAttachment");
            }
        }
    }
} 