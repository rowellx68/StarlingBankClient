using System;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class OnboardingAddress : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string line1;
        private string line2;
        private string line3;
        private string subBuildingName;
        private string buildingName;
        private string buildingNumber;
        private string thoroughfare;
        private string dependantLocality;
        private string postTown;
        private string postCode;
        private string countryCode;
        private string udprn;
        private string umprn;
        private DateTime mfrom;
        private DateTime? to;

        /// <summary>
        /// First line
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
        /// Second line
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
        /// Third line
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
        /// PAF field of same name
        /// </summary>
        [JsonProperty("subBuildingName")]
        public string SubBuildingName 
        { 
            get => subBuildingName;
            set 
            {
                subBuildingName = value;
                OnPropertyChanged("SubBuildingName");
            }
        }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("buildingName")]
        public string BuildingName 
        { 
            get => buildingName;
            set 
            {
                buildingName = value;
                OnPropertyChanged("BuildingName");
            }
        }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("buildingNumber")]
        public string BuildingNumber 
        { 
            get => buildingNumber;
            set 
            {
                buildingNumber = value;
                OnPropertyChanged("BuildingNumber");
            }
        }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("thoroughfare")]
        public string Thoroughfare 
        { 
            get => thoroughfare;
            set 
            {
                thoroughfare = value;
                OnPropertyChanged("Thoroughfare");
            }
        }

        /// <summary>
        /// PAF field of same name
        /// </summary>
        [JsonProperty("dependantLocality")]
        public string DependantLocality 
        { 
            get => dependantLocality;
            set 
            {
                dependantLocality = value;
                OnPropertyChanged("DependantLocality");
            }
        }

        /// <summary>
        /// Post town
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
        /// Post code
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

        /// <summary>
        /// The udprn of the property.
        /// </summary>
        [JsonProperty("udprn")]
        public string Udprn 
        { 
            get => udprn;
            set 
            {
                udprn = value;
                OnPropertyChanged("Udprn");
            }
        }

        /// <summary>
        /// The umprn of the property
        /// </summary>
        [JsonProperty("umprn")]
        public string Umprn 
        { 
            get => umprn;
            set 
            {
                umprn = value;
                OnPropertyChanged("Umprn");
            }
        }

        /// <summary>
        /// Date the account holder's residency at this address started
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("from")]
        public DateTime From 
        { 
            get => mfrom;
            set 
            {
                mfrom = value;
                OnPropertyChanged("From");
            }
        }

        /// <summary>
        /// Date the account holder's residency at this address completed
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("to")]
        public DateTime? To 
        { 
            get => to;
            set 
            {
                to = value;
                OnPropertyChanged("To");
            }
        }
    }
} 