using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class AccountHolder : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountHolderUid;
        private AccountHolderTypeEnum? accountHolderType;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountHolderUid")]
        public Guid? AccountHolderUid 
        { 
            get => accountHolderUid;
            set 
            {
                accountHolderUid = value;
                OnPropertyChanged("AccountHolderUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("accountHolderType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public AccountHolderTypeEnum? AccountHolderType 
        { 
            get => accountHolderType;
            set 
            {
                accountHolderType = value;
                OnPropertyChanged("AccountHolderType");
            }
        }
    }
} 