using System;
using System.Text;
using System.Threading.Tasks;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Http.Client;
using StarlingBankClient.Http.Response;
using StarlingBankClient.Models;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Controllers
{
    public class BusinessesController: BaseController, IBusinessesController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static BusinessesController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static BusinessesController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new BusinessesController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get a business account holder's details
        /// </summary>
        /// <return>Returns the Models.Business response from the API call</return>
        public Business GetBusiness()
        {
            var t = GetBusinessAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a business account holder's details
        /// </summary>
        /// <return>Returns the Models.Business response from the API call</return>
        public async Task<Business> GetBusinessAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/business");


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
                return APIHelper.JsonDeserialize<Business>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get a company's registered address
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        public AddressV2 GetRegisteredAddress()
        {
            var t = GetRegisteredAddressAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a company's registered address
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        public async Task<AddressV2> GetRegisteredAddressAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/business/registered-address");


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
                return APIHelper.JsonDeserialize<AddressV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Will fallback to registered address if not available
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        public AddressV2 GetCorrespondenceAddress()
        {
            var t = GetCorrespondenceAddressAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Will fallback to registered address if not available
        /// </summary>
        /// <return>Returns the Models.AddressV2 response from the API call</return>
        public async Task<AddressV2> GetCorrespondenceAddressAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/business/correspondence-address");


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
                return APIHelper.JsonDeserialize<AddressV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 