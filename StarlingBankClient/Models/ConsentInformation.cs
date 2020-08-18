using System;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class ConsentInformation : BaseModel 
    {
        // These fields hold the values for the public properties.
        private ApprovalTypeEnum approvalType;
        private Guid? consentUid;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("approvalType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public ApprovalTypeEnum ApprovalType 
        { 
            get => approvalType;
            set 
            {
                approvalType = value;
                OnPropertyChanged("ApprovalType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("consentUid")]
        public Guid? ConsentUid 
        { 
            get => consentUid;
            set 
            {
                consentUid = value;
                OnPropertyChanged("ConsentUid");
            }
        }
    }
} 