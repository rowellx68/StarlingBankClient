using System.Threading.Tasks;
using StarlingBankClient.Models;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public interface IIndividualsAndSoleTradersController
    {
        /// <summary>
        /// Get an individual account holder's details
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        Individual GetIndividual();

        /// <summary>
        /// Get an individual account holder's details
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        Task<Individual> GetIndividualAsync();

        /// <summary>
        /// Update an individual account holder's email address
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        void UpdateEmail(UpdateEmailRequest body);

        /// <summary>
        /// Update an individual account holder's email address
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        Task UpdateEmailAsync(UpdateEmailRequest body);

    }
} 