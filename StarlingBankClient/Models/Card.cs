using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class Card : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid cardUid;
        private string publicToken;
        private bool enabled;
        private bool walletNotificationEnabled;
        private bool posEnabled;
        private bool atmEnabled;
        private bool onlineEnabled;
        private bool mobileWalletEnabled;
        private bool gamblingEnabled;
        private bool magStripeEnabled;
        private bool cancelled;
        private bool activationRequested;
        private bool activated;
        private string endOfCardNumber;
        private List<CurrencyFlag> currencyFlags;
        private Guid cardAssociationUid;
        private DateTime? gamblingToBeEnabledAt;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cardUid")]
        public Guid CardUid 
        { 
            get => cardUid;
            set 
            {
                cardUid = value;
                OnPropertyChanged("CardUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("publicToken")]
        public string PublicToken 
        { 
            get => publicToken;
            set 
            {
                publicToken = value;
                OnPropertyChanged("PublicToken");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled 
        { 
            get => enabled;
            set 
            {
                enabled = value;
                OnPropertyChanged("Enabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("walletNotificationEnabled")]
        public bool WalletNotificationEnabled 
        { 
            get => walletNotificationEnabled;
            set 
            {
                walletNotificationEnabled = value;
                OnPropertyChanged("WalletNotificationEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("posEnabled")]
        public bool PosEnabled 
        { 
            get => posEnabled;
            set 
            {
                posEnabled = value;
                OnPropertyChanged("PosEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("atmEnabled")]
        public bool AtmEnabled 
        { 
            get => atmEnabled;
            set 
            {
                atmEnabled = value;
                OnPropertyChanged("AtmEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("onlineEnabled")]
        public bool OnlineEnabled 
        { 
            get => onlineEnabled;
            set 
            {
                onlineEnabled = value;
                OnPropertyChanged("OnlineEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mobileWalletEnabled")]
        public bool MobileWalletEnabled 
        { 
            get => mobileWalletEnabled;
            set 
            {
                mobileWalletEnabled = value;
                OnPropertyChanged("MobileWalletEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gamblingEnabled")]
        public bool GamblingEnabled 
        { 
            get => gamblingEnabled;
            set 
            {
                gamblingEnabled = value;
                OnPropertyChanged("GamblingEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("magStripeEnabled")]
        public bool MagStripeEnabled 
        { 
            get => magStripeEnabled;
            set 
            {
                magStripeEnabled = value;
                OnPropertyChanged("MagStripeEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cancelled")]
        public bool Cancelled 
        { 
            get => cancelled;
            set 
            {
                cancelled = value;
                OnPropertyChanged("Cancelled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("activationRequested")]
        public bool ActivationRequested 
        { 
            get => activationRequested;
            set 
            {
                activationRequested = value;
                OnPropertyChanged("ActivationRequested");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("activated")]
        public bool Activated 
        { 
            get => activated;
            set 
            {
                activated = value;
                OnPropertyChanged("Activated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("endOfCardNumber")]
        public string EndOfCardNumber 
        { 
            get => endOfCardNumber;
            set 
            {
                endOfCardNumber = value;
                OnPropertyChanged("EndOfCardNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currencyFlags")]
        public List<CurrencyFlag> CurrencyFlags 
        { 
            get => currencyFlags;
            set 
            {
                currencyFlags = value;
                OnPropertyChanged("CurrencyFlags");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cardAssociationUid")]
        public Guid CardAssociationUid 
        { 
            get => cardAssociationUid;
            set 
            {
                cardAssociationUid = value;
                OnPropertyChanged("CardAssociationUid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("gamblingToBeEnabledAt")]
        public DateTime? GamblingToBeEnabledAt 
        { 
            get => gamblingToBeEnabledAt;
            set 
            {
                gamblingToBeEnabledAt = value;
                OnPropertyChanged("GamblingToBeEnabledAt");
            }
        }
    }
} 