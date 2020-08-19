using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class ReceiptTaxDetail : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? receiptTaxDetailUid;
        private string taxName;
        private double taxValue;
        private TaxCurrencyCodeEnum taxCurrencyCode;
        private DateTime? creationTime;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptTaxDetailUid")]
        public Guid? ReceiptTaxDetailUid 
        { 
            get => receiptTaxDetailUid;
            set 
            {
                receiptTaxDetailUid = value;
                OnPropertyChanged("ReceiptTaxDetailUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxName")]
        public string TaxName 
        { 
            get => taxName;
            set 
            {
                taxName = value;
                OnPropertyChanged("TaxName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxValue")]
        public double TaxValue 
        { 
            get => taxValue;
            set 
            {
                taxValue = value;
                OnPropertyChanged("TaxValue");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxCurrencyCode", ItemConverterType = typeof(StringValuedEnumConverter))]
        public TaxCurrencyCodeEnum TaxCurrencyCode 
        { 
            get => taxCurrencyCode;
            set 
            {
                taxCurrencyCode = value;
                OnPropertyChanged("TaxCurrencyCode");
            }
        }

        /// <summary>
        /// The time the tax detail was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("creationTime")]
        public DateTime? CreationTime 
        { 
            get => creationTime;
            set 
            {
                creationTime = value;
                OnPropertyChanged("CreationTime");
            }
        }
    }
} 