using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class Payees : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Payee> payees;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payees")]
        public List<Payee> PayeesProp 
        { 
            get => payees;
            set 
            {
                payees = value;
                OnPropertyChanged("PayeesProp");
            }
        }
    }
} 