using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
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