using System.Text;
using System.Threading.Tasks;
using StarlingBank.Http.Client;
using StarlingBank.Http.Response;
using StarlingBank.Models;
using StarlingBank.Utilities;

namespace StarlingBank.Controllers
{
    public class WebhooksController: BaseController, IWebhooksController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static WebhooksController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static WebhooksController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new WebhooksController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Optional parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void CreateDispatchWebhook(DefaultWebhookPayloadModel body = null)
        {
            var t = CreateDispatchWebhookAsync(body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Optional parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateDispatchWebhookAsync(DefaultWebhookPayloadModel body = null)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/yourdomain.com/your/registered/web-hook/address");


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetContentRequestHeaders();

            //append body params
            var serializedBody = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            var request = ClientInstance.PostBody(queryUrl, headers, serializedBody);

            //invoke request and get response
            var response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);
            //handle errors defined at the API level
            ValidateResponse(response, context);

        }

    }
} 