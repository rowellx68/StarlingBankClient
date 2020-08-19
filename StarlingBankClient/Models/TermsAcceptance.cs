using System;
using Newtonsoft.Json;
using StarlingBank.Utilities;

namespace StarlingBank.Models
{
    public class TermsAcceptance : BaseModel 
    {
        // These fields hold the values for the public properties.
        private PolicyDocumentEnum policyDocument;
        private int version;
        private bool termsAccepted;
        private DateTime acceptanceDate;

        /// <summary>
        /// The policy document which has been accepted
        /// </summary>
        [JsonProperty("policyDocument", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PolicyDocumentEnum PolicyDocument 
        { 
            get => policyDocument;
            set 
            {
                policyDocument = value;
                OnPropertyChanged("PolicyDocument");
            }
        }

        /// <summary>
        /// The version of the policy document which has been accepted
        /// </summary>
        [JsonProperty("version")]
        public int Version 
        { 
            get => version;
            set 
            {
                version = value;
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Was policy document accepted
        /// </summary>
        [JsonProperty("termsAccepted")]
        public bool TermsAccepted 
        { 
            get => termsAccepted;
            set 
            {
                termsAccepted = value;
                OnPropertyChanged("TermsAccepted");
            }
        }

        /// <summary>
        /// The date on which the policy document was accepted
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("acceptanceDate")]
        public DateTime AcceptanceDate 
        { 
            get => acceptanceDate;
            set 
            {
                acceptanceDate = value;
                OnPropertyChanged("AcceptanceDate");
            }
        }
    }
} 