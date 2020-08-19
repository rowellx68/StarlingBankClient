using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class Accounts : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<AccountV2> accounts;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accounts")]
        public List<AccountV2> AccountsProp 
        { 
            get => accounts;
            set 
            {
                accounts = value;
                OnPropertyChanged("AccountsProp");
            }
        }
    }
} 