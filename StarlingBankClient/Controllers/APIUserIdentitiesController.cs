using System;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Http.Client;
using StarlingBank.Http.Response;
using StarlingBank.Models;
using StarlingBank.Utilities;

namespace StarlingBank.Controllers
{
    public class APIUserIdentitiesController: BaseController, IAPIUserIdentitiesController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static APIUserIdentitiesController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static APIUserIdentitiesController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new APIUserIdentitiesController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier.
        /// </summary>
        /// <return>Returns the Models.IdentityV2 response from the API call</return>
        public IdentityV2 GetTokenIdentity()
        {
            var t = GetTokenIdentityAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier.
        /// </summary>
        /// <return>Returns the Models.IdentityV2 response from the API call</return>
        public async Task<IdentityV2> GetTokenIdentityAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/identity/token");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders();

            //prepare the API call request to fetch the response
            var request = ClientInstance.Get(queryUrl,headers);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

            try
            {
                return APIHelper.JsonDeserialize<IdentityV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// The individual who authorised the application
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        public Individual GetAuthorisingIndividual()
        {
            var t = GetAuthorisingIndividualAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// The individual who authorised the application
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        public async Task<Individual> GetAuthorisingIndividualAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/identity/individual");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders();

            //prepare the API call request to fetch the response
            var request = ClientInstance.Get(queryUrl,headers);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

            try
            {
                return APIHelper.JsonDeserialize<Individual>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// This endpoint logs an individual out by disabling all of their active access tokens.
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        public void UpdateLogoutIndividual()
        {
            var t = UpdateLogoutIndividualAsync();
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// This endpoint logs an individual out by disabling all of their active access tokens.
        /// </summary>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateLogoutIndividualAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/identity/logout");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders(true,true);

            //prepare the API call request to fetch the response
            var request = ClientInstance.Put(queryUrl, headers, null);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

        }

    }
} 