using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class PayeeCreationRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string payeeName;
        private string phoneNumber;
        private PayeeTypeEnum payeeType;
        private string firstName;
        private string middleName;
        private string lastName;
        private string businessName;
        private DateTime? dateOfBirth;
        private List<PayeeAccountCreationRequest> accounts;

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("payeeName")]
        public string PayeeName 
        { 
            get => payeeName;
            set 
            {
                payeeName = value;
                OnPropertyChanged("PayeeName");
            }
        }

        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber 
        { 
            get => phoneNumber;
            set 
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payeeType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PayeeTypeEnum PayeeType 
        { 
            get => payeeType;
            set 
            {
                payeeType = value;
                OnPropertyChanged("PayeeType");
            }
        }

        /// <summary>
        /// First name
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
        /// Middle name
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName 
        { 
            get => middleName;
            set 
            {
                middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Last name
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
        /// Business name
        /// </summary>
        [JsonProperty("businessName")]
        public string BusinessName 
        { 
            get => businessName;
            set 
            {
                businessName = value;
                OnPropertyChanged("BusinessName");
            }
        }

        /// <summary>
        /// List of accounts for this payee
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
        [JsonProperty("accounts")]
        public List<PayeeAccountCreationRequest> Accounts 
        { 
            get => accounts;
            set 
            {
                accounts = value;
                OnPropertyChanged("Accounts");
            }
        }
    }
} 