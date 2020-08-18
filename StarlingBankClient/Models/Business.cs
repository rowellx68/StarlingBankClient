using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class Business : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string companyName;
        private string companyType;
        private string companyCategory;
        private string companySubCategory;
        private string companyRegistrationNumber;
        private string email;
        private string phone;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName 
        { 
            get => companyName;
            set 
            {
                companyName = value;
                OnPropertyChanged("CompanyName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyType")]
        public string CompanyType 
        { 
            get => companyType;
            set 
            {
                companyType = value;
                OnPropertyChanged("CompanyType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyCategory")]
        public string CompanyCategory 
        { 
            get => companyCategory;
            set 
            {
                companyCategory = value;
                OnPropertyChanged("CompanyCategory");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companySubCategory")]
        public string CompanySubCategory 
        { 
            get => companySubCategory;
            set 
            {
                companySubCategory = value;
                OnPropertyChanged("CompanySubCategory");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyRegistrationNumber")]
        public string CompanyRegistrationNumber 
        { 
            get => companyRegistrationNumber;
            set 
            {
                companyRegistrationNumber = value;
                OnPropertyChanged("CompanyRegistrationNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get => email;
            set 
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("phone")]
        public string Phone 
        { 
            get => phone;
            set 
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
    }
} 