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
    public class JointAccountsController: BaseController, IJointAccountsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static JointAccountsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static JointAccountsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new JointAccountsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get a joint account holder's details
        /// </summary>
        /// <return>Returns the Models.JointAccount response from the API call</return>
        public JointAccount GetJointAccount()
        {
            var t = GetJointAccountAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a joint account holder's details
        /// </summary>
        /// <return>Returns the Models.JointAccount response from the API call</return>
        public async Task<JointAccount> GetJointAccountAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account-holder/joint");


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
                return APIHelper.JsonDeserialize<JointAccount>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 