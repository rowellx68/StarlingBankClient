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
    public class PayeesController: BaseController, IPayeesController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static PayeesController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PayeesController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new PayeesController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get an account holder's payees
        /// </summary>
        /// <return>Returns the Models.Payees response from the API call</return>
        public Payees GetPayees()
        {
            var t = GetPayeesAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an account holder's payees
        /// </summary>
        /// <return>Returns the Models.Payees response from the API call</return>
        public async Task<Payees> GetPayeesAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees");


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
                return APIHelper.JsonDeserialize<Payees>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <param name="body">Required parameter: Payee creation object</param>
        /// <return>Returns the Models.PayeeCreationResponse response from the API call</return>
        public PayeeCreationResponse CreatePayee(PayeeCreationRequest body)
        {
            var t = CreatePayeeAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a payee
        /// </summary>
        /// <param name="body">Required parameter: Payee creation object</param>
        /// <return>Returns the Models.PayeeCreationResponse response from the API call</return>
        public async Task<PayeeCreationResponse> CreatePayeeAsync(PayeeCreationRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees");


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
                return APIHelper.JsonDeserialize<PayeeCreationResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Create a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="body">Required parameter: Payee account creation object</param>
        /// <return>Returns the Models.PayeeAccountCreationResponse response from the API call</return>
        public PayeeAccountCreationResponse CreatePayeeAccount(Guid payeeUid, PayeeAccountCreationRequest body)
        {
            var t = CreatePayeeAccountAsync(payeeUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="body">Required parameter: Payee account creation object</param>
        /// <return>Returns the Models.PayeeAccountCreationResponse response from the API call</return>
        public async Task<PayeeAccountCreationResponse> CreatePayeeAccountAsync(Guid payeeUid, PayeeAccountCreationRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees/{payeeUid}/account");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "payeeUid", payeeUid }
            });


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
                return APIHelper.JsonDeserialize<PayeeAccountCreationResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get scheduled payments
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the Models.ScheduledPayments response from the API call</return>
        public ScheduledPayments ListPaymentOrdersForAccount(Guid payeeUid, Guid accountUid)
        {
            var t = ListPaymentOrdersForAccountAsync(payeeUid, accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get scheduled payments
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the Models.ScheduledPayments response from the API call</return>
        public async Task<ScheduledPayments> ListPaymentOrdersForAccountAsync(Guid payeeUid, Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees/{payeeUid}/account/{accountUid}/scheduled-payments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "payeeUid", payeeUid },
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
                return APIHelper.JsonDeserialize<ScheduledPayments>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Deletes a payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the void response from the API call</return>
        public void DeletePayee(Guid payeeUid)
        {
            var t = DeletePayeeAsync(payeeUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Deletes a payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeletePayeeAsync(Guid payeeUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees/{payeeUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "payeeUid", payeeUid }
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
        /// Delete a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the void response from the API call</return>
        public void DeletePayeeAccount(Guid payeeUid, Guid accountUid)
        {
            var t = DeletePayeeAccountAsync(payeeUid, accountUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a payee account
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeletePayeeAccountAsync(Guid payeeUid, Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees/{payeeUid}/account/{accountUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "payeeUid", payeeUid },
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

        /// <summary>
        /// View a history of payments to your payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.Payments response from the API call</return>
        public Payments ListPaymentsForPayeeAccount(Guid payeeUid, Guid accountUid, DateTime since)
        {
            var t = ListPaymentsForPayeeAccountAsync(payeeUid, accountUid, since);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// View a history of payments to your payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <param name="accountUid">Required parameter: Unique identifier of the payee account</param>
        /// <param name="since">Required parameter: Start date for a transaction history</param>
        /// <return>Returns the Models.Payments response from the API call</return>
        public async Task<Payments> ListPaymentsForPayeeAccountAsync(Guid payeeUid, Guid accountUid, DateTime since)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees/{payeeUid}/account/{accountUid}/payments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "payeeUid", payeeUid },
                { "accountUid", accountUid }
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
                return APIHelper.JsonDeserialize<Payments>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Serves the image for the payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetServePayeeImageFile(Guid payeeUid)
        {
            var t = GetServePayeeImageFileAsync(payeeUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Serves the image for the payee
        /// </summary>
        /// <param name="payeeUid">Required parameter: Unique identifier of the payee</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetServePayeeImageFileAsync(Guid payeeUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payees/{payeeUid}/image");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "payeeUid", payeeUid }
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

    }
} 