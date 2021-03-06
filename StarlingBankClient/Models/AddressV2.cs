using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class AddressV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string line1;
        private string line2;
        private string line3;
        private string postTown;
        private string postCode;
        private string countryCode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("line1")]
        public string Line1 
        { 
            get => line1;
            set 
            {
                line1 = value;
                OnPropertyChanged("Line1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("line2")]
        public string Line2 
        { 
            get => line2;
            set 
            {
                line2 = value;
                OnPropertyChanged("Line2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("line3")]
        public string Line3 
        { 
            get => line3;
            set 
            {
                line3 = value;
                OnPropertyChanged("Line3");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("postTown")]
        public string PostTown 
        { 
            get => postTown;
            set 
            {
                postTown = value;
                OnPropertyChanged("PostTown");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("postCode")]
        public string PostCode 
        { 
            get => postCode;
            set 
            {
                postCode = value;
                OnPropertyChanged("PostCode");
            }
        }

        /// <summary>
        /// Country code in ISO 3166-1 alpha-2. NB GB is the official country code for the UK. UK is not the officially assigned code, and so is not valid
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode 
        { 
            get => countryCode;
            set 
            {
                countryCode = value;
                OnPropertyChanged("CountryCode");
            }
        }
    }
} 