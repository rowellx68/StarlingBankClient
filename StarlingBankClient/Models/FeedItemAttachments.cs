using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class FeedItemAttachments : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<FeedItemAttachment> feedItemAttachments;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemAttachments")]
        public List<FeedItemAttachment> FeedItemAttachmentsProp 
        { 
            get => feedItemAttachments;
            set 
            {
                feedItemAttachments = value;
                OnPropertyChanged("FeedItemAttachmentsProp");
            }
        }
    }
} 