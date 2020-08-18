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
    public class SoleTradersController: BaseController, ISoleTradersController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static SoleTradersController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SoleTradersController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new SoleTradersController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get sole trader business details
        /// </summary>
        /// <return>Returns the Models.SoleTrader response from the API call</return>
        public SoleTrader GetSoleTrader()
        {
            var t = GetSoleTraderAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get sole trader business details
        /// </summary>
        /// <return>Returns the Models.SoleTrader response from the API call</return>
        public async Task<SoleTrader> GetSoleTraderAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/sole-trader");


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
                return APIHelper.JsonDeserialize<SoleTrader>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 