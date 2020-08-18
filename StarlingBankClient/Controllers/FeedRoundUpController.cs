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
    public class FeedRoundUpController: BaseController, IFeedRoundUpController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static FeedRoundUpController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static FeedRoundUpController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new FeedRoundUpController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Returns the the round-up goal associated with an account if one has been created
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.RoundUpGoalResponse response from the API call</return>
        public RoundUpGoalResponse FetchRoundUpGoal(Guid accountUid)
        {
            var t = FetchRoundUpGoalAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Returns the the round-up goal associated with an account if one has been created
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.RoundUpGoalResponse response from the API call</return>
        public async Task<RoundUpGoalResponse> FetchRoundUpGoalAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/round-up");

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

            //handle errors
            ValidateResponse(response, context);

            try
            {
                return APIHelper.JsonDeserialize<RoundUpGoalResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Activates transaction round-up and adds remainder to savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Round-up goal</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateActivateRoundUpGoal(Guid accountUid, RoundUpGoalPayload body)
        {
            var t = UpdateActivateRoundUpGoalAsync(accountUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Activates transaction round-up and adds remainder to savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Round-up goal</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateActivateRoundUpGoalAsync(Guid accountUid, RoundUpGoalPayload body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/round-up");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });


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

        /// <summary>
        /// Deletes the round-up goal associated with an account if one exists
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteStopRoundUpGoal(Guid accountUid)
        {
            var t = DeleteStopRoundUpGoalAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Deletes the round-up goal associated with an account if one exists
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteStopRoundUpGoalAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/round-up");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders(true,true);

            //prepare the API call request to fetch the response
            var request = ClientInstance.Delete(queryUrl, headers, null);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

        }

    }
} 