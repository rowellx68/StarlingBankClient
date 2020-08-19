using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class ErrorDetail : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string message;

        /// <summary>
        /// The error message
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get => message;
            set 
            {
                message = value;
                OnPropertyChanged("Message");
            }
        }
    }
} 