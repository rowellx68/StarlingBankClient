using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global

namespace StarlingBankClient.Controllers
{
    public interface IBusinessesController
    {
        /// <summary>
        /// Get a business account holder's details
        /// </summary>
        /// <return>Returns the Models.Business response from the API call</return>
        Business GetBusiness();

        /// <summary>
        /// Get a business account holder's details
        /// </summary>
        /// <return>Returns the Models.Business response from the API call</return>
        Task<Business> GetBusinessAsync();

        /// <summary>
        /// Get a company's registered address
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        AddressV2 GetRegisteredAddress();

        /// <summary>
        /// Get a company's registered address
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        Task<AddressV2> GetRegisteredAddressAsync();

        /// <summary>
        /// Will fallback to registered address if not available
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        AddressV2 GetCorrespondenceAddress();

        /// <summary>
        /// Will fallback to registered address if not available
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        Task<AddressV2> GetCorrespondenceAddressAsync();

    }
} 