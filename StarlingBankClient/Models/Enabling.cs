using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Enabling : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool enabled;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled 
        { 
            get => enabled;
            set 
            {
                enabled = value;
                OnPropertyChanged("Enabled");
            }
        }
    }
} 