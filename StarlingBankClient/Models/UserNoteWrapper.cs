using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class UserNoteWrapper : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string userNote;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("userNote")]
        public string UserNote 
        { 
            get => userNote;
            set 
            {
                userNote = value;
                OnPropertyChanged("UserNote");
            }
        }
    }
} 