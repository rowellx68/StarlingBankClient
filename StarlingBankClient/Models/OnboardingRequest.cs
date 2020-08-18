using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Models
{
    public class OnboardingRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mobileNumber;
        private string title = "MRS, MISS, MS, LADY, MR, SIR";
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string email;
        private OnboardingAddress currentAddress;
        private List<OnboardingAddress> previousAddresses;
        private IncomeDetails incomeDetails;
        private TaxLiabilityDeclaration taxLiabilityDeclaration;
        private List<TermsAcceptance> termsAcceptance;

        /// <summary>
        /// Account holder's mobile phone number
        /// </summary>
        [JsonProperty("mobileNumber")]
        public string MobileNumber 
        { 
            get => mobileNumber;
            set 
            {
                mobileNumber = value;
                OnPropertyChanged("MobileNumber");
            }
        }

        /// <summary>
        /// Account holder's title
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
        /// Account holder's first name
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
        /// Account holder's last name
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
        /// Account holder's date of birth
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth")]
        public DateTime DateOfBirth 
        { 
            get => dateOfBirth;
            set 
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        /// <summary>
        /// The email address for the account holder
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
        /// Address submitted when onboarding
        /// </summary>
        [JsonProperty("currentAddress")]
        public OnboardingAddress CurrentAddress 
        { 
            get => currentAddress;
            set 
            {
                currentAddress = value;
                OnPropertyChanged("CurrentAddress");
            }
        }

        /// <summary>
        /// Account holder's previous address history, 6 month minimum
        /// </summary>
        [JsonProperty("previousAddresses")]
        public List<OnboardingAddress> PreviousAddresses 
        { 
            get => previousAddresses;
            set 
            {
                previousAddresses = value;
                OnPropertyChanged("PreviousAddresses");
            }
        }

        /// <summary>
        /// Details of the account holder's income
        /// </summary>
        [JsonProperty("incomeDetails")]
        public IncomeDetails IncomeDetails 
        { 
            get => incomeDetails;
            set 
            {
                incomeDetails = value;
                OnPropertyChanged("IncomeDetails");
            }
        }

        /// <summary>
        /// Declaration of tax liabilities
        /// </summary>
        [JsonProperty("taxLiabilityDeclaration")]
        public TaxLiabilityDeclaration TaxLiabilityDeclaration 
        { 
            get => taxLiabilityDeclaration;
            set 
            {
                taxLiabilityDeclaration = value;
                OnPropertyChanged("TaxLiabilityDeclaration");
            }
        }

        /// <summary>
        /// Account holder's terms acceptance details
        /// </summary>
        [JsonProperty("termsAcceptance")]
        public List<TermsAcceptance> TermsAcceptance 
        { 
            get => termsAcceptance;
            set 
            {
                termsAcceptance = value;
                OnPropertyChanged("TermsAcceptance");
            }
        }
    }
} 