using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class DirectDebitMandatesV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<DirectDebitMandateV2> mandates;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mandates")]
        public List<DirectDebitMandateV2> Mandates 
        { 
            get => mandates;
            set 
            {
                mandates = value;
                OnPropertyChanged("Mandates");
            }
        }
    }
} 