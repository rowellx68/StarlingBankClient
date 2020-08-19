using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class FeedItemAttachment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? feedItemUid;
        private Guid? feedItemAttachmentUid;
        private AttachmentTypeEnum? attachmentType;
        private FeedItemAttachmentTypeEnum? feedItemAttachmentType;
        private string userComment;

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
        [JsonProperty("feedItemAttachmentUid")]
        public Guid? FeedItemAttachmentUid 
        { 
            get => feedItemAttachmentUid;
            set 
            {
                feedItemAttachmentUid = value;
                OnPropertyChanged("FeedItemAttachmentUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attachmentType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public AttachmentTypeEnum? AttachmentType 
        { 
            get => attachmentType;
            set 
            {
                attachmentType = value;
                OnPropertyChanged("AttachmentType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItemAttachmentType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public FeedItemAttachmentTypeEnum? FeedItemAttachmentType 
        { 
            get => feedItemAttachmentType;
            set 
            {
                feedItemAttachmentType = value;
                OnPropertyChanged("FeedItemAttachmentType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("userComment")]
        public string UserComment 
        { 
            get => userComment;
            set 
            {
                userComment = value;
                OnPropertyChanged("UserComment");
            }
        }
    }
} 