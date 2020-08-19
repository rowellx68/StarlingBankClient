using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBank.Controllers
{
    public interface ISubscriptionsController
    {
        /// <summary>
        /// Fetch product subscription details for an account holder
        /// </summary>
        /// <return>Returns the Models.AccountHolderSubscription response from the API call</return>
        AccountHolderSubscription GetAccountHolderSubscription();

        /// <summary>
        /// Fetch product subscription details for an account holder
        /// </summary>
        /// <return>Returns the Models.AccountHolderSubscription response from the API call</return>
        Task<AccountHolderSubscription> GetAccountHolderSubscriptionAsync();

    }
} 