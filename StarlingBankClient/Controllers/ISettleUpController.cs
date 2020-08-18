using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface ISettleUpController
    {
        /// <summary>
        /// Fetch Settle Up profile for an account holder
        /// </summary>
        /// <return>Returns the Models.SettleUpProfile response from the API call</return>
        SettleUpProfile GetSettleUpProfile();

        /// <summary>
        /// Fetch Settle Up profile for an account holder
        /// </summary>
        /// <return>Returns the Models.SettleUpProfile response from the API call</return>
        Task<SettleUpProfile> GetSettleUpProfileAsync();

    }
} 