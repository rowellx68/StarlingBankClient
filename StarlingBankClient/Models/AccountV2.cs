using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class AccountV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountUid;
        private Guid? defaultCategory;
        private CurrencyEnum? currency;
        private DateTime? createdAt;

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("defaultCategory")]
        public Guid? DefaultCategory 
        { 
            get => defaultCategory;
            set 
            {
                defaultCategory = value;
                OnPropertyChanged("DefaultCategory");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CurrencyEnum? Currency 
        { 
            get => currency;
            set 
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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