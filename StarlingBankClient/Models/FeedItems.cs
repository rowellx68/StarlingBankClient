using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class FeedItems : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<FeedItem> feedItems;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feedItems")]
        public List<FeedItem> FeedItemsProp 
        { 
            get => feedItems;
            set 
            {
                feedItems = value;
                OnPropertyChanged("FeedItemsProp");
            }
        }
    }
} 