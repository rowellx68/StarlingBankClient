using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class AddressesV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private AddressV2 current;
        private List<AddressV2> previous;

        /// <summary>
        /// Physical address of account holder
        /// </summary>
        [JsonProperty("current")]
        public AddressV2 Current 
        { 
            get => current;
            set 
            {
                current = value;
                OnPropertyChanged("Current");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("previous")]
        public List<AddressV2> Previous 
        { 
            get => previous;
            set 
            {
                previous = value;
                OnPropertyChanged("Previous");
            }
        }
    }
} 