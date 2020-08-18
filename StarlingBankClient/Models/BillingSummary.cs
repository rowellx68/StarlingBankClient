using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class BillingSummary : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime? nextBillingDate;
        private DateTime? endOfNextBillingPeriod;
        private DateTime? activeUntil;
        private Money nextBillingAmount;

        /// <summary>
        /// The next billing date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("nextBillingDate")]
        public DateTime? NextBillingDate 
        { 
            get => nextBillingDate;
            set 
            {
                nextBillingDate = value;
                OnPropertyChanged("NextBillingDate");
            }
        }

        /// <summary>
        /// The end of next billing period
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endOfNextBillingPeriod")]
        public DateTime? EndOfNextBillingPeriod 
        { 
            get => endOfNextBillingPeriod;
            set 
            {
                endOfNextBillingPeriod = value;
                OnPropertyChanged("EndOfNextBillingPeriod");
            }
        }

        /// <summary>
        /// The date when the account is active until
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("activeUntil")]
        public DateTime? ActiveUntil 
        { 
            get => activeUntil;
            set 
            {
                activeUntil = value;
                OnPropertyChanged("ActiveUntil");
            }
        }

        /// <summary>
        /// The next billing amount
        /// </summary>
        [JsonProperty("nextBillingAmount")]
        public Money NextBillingAmount 
        { 
            get => nextBillingAmount;
            set 
            {
                nextBillingAmount = value;
                OnPropertyChanged("NextBillingAmount");
            }
        }
    }
} 