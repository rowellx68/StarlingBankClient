using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class NextPaymentDatesResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<DateTime> nextPaymentDates;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(ListDateTimeConverter),typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("nextPaymentDates")]
        public List<DateTime> NextPaymentDates 
        { 
            get => nextPaymentDates;
            set 
            {
                nextPaymentDates = value;
                OnPropertyChanged("NextPaymentDates");
            }
        }
    }
} 