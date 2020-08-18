using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ReceiptNote : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? noteUid;
        private string title;
        private string description;
        private string url;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("noteUid")]
        public Guid? NoteUid 
        { 
            get => noteUid;
            set 
            {
                noteUid = value;
                OnPropertyChanged("NoteUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get => title;
            set 
            {
                title = value;
                OnPropertyChanged("Title");
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
    }
} 