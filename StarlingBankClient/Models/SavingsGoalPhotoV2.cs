using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class SavingsGoalPhotoV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string base64EncodedPhoto;

        /// <summary>
        /// A text (base 64) encoded picture to associate with the savings goal
        /// </summary>
        [JsonProperty("base64EncodedPhoto")]
        public string Base64EncodedPhoto 
        { 
            get => base64EncodedPhoto;
            set 
            {
                base64EncodedPhoto = value;
                OnPropertyChanged("Base64EncodedPhoto");
            }
        }
    }
} 