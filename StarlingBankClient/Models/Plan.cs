using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class Plan : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? planUid;
        private string planName;
        private Guid? productUid;
        private ProductTypeEnum? productType;
        private bool? active;
        private BillingPeriodEnum? billingPeriod;
        private BillingCancellationPolicyEnum? billingCancellationPolicy;
        private Money price;
        private DateTime? createdAt;
        private DateTime? updatedAt;

        /// <summary>
        /// Unique identifier for the plan
        /// </summary>
        [JsonProperty("planUid")]
        public Guid? PlanUid 
        { 
            get => planUid;
            set 
            {
                planUid = value;
                OnPropertyChanged("PlanUid");
            }
        }

        /// <summary>
        /// Plan name
        /// </summary>
        [JsonProperty("planName")]
        public string PlanName 
        { 
            get => planName;
            set 
            {
                planName = value;
                OnPropertyChanged("PlanName");
            }
        }

        /// <summary>
        /// Unique identifier for the product
        /// </summary>
        [JsonProperty("productUid")]
        public Guid? ProductUid 
        { 
            get => productUid;
            set 
            {
                productUid = value;
                OnPropertyChanged("ProductUid");
            }
        }

        /// <summary>
        /// Product type
        /// </summary>
        [JsonProperty("productType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public ProductTypeEnum? ProductType 
        { 
            get => productType;
            set 
            {
                productType = value;
                OnPropertyChanged("ProductType");
            }
        }

        /// <summary>
        /// Active
        /// </summary>
        [JsonProperty("active")]
        public bool? Active 
        { 
            get => active;
            set 
            {
                active = value;
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// Billing cancellation policy
        /// </summary>
        [JsonProperty("billingPeriod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BillingPeriodEnum? BillingPeriod 
        { 
            get => billingPeriod;
            set 
            {
                billingPeriod = value;
                OnPropertyChanged("BillingPeriod");
            }
        }

        /// <summary>
        /// Billing cancellation policy
        /// </summary>
        [JsonProperty("billingCancellationPolicy", ItemConverterType = typeof(StringValuedEnumConverter))]
        public BillingCancellationPolicyEnum? BillingCancellationPolicy 
        { 
            get => billingCancellationPolicy;
            set 
            {
                billingCancellationPolicy = value;
                OnPropertyChanged("BillingCancellationPolicy");
            }
        }

        /// <summary>
        /// The next billing amount
        /// </summary>
        [JsonProperty("price")]
        public Money Price 
        { 
            get => price;
            set 
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// The date when the plan was created
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
        /// The date when the plan was updated
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