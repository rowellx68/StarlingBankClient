using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class SavingsGoalTransferResponseV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid transferUid;
        private bool? success;
        private List<ErrorDetail> error;
        private List<ErrorDetail> errors;

        /// <summary>
        /// Unique identifier for the transfer
        /// </summary>
        [JsonProperty("transferUid")]
        public Guid TransferUid 
        { 
            get => transferUid;
            set 
            {
                transferUid = value;
                OnPropertyChanged("TransferUid");
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("error")]
        public List<ErrorDetail> Error 
        { 
            get => error;
            set 
            {
                error = value;
                OnPropertyChanged("Error");
            }
        }

        /// <summary>
        /// List of errors if the method request failed
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