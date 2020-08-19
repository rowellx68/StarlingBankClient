using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class DefaultWebhookPayloadModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime? timestamp;
        private Guid? accountHolderUid;
        private WebhookTypeEnum? webhookType;
        private Guid? webhookNotificationUid;
        private ContentModel content;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp")]
        public DateTime? Timestamp 
        { 
            get => timestamp;
            set 
            {
                timestamp = value;
                OnPropertyChanged("Timestamp");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("webhookType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public WebhookTypeEnum? WebhookType 
        { 
            get => webhookType;
            set 
            {
                webhookType = value;
                OnPropertyChanged("WebhookType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("webhookNotificationUid")]
        public Guid? WebhookNotificationUid 
        { 
            get => webhookNotificationUid;
            set 
            {
                webhookNotificationUid = value;
                OnPropertyChanged("WebhookNotificationUid");
            }
        }

        /// <summary>
        /// The content of the webhook (This example is for a mastercard transaction)
        /// </summary>
        [JsonProperty("content")]
        public ContentModel Content 
        { 
            get => content;
            set 
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }
    }
} 