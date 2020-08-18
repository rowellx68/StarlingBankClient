using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class AccountStatementPeriods : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<AccountStatementPeriod> periods;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("periods")]
        public List<AccountStatementPeriod> Periods 
        { 
            get => periods;
            set 
            {
                periods = value;
                OnPropertyChanged("Periods");
            }
        }
    }
} 