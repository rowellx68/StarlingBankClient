using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Cards : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Card> cards;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cards")]
        public List<Card> CardsProp 
        { 
            get => cards;
            set 
            {
                cards = value;
                OnPropertyChanged("CardsProp");
            }
        }
    }
} 