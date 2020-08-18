using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class PayeeAccountCreationResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string payeeAccountUid;
        private bool? success;
        private ConsentInformation consentInformation;
        private List<ErrorDetail> errors;

        /// <summary>
        /// The newly created payee unique identifier, only present on successful payee account creation
        /// </summary>
        [JsonProperty("payeeAccountUid")]
        public string PayeeAccountUid 
        { 
            get => payeeAccountUid;
            set 
            {
                payeeAccountUid = value;
                OnPropertyChanged("PayeeAccountUid");
            }
        }

        /// <summary>
        /// True if the method completed successfully
        /// </summary>
        [JsonProperty("success")]
        public bool? Success 
        { 
            get => success;
            set 
            {
                success = value;
                OnPropertyChanged("Success");
            }
        }

        /// <summary>
        /// Denotes whether a request has been paused in order for the user to approve it.
        /// </summary>
        [JsonProperty("consentInformation")]
        public ConsentInformation ConsentInformation 
        { 
            get => consentInformation;
            set 
            {
                consentInformation = value;
                OnPropertyChanged("ConsentInformation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public List<ErrorDetail> Errors 
        { 
            get => errors;
            set 
            {
                errors = value;
                OnPropertyChanged("Errors");
            }
        }
    }
} 