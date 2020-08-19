using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class StandingOrdersResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<StandingOrder> standingOrders;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("standingOrders")]
        public List<StandingOrder> StandingOrders 
        { 
            get => standingOrders;
            set 
            {
                standingOrders = value;
                OnPropertyChanged("StandingOrders");
            }
        }
    }
} 