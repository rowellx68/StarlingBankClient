using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class DirectDebitMandateV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? uid;
        private string reference;
        private Status1Enum? status;
        private SourceEnum? source;
        private DateTime? created;
        private DateTime? cancelled;
        private DateTime? nextDate;
        private DateTime? lastDate;
        private string originatorName;
        private Guid? originatorUid;
        private Guid? merchantUid;
        private LastPayment lastPayment;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("uid")]
        public Guid? Uid 
        { 
            get => uid;
            set 
            {
                uid = value;
                OnPropertyChanged("Uid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Status1Enum? Status 
        { 
            get => status;
            set 
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("source", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SourceEnum? Source 
        { 
            get => source;
            set 
            {
                source = value;
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime? Created 
        { 
            get => created;
            set 
            {
                created = value;
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cancelled")]
        public DateTime? Cancelled 
        { 
            get => cancelled;
            set 
            {
                cancelled = value;
                OnPropertyChanged("Cancelled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("lastDate")]
        public DateTime? LastDate 
        { 
            get => lastDate;
            set 
            {
                lastDate = value;
                OnPropertyChanged("LastDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("originatorName")]
        public string OriginatorName 
        { 
            get => originatorName;
            set 
            {
                originatorName = value;
                OnPropertyChanged("OriginatorName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("originatorUid")]
        public Guid? OriginatorUid 
        { 
            get => originatorUid;
            set 
            {
                originatorUid = value;
                OnPropertyChanged("OriginatorUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("merchantUid")]
        public Guid? MerchantUid 
        { 
            get => merchantUid;
            set 
            {
                merchantUid = value;
                OnPropertyChanged("MerchantUid");
            }
        }

        /// <summary>
        /// Last direct debit payment
        /// </summary>
        [JsonProperty("lastPayment")]
        public LastPayment LastPayment 
        { 
            get => lastPayment;
            set 
            {
                lastPayment = value;
                OnPropertyChanged("LastPayment");
            }
        }
    }
} 