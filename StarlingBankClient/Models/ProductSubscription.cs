using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class ProductSubscription : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? productSubscriptionUid;
        private ProductSubscriptionStatusEnum? productSubscriptionStatus;
        private Guid? accountHolderUid;
        private Product product;
        private Guid? planUid;
        private BillingSummary billingSummary;
        private DateTime? createdAt;
        private DateTime? updatedAt;

        /// <summary>
        /// Unique identifier for product subscription
        /// </summary>
        [JsonProperty("productSubscriptionUid")]
        public Guid? ProductSubscriptionUid 
        { 
            get => productSubscriptionUid;
            set 
            {
                productSubscriptionUid = value;
                OnPropertyChanged("ProductSubscriptionUid");
            }
        }

        /// <summary>
        /// Product subscription status
        /// </summary>
        [JsonProperty("productSubscriptionStatus", ItemConverterType = typeof(StringValuedEnumConverter))]
        public ProductSubscriptionStatusEnum? ProductSubscriptionStatus 
        { 
            get => productSubscriptionStatus;
            set 
            {
                productSubscriptionStatus = value;
                OnPropertyChanged("ProductSubscriptionStatus");
            }
        }

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
        /// Product
        /// </summary>
        [JsonProperty("product")]
        public Product Product 
        { 
            get => product;
            set 
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }

        /// <summary>
        /// Unique identifier for a plan
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
        /// Billing summary
        /// </summary>
        [JsonProperty("billingSummary")]
        public BillingSummary BillingSummary 
        { 
            get => billingSummary;
            set 
            {
                billingSummary = value;
                OnPropertyChanged("BillingSummary");
            }
        }

        /// <summary>
        /// Date when subscription was created
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
        /// Date when subscription was updated
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