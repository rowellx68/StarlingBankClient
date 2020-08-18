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
    public class SettleUpController: BaseController, ISettleUpController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static SettleUpController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SettleUpController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new SettleUpController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Fetch Settle Up profile for an account holder
        /// </summary>
        /// <return>Returns the Models.SettleUpProfile response from the API call</return>
        public SettleUpProfile GetSettleUpProfile()
        {
            var t = GetSettleUpProfileAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Fetch Settle Up profile for an account holder
        /// </summary>
        /// <return>Returns the Models.SettleUpProfile response from the API call</return>
        public async Task<SettleUpProfile> GetSettleUpProfileAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/settle-up/profile");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders();

            //prepare the API call request to fetch the response
            var request = ClientInstance.Get(queryUrl,headers);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);
            //handle errors defined at the API level
            ValidateResponse(response, context);

            try
            {
                return APIHelper.JsonDeserialize<SettleUpProfile>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 