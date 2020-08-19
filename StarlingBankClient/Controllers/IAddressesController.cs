using System.Threading.Tasks;
using StarlingBank.Models;

// ReSharper disable UnusedMember.Global

namespace StarlingBank.Controllers
{
    public interface IAddressesController
    {
        /// <summary>
        /// Get the account holder's addresses
        /// </summary>
        /// <return>Returns the Models.AddressesV2 response from the API call</return>
        AddressesV2 GetAddresses();

        /// <summary>
        /// Get the account holder's addresses
        /// </summary>
        /// <return>Returns the Models.AddressesV2 response from the API call</return>
        Task<AddressesV2> GetAddressesAsync();

        /// <summary>
        /// Update the account holder's current address
        /// </summary>
        /// <param name="body">Required parameter: Update account holder's current address</param>
        /// <return>Returns the void response from the API call</return>
        void UpdateCurrentAddress(AddressUpdateRequest body);

        /// <summary>
        /// Update the account holder's current address
        /// </summary>
        /// <param name="body">Required parameter: Update account holder's current address</param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateCurrentAddressAsync(AddressUpdateRequest body);

    }
} 