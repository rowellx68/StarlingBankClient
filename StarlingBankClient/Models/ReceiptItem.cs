using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class ReceiptItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? receiptItemUid;
        private string description;
        private int? quantity;
        private double amount;
        private double tax;
        private string url;
        private DateTime? creationTime;
        private Type1Enum? type;
        private List<string> notes;
        private List<ReceiptSubItem> subItems;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptItemUid")]
        public Guid? ReceiptItemUid 
        { 
            get => receiptItemUid;
            set 
            {
                receiptItemUid = value;
                OnPropertyChanged("ReceiptItemUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get => description;
            set 
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity 
        { 
            get => quantity;
            set 
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double Amount 
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
        [JsonProperty("tax")]
        public double Tax 
        { 
            get => tax;
            set 
            {
                tax = value;
                OnPropertyChanged("Tax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get => url;
            set 
            {
                url = value;
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// The time the receipt item was created
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

        /// <summary>
        /// Type of receipt item. It can be PURCHASE, SERVICE_FEE, GRATUITY or null
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Type1Enum? Type 
        { 
            get => type;
            set 
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notes")]
        public List<string> Notes 
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
        [JsonProperty("subItems")]
        public List<ReceiptSubItem> SubItems 
        { 
            get => subItems;
            set 
            {
                subItems = value;
                OnPropertyChanged("SubItems");
            }
        }
    }
} 