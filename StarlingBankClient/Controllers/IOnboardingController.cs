using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IOnboardingController
    {
        /// <summary>
        /// Get the onboarding status of the account
        /// </summary>
        /// <return>Returns the Models.OnboardingStatus response from the API call</return>
        OnboardingStatus GetOnboardingStatus();

        /// <summary>
        /// Get the onboarding status of the account
        /// </summary>
        /// <return>Returns the Models.OnboardingStatus response from the API call</return>
        Task<OnboardingStatus> GetOnboardingStatusAsync();

        /// <summary>
        /// Onboard an account
        /// </summary>
        /// <param name="body">Required parameter: Account onboarding request</param>
        /// <return>Returns the Models.OnboardingResponse response from the API call</return>
        OnboardingResponse UpdateOnboard(OnboardingRequest body);

        /// <summary>
        /// Onboard an account
        /// </summary>
        /// <param name="body">Required parameter: Account onboarding request</param>
        /// <return>Returns the Models.OnboardingResponse response from the API call</return>
        Task<OnboardingResponse> UpdateOnboardAsync(OnboardingRequest body);

    }
} 