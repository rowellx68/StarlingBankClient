using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Receipt : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? receiptUid;
        private Guid? feedItemUid;
        private MetadataSourceEnum metadataSource;
        private string receiptIdentifier;
        private double totalAmount;
        private ReceiptMerchant receiptMerchant;
        private CurrencyCodeEnum? currencyCode;
        private List<ReceiptItem> items;
        private List<ReceiptNote> notes;
        private List<ReceiptTaxDetail> taxDetails;
        private List<ReceiptPaymentMethod> paymentMethods;
        private string providerName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptUid")]
        public Guid? ReceiptUid 
        { 
            get => receiptUid;
            set 
            {
                receiptUid = value;
                OnPropertyChanged("ReceiptUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metadataSource", ItemConverterType = typeof(StringValuedEnumConverter))]
        public MetadataSourceEnum MetadataSource 
        { 
            get => metadataSource;
            set 
            {
                metadataSource = value;
                OnPropertyChanged("MetadataSource");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptIdentifier")]
        public string ReceiptIdentifier 
        { 
            get => receiptIdentifier;
            set 
            {
                receiptIdentifier = value;
                OnPropertyChanged("ReceiptIdentifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("totalAmount")]
        public double TotalAmount 
        { 
            get => totalAmount;
            set 
            {
                totalAmount = value;
                OnPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// Receipt Merchant Information
        /// </summary>
        [JsonProperty("receiptMerchant")]
        public ReceiptMerchant ReceiptMerchant 
        { 
            get => receiptMerchant;
            set 
            {
                receiptMerchant = value;
                OnPropertyChanged("ReceiptMerchant");
            }
        }

        /// <summary>
        /// ISO-4217 3 character currency code
        /// </summary>
        [JsonProperty("currencyCode", ItemConverterType = typeof(StringValuedEnumConverter))]
        public CurrencyCodeEnum? CurrencyCode 
        { 
            get => currencyCode;
            set 
            {
                currencyCode = value;
                OnPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("items")]
        public List<ReceiptItem> Items 
        { 
            get => items;
            set 
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notes")]
        public List<ReceiptNote> Notes 
        { 
            get => notes;
            set 
            {
                notes = value;
                OnPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxDetails")]
        public List<ReceiptTaxDetail> TaxDetails 
        { 
            get => taxDetails;
            set 
            {
                taxDetails = value;
                OnPropertyChanged("TaxDetails");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentMethods")]
        public List<ReceiptPaymentMethod> PaymentMethods 
        { 
            get => paymentMethods;
            set 
            {
                paymentMethods = value;
                OnPropertyChanged("PaymentMethods");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("providerName")]
        public string ProviderName 
        { 
            get => providerName;
            set 
            {
                providerName = value;
                OnPropertyChanged("ProviderName");
            }
        }
    }
} 