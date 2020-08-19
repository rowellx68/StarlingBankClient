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
    public class OnboardingController: BaseController, IOnboardingController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static OnboardingController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static OnboardingController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new OnboardingController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get the onboarding status of the account
        /// </summary>
        /// <return>Returns the Models.OnboardingStatus response from the API call</return>
        public OnboardingStatus GetOnboardingStatus()
        {
            var t = GetOnboardingStatusAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the onboarding status of the account
        /// </summary>
        /// <return>Returns the Models.OnboardingStatus response from the API call</return>
        public async Task<OnboardingStatus> GetOnboardingStatusAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/onboarding");


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
                return APIHelper.JsonDeserialize<OnboardingStatus>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Onboard an account
        /// </summary>
        /// <param name="body">Required parameter: Account onboarding request</param>
        /// <return>Returns the Models.OnboardingResponse response from the API call</return>
        public OnboardingResponse UpdateOnboard(OnboardingRequest body)
        {
            var t = UpdateOnboardAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Onboard an account
        /// </summary>
        /// <param name="body">Required parameter: Account onboarding request</param>
        /// <return>Returns the Models.OnboardingResponse response from the API call</return>
        public async Task<OnboardingResponse> UpdateOnboardAsync(OnboardingRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/onboarding");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetContentRequestHeaders(true, true);

            //append body params
            var serializedBody = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            var request = ClientInstance.PutBody(queryUrl, headers, serializedBody);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

            try
            {
                return APIHelper.JsonDeserialize<OnboardingResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 