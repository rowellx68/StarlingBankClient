using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global

namespace StarlingBankClient.Controllers
{
    public interface IAccountHoldersController
    {
        /// <summary>
        /// Get basic information about the account holder
        /// </summary>
        /// <return>Returns the Models.AccountHolder response from the API call</return>
        AccountHolder GetAccountHolder();

        /// <summary>
        /// Get basic information about the account holder
        /// </summary>
        /// <return>Returns the Models.AccountHolder response from the API call</return>
        Task<AccountHolder> GetAccountHolderAsync();

        /// <summary>
        /// Get the name of the account holder
        /// </summary>
        /// <return>Returns the Models.AccountHolderName response from the API call</return>
        AccountHolderName GetAccountHolderName();

        /// <summary>
        /// Get the name of the account holder
        /// </summary>
        /// <return>Returns the Models.AccountHolderName response from the API call</return>
        Task<AccountHolderName> GetAccountHolderNameAsync();

    }
} 