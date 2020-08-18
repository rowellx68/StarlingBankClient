using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBankClient.Models
{
    public class Product : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? productUid;
        private string productName;
        private ProductIdentifierEnum? productIdentifier;
        private ProductTypeEnum? productType;
        private List<Benefit> benefits;
        private List<Plan> plans;
        private DateTime? createdAt;
        private DateTime? updatedAt;

        /// <summary>
        /// Unique identifier for product
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
        /// Product name
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName 
        { 
            get => productName;
            set 
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        /// <summary>
        /// Product identifier
        /// </summary>
        [JsonProperty("productIdentifier", ItemConverterType = typeof(StringValuedEnumConverter))]
        public ProductIdentifierEnum? ProductIdentifier 
        { 
            get => productIdentifier;
            set 
            {
                productIdentifier = value;
                OnPropertyChanged("ProductIdentifier");
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
        /// Benefit
        /// </summary>
        [JsonProperty("benefits")]
        public List<Benefit> Benefits 
        { 
            get => benefits;
            set 
            {
                benefits = value;
                OnPropertyChanged("Benefits");
            }
        }

        /// <summary>
        /// Plan
        /// </summary>
        [JsonProperty("plans")]
        public List<Plan> Plans 
        { 
            get => plans;
            set 
            {
                plans = value;
                OnPropertyChanged("Plans");
            }
        }

        /// <summary>
        /// The date when the product was created
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
        /// The date when the product was updated
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