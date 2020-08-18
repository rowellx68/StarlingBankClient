using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class Payee : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? payeeUid;
        private string payeeName;
        private string phoneNumber;
        private PayeeType2Enum? payeeType;
        private string firstName;
        private string middleName;
        private string lastName;
        private string businessName;
        private DateTime? dateOfBirth;
        private List<PayeeAccount> accounts;

        /// <summary>
        /// The uid of this payee
        /// </summary>
        [JsonProperty("payeeUid")]
        public Guid? PayeeUid 
        { 
            get => payeeUid;
            set 
            {
                payeeUid = value;
                OnPropertyChanged("PayeeUid");
            }
        }

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
        /// INDIVIDUAL
        /// </summary>
        [JsonProperty("payeeType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PayeeType2Enum? PayeeType 
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
        /// Date of birth
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
        /// Accounts for this payee
        /// </summary>
        [JsonProperty("accounts")]
        public List<PayeeAccount> Accounts 
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