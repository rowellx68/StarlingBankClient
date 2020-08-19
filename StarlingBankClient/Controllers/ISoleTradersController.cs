using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface ISoleTradersController
    {
        /// <summary>
        /// Get sole trader business details
        /// </summary>
        /// <return>Returns the Models.SoleTrader response from the API call</return>
        SoleTrader GetSoleTrader();

        /// <summary>
        /// Get sole trader business details
        /// </summary>
        /// <return>Returns the Models.SoleTrader response from the API call</return>
        Task<SoleTrader> GetSoleTraderAsync();

    }
} 