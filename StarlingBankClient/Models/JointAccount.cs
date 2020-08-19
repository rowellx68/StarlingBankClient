using System;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class JointAccount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountHolderUid;
        private Individual personOne;
        private Individual personTwo;

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
        /// Information about an individual account holder
        /// </summary>
        [JsonProperty("personOne")]
        public Individual PersonOne 
        { 
            get => personOne;
            set 
            {
                personOne = value;
                OnPropertyChanged("PersonOne");
            }
        }

        /// <summary>
        /// Information about an individual account holder
        /// </summary>
        [JsonProperty("personTwo")]
        public Individual PersonTwo 
        { 
            get => personTwo;
            set 
            {
                personTwo = value;
                OnPropertyChanged("PersonTwo");
            }
        }
    }
} 