using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Http.Client;
using StarlingBankClient.Http.Response;
using StarlingBankClient.Models;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Controllers
{
    public class RecurringCardPaymentsController: BaseController, IRecurringCardPaymentsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static RecurringCardPaymentsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static RecurringCardPaymentsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new RecurringCardPaymentsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Fetch recurring card payments for an account holder
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.RecurringCardPayment response from the API call</return>
        public RecurringCardPayment ListRecurringPayments(Guid accountUid)
        {
            var t = ListRecurringPaymentsAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Fetch recurring card payments for an account holder
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.RecurringCardPayment response from the API call</return>
        public async Task<RecurringCardPayment> ListRecurringPaymentsAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/recurring-payment");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });


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
                return APIHelper.JsonDeserialize<RecurringCardPayment>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 