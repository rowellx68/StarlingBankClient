using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class OnboardingResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountHolderUid;
        private AccessToken accessToken;

        /// <summary>
        /// The unique identifier of the account holder which has been created
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
        /// Access token response
        /// </summary>
        [JsonProperty("accessToken")]
        public AccessToken AccessToken 
        { 
            get => accessToken;
            set 
            {
                accessToken = value;
                OnPropertyChanged("AccessToken");
            }
        }
    }
} 