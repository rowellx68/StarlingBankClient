using System;
using System.Text;
using System.Threading.Tasks;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Http.Client;
using StarlingBankClient.Http.Response;
using StarlingBankClient.Models;
using StarlingBankClient.Utilities;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace StarlingBankClient.Controllers
{
    public class IndividualsAndSoleTradersController: BaseController, IIndividualsAndSoleTradersController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static IndividualsAndSoleTradersController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static IndividualsAndSoleTradersController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new IndividualsAndSoleTradersController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get an individual account holder's details
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        public Individual GetIndividual()
        {
            var t = GetIndividualAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an individual account holder's details
        /// </summary>
        /// <return>Returns the Models.Individual response from the API call</return>
        public async Task<Individual> GetIndividualAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/individual");


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
        /// Update an individual account holder's email address
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEmail(UpdateEmailRequest body)
        {
            var t = UpdateEmailAsync(body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update an individual account holder's email address
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEmailAsync(UpdateEmailRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/individual/email");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetContentRequestHeaders();

            //append body params
            var serializedBody = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            var request = ClientInstance.PutBody(queryUrl, headers, serializedBody);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

        }

    }
} 