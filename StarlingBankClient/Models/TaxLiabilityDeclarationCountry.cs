using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class TaxLiabilityDeclarationCountry : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string countryCode;
        private string taxIdentificationNumber;

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
        /// Tax identification number
        /// </summary>
        [JsonProperty("taxIdentificationNumber")]
        public string TaxIdentificationNumber 
        { 
            get => taxIdentificationNumber;
            set 
            {
                taxIdentificationNumber = value;
                OnPropertyChanged("TaxIdentificationNumber");
            }
        }
    }
} 