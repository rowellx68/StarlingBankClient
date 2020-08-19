using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class IdentityV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? accountHolderUid;
        private DateTime? expiresAt;
        private long? expiresInSeconds;
        private List<string> scopes;
        private bool? authenticated;
        private Guid? applicationUserUid;
        private Guid? customerUid;

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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expiresAt")]
        public DateTime? ExpiresAt 
        { 
            get => expiresAt;
            set 
            {
                expiresAt = value;
                OnPropertyChanged("ExpiresAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("expiresInSeconds")]
        public long? ExpiresInSeconds 
        { 
            get => expiresInSeconds;
            set 
            {
                expiresInSeconds = value;
                OnPropertyChanged("ExpiresInSeconds");
            }
        }

        /// <summary>
        /// The scopes which this token has permission to use e.g. balance:read
        /// </summary>
        [JsonProperty("scopes")]
        public List<string> Scopes 
        { 
            get => scopes;
            set 
            {
                scopes = value;
                OnPropertyChanged("Scopes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("authenticated")]
        public bool? Authenticated 
        { 
            get => authenticated;
            set 
            {
                authenticated = value;
                OnPropertyChanged("Authenticated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("applicationUserUid")]
        public Guid? ApplicationUserUid 
        { 
            get => applicationUserUid;
            set 
            {
                applicationUserUid = value;
                OnPropertyChanged("ApplicationUserUid");
            }
        }

        /// <summary>
        /// Deprecated, use accountHolderUid instead
        /// </summary>
        [JsonProperty("customerUid")]
        public Guid? CustomerUid 
        { 
            get => customerUid;
            set 
            {
                customerUid = value;
                OnPropertyChanged("CustomerUid");
            }
        }
    }
} 