using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ReceiptSubItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? receiptSubItemUid;
        private string description;
        private int? quantity;
        private double? amount;
        private List<string> notes;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("receiptSubItemUid")]
        public Guid? ReceiptSubItemUid 
        { 
            get => receiptSubItemUid;
            set 
            {
                receiptSubItemUid = value;
                OnPropertyChanged("ReceiptSubItemUid");
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
    }
} 