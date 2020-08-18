using System.Threading.Tasks;
using StarlingBankClient.Models;

namespace StarlingBankClient.Controllers
{
    public interface IAPIUserIdentitiesController
    {
        /// <summary>
        /// This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier.
        /// </summary>
        /// <return>Returns the Models.IdentityV2 response from the API call</return>
        IdentityV2 GetTokenIdentity();

        /// <summary>
        /// This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier.
        /// </summary>
        /// <return>Returns the Models.IdentityV2 response from the API call</return>
        Task<IdentityV2> GetTokenIdentityAsync();

        /// <summary>
        /// The individual who authorised the application
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        Individual GetAuthorisingIndividual();

        /// <summary>
        /// The individual who authorised the application
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        Task<Individual> GetAuthorisingIndividualAsync();

        /// <summary>
        /// This endpoint logs an individual out by disabling all of their active access tokens.
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        void UpdateLogoutIndividual();

        /// <summary>
        /// This endpoint logs an individual out by disabling all of their active access tokens.
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        Task UpdateLogoutIndividualAsync();

    }
} 