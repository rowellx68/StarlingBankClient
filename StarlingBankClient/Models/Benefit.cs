using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class Benefit : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? benefitUid;
        private string benefitName;
        private BenefitTypeEnum? benefitType;
        private DateTime? createdAt;
        private DateTime? updatedAt;

        /// <summary>
        /// Unique identifier for the benefit
        /// </summary>
        [JsonProperty("benefitUid")]
        public Guid? BenefitUid 
        { 
            get => benefitUid;
            set 
            {
                benefitUid = value;
                OnPropertyChanged("BenefitUid");
            }
        }

        /// <summary>
        /// Benefit name
        /// </summary>
        [JsonProperty("benefitName")]
        public string BenefitName 
        { 
            get => benefitName;
            set 
            {
                benefitName = value;
                OnPropertyChanged("BenefitName");
            }
        }

        /// <summary>
        /// Benefit type
        /// </summary>
        [JsonProperty("benefitType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BenefitTypeEnum? BenefitType 
        { 
            get => benefitType;
            set 
            {
                benefitType = value;
                OnPropertyChanged("BenefitType");
            }
        }

        /// <summary>
        /// The date when the benefit was created
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

        /// <summary>
        /// The date when the benefit was updated
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
    }
} 