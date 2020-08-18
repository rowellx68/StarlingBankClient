using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IKYCController
    {
        /// <summary>
        /// Get KYC result for an account holder
        /// </summary>
        /// <return>Returns the Models.KYCResult response from the API call</return>
        KYCResult GetKYCResult();

        /// <summary>
        /// Get KYC result for an account holder
        /// </summary>
        /// <return>Returns the Models.KYCResult response from the API call</return>
        Task<KYCResult> GetKYCResultAsync();

    }
} 