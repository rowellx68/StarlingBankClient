using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ContentModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? amount;
        private string counterParty;
        private Guid? merchantUid;
        private Guid? merchantLocationUid;
        private string sourceCurrency;
        private Guid? transactionUid;
        private string forCustomer;
        private TypeEnum? type;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount 
        { 
            get => amount;
            set 
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counterParty")]
        public string CounterParty 
        { 
            get => counterParty;
            set 
            {
                counterParty = value;
                OnPropertyChanged("CounterParty");
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("merchantLocationUid")]
        public Guid? MerchantLocationUid 
        { 
            get => merchantLocationUid;
            set 
            {
                merchantLocationUid = value;
                OnPropertyChanged("MerchantLocationUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sourceCurrency")]
        public string SourceCurrency 
        { 
            get => sourceCurrency;
            set 
            {
                sourceCurrency = value;
                OnPropertyChanged("SourceCurrency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transactionUid")]
        public Guid? TransactionUid 
        { 
            get => transactionUid;
            set 
            {
                transactionUid = value;
                OnPropertyChanged("TransactionUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("forCustomer")]
        public string ForCustomer 
        { 
            get => forCustomer;
            set 
            {
                forCustomer = value;
                OnPropertyChanged("ForCustomer");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public TypeEnum? Type 
        { 
            get => type;
            set 
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
    }
} 