using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Http.Client;
using StarlingBank.Http.Response;
using StarlingBank.Utilities;

namespace StarlingBank.Controllers
{
    public class ProfileImagesController: BaseController, IProfileImagesController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static ProfileImagesController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ProfileImagesController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new ProfileImagesController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetDownloadProfileImage(Guid accountHolderUid)
        {
            var t = GetDownloadProfileImageAsync(accountHolderUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetDownloadProfileImageAsync(Guid accountHolderUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/{accountHolderUid}/profile-image");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountHolderUid", accountHolderUid }
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
                return APIHelper.JsonDeserialize<dynamic>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Update a profile image if one already exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <param name="contentType">Required parameter: Example: </param>
        /// <param name="body">Required parameter: Attachment input stream</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateProfileImage(Guid accountHolderUid, string contentType, object body)
        {
            var t = UpdateProfileImageAsync(accountHolderUid, contentType, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update a profile image if one already exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <param name="contentType">Required parameter: Example: </param>
        /// <param name="body">Required parameter: Attachment input stream</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateProfileImageAsync(Guid accountHolderUid, string contentType, object body)
        {
            //validating required parameters
            if (null == contentType)
                throw new ArgumentNullException(nameof(contentType), "The parameter \"contentType\" is a required parameter and cannot be null.");

            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/{accountHolderUid}/profile-image");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountHolderUid", accountHolderUid }
            });


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>
            {
                {"user-agent", "StarlingBankClient"}, 
                {"Content-Type", contentType}, 
                {"Authorization", $"Bearer {Configuration.OAuthAccessToken}"}
            };

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
        /// Delete a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteProfileImage(Guid accountHolderUid)
        {
            var t = DeleteProfileImageAsync(accountHolderUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a profile image if one exists
        /// </summary>
        /// <param name="accountHolderUid">Required parameter: Unique identifier of an account holder</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteProfileImageAsync(Guid accountHolderUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/{accountHolderUid}/profile-image");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountHolderUid", accountHolderUid }
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