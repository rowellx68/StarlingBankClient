using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ReceiptMerchant : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? receiptMerchantUid;
        private string identifier;
        private string address;
        private string emailAddress;
        private string logoUrl;
        private string orderCollectionNumber;
        private string taxNumber;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptMerchantUid")]
        public Guid? ReceiptMerchantUid 
        { 
            get => receiptMerchantUid;
            set 
            {
                receiptMerchantUid = value;
                OnPropertyChanged("ReceiptMerchantUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier 
        { 
            get => identifier;
            set 
            {
                identifier = value;
                OnPropertyChanged("Identifier");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("address")]
        public string Address 
        { 
            get => address;
            set 
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress 
        { 
            get => emailAddress;
            set 
            {
                emailAddress = value;
                OnPropertyChanged("EmailAddress");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("logoUrl")]
        public string LogoUrl 
        { 
            get => logoUrl;
            set 
            {
                logoUrl = value;
                OnPropertyChanged("LogoUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("orderCollectionNumber")]
        public string OrderCollectionNumber 
        { 
            get => orderCollectionNumber;
            set 
            {
                orderCollectionNumber = value;
                OnPropertyChanged("OrderCollectionNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxNumber")]
        public string TaxNumber 
        { 
            get => taxNumber;
            set 
            {
                taxNumber = value;
                OnPropertyChanged("TaxNumber");
            }
        }
    }
} 