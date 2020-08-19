using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StarlingBank.Models
{
    public class OnboardingStatus : BaseModel 
    {
        // These fields hold the values for the public properties.
        private OnboardingStageEnum? onboardingStage;
        private DateTime? onboardingCompletedAt;

        /// <summary>
        /// The current stage of onboarding
        /// </summary>
        [JsonProperty("onboardingStage", ItemConverterType = typeof(StringValuedEnumConverter))]
        public OnboardingStageEnum? OnboardingStage 
        { 
            get => onboardingStage;
            set 
            {
                onboardingStage = value;
                OnPropertyChanged("OnboardingStage");
            }
        }

        /// <summary>
        /// The time that onboarding was completed, only present if onboarding has in fact completed
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("onboardingCompletedAt")]
        public DateTime? OnboardingCompletedAt 
        { 
            get => onboardingCompletedAt;
            set 
            {
                onboardingCompletedAt = value;
                OnPropertyChanged("OnboardingCompletedAt");
            }
        }
    }
} 