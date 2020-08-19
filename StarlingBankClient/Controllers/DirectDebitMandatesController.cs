using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Http.Client;
using StarlingBank.Http.Response;
using StarlingBank.Models;
using StarlingBank.Utilities;

namespace StarlingBank.Controllers
{
    public class DirectDebitMandatesController: BaseController, IDirectDebitMandatesController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static DirectDebitMandatesController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static DirectDebitMandatesController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new DirectDebitMandatesController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the Models.DirectDebitMandateV2 response from the API call</return>
        public DirectDebitMandateV2 GetMandate(Guid mandateUid)
        {
            var t = GetMandateAsync(mandateUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the Models.DirectDebitMandateV2 response from the API call</return>
        public async Task<DirectDebitMandateV2> GetMandateAsync(Guid mandateUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/direct-debit/mandates/{mandateUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "mandateUid", mandateUid }
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
                return APIHelper.JsonDeserialize<DirectDebitMandateV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Cancel the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteCancelMandate(Guid mandateUid)
        {
            var t = DeleteCancelMandateAsync(mandateUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Cancel the direct debit mandate with the specified identifier
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteCancelMandateAsync(Guid mandateUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/direct-debit/mandates/{mandateUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "mandateUid", mandateUid }
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

        /// <summary>
        /// Get a transaction history for a direct debit
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.DirectDebitPaymentsResponse response from the API call</return>
        public DirectDebitPaymentsResponse ListPaymentsForMandate(Guid mandateUid, DateTime since)
        {
            var t = ListPaymentsForMandateAsync(mandateUid, since);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a transaction history for a direct debit
        /// </summary>
        /// <param name="mandateUid">Required parameter: Unique identifier of the mandate.</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.DirectDebitPaymentsResponse response from the API call</return>
        public async Task<DirectDebitPaymentsResponse> ListPaymentsForMandateAsync(Guid mandateUid, DateTime since)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/direct-debit/mandates/{mandateUid}/payments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "mandateUid", mandateUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "since", since.ToString("yyyy'-'MM'-'dd") }
            },ArrayDeserializationFormat,ParameterSeparator);


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
                return APIHelper.JsonDeserialize<DirectDebitPaymentsResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get a list of direct debit mandates
        /// </summary>
        /// <return>Returns the Models.DirectDebitMandatesV2 response from the API call</return>
        public DirectDebitMandatesV2 ListMandates()
        {
            var t = ListMandatesAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of direct debit mandates
        /// </summary>
        /// <return>Returns the Models.DirectDebitMandatesV2 response from the API call</return>
        public async Task<DirectDebitMandatesV2> ListMandatesAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/direct-debit/mandates");


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
                return APIHelper.JsonDeserialize<DirectDebitMandatesV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 