using System;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class Individual : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string title;
        private string firstName;
        private string lastName;
        private DateTime? dateOfBirth;
        private string email;
        private string phone;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        { 
            get => title;
            set 
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get => firstName;
            set 
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName 
        { 
            get => lastName;
            set 
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth")]
        public DateTime? DateOfBirth 
        { 
            get => dateOfBirth;
            set 
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
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