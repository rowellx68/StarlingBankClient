using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class AccountHolderName : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountHolderName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountHolderName")]
        public string AccountHolderNameProp 
        { 
            get => accountHolderName;
            set 
            {
                accountHolderName = value;
                OnPropertyChanged("AccountHolderNameProp");
            }
        }
    }
} 