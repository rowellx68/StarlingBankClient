using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ReceiptCreationResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? receiptUid;

        /// <summary>
        /// The UUID of the created receipt. This UUID could be used for updating the receipt at a later point.
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
    }
} 