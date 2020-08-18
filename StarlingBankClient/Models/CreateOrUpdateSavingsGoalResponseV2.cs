using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBankClient.Models
{
    public class CreateOrUpdateSavingsGoalResponseV2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid? savingsGoalUid;
        private bool? success;
        private List<ErrorDetail> error;
        private List<ErrorDetail> errors;

        /// <summary>
        /// Unique identifier of the savings goal
        /// </summary>
        [JsonProperty("savingsGoalUid")]
        public Guid? SavingsGoalUid 
        { 
            get => savingsGoalUid;
            set 
            {
                savingsGoalUid = value;
                OnPropertyChanged("SavingsGoalUid");
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