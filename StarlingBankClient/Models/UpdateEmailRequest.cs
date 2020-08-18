using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class UpdateEmailRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string email;

        /// <summary>
        /// The new email address for the account holder
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get => email;
            set 
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
    }
} 