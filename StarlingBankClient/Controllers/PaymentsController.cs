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
    public class PaymentsController: BaseController, IPaymentsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static PaymentsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PaymentsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new PaymentsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderV2 response from the API call</return>
        public PaymentOrderV2 GetPaymentOrder(Guid paymentOrderUid)
        {
            var t = GetPaymentOrderAsync(paymentOrderUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderV2 response from the API call</return>
        public async Task<PaymentOrderV2> GetPaymentOrderAsync(Guid paymentOrderUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/payment-order/{paymentOrderUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "paymentOrderUid", paymentOrderUid }
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
                return APIHelper.JsonDeserialize<PaymentOrderV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Creates and sends an immediate payment within the UK under the Faster Payments Scheme or via SEPA for payments between Euro accounts. The recipient of the payment must be a payee of the account holder (new payees can be created using the 'Payees' endpoint) OR be defined in the `paymentRecipient` member of the request.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Payment instruction object.</param>
        /// <return>Returns the Models.InstructLocalPaymentResponse response from the API call</return>
        public InstructLocalPaymentResponse UpdateMakeLocalPayment(Guid accountUid, Guid categoryUid, InstructLocalPaymentRequest body)
        {
            var t = UpdateMakeLocalPaymentAsync(accountUid, categoryUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates and sends an immediate payment within the UK under the Faster Payments Scheme or via SEPA for payments between Euro accounts. The recipient of the payment must be a payee of the account holder (new payees can be created using the 'Payees' endpoint) OR be defined in the `paymentRecipient` member of the request.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Payment instruction object.</param>
        /// <return>Returns the Models.InstructLocalPaymentResponse response from the API call</return>
        public async Task<InstructLocalPaymentResponse> UpdateMakeLocalPaymentAsync(Guid accountUid, Guid categoryUid, InstructLocalPaymentRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid }
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
                return APIHelper.JsonDeserialize<InstructLocalPaymentResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <return>Returns the Models.StandingOrdersResponse response from the API call</return>
        public StandingOrdersResponse ListStandingOrders(Guid accountUid, Guid categoryUid)
        {
            var t = ListStandingOrdersAsync(accountUid, categoryUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <return>Returns the Models.StandingOrdersResponse response from the API call</return>
        public async Task<StandingOrdersResponse> ListStandingOrdersAsync(Guid accountUid, Guid categoryUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid }
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
                return APIHelper.JsonDeserialize<StandingOrdersResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Standing order creation object.</param>
        /// <return>Returns the Models.CreateStandingOrderResponse response from the API call</return>
        public CreateStandingOrderResponse CreateStandingOrder(Guid accountUid, Guid categoryUid, CreateStandingOrderRequest body)
        {
            var t = CreateStandingOrderAsync(accountUid, categoryUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="body">Required parameter: Standing order creation object.</param>
        /// <return>Returns the Models.CreateStandingOrderResponse response from the API call</return>
        public async Task<CreateStandingOrderResponse> CreateStandingOrderAsync(Guid accountUid, Guid categoryUid, CreateStandingOrderRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid }
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
                return APIHelper.JsonDeserialize<CreateStandingOrderResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <return>Returns the Models.StandingOrder response from the API call</return>
        public StandingOrder GetStandingOrder(Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
        {
            var t = GetStandingOrderAsync(accountUid, categoryUid, paymentOrderUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <return>Returns the Models.StandingOrder response from the API call</return>
        public async Task<StandingOrder> GetStandingOrderAsync(Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "paymentOrderUid", paymentOrderUid }
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
                return APIHelper.JsonDeserialize<StandingOrder>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <param name="body">Required parameter: Standing order update request.</param>
        /// <return>Returns the Models.UpdateStandingOrderResponse response from the API call</return>
        public UpdateStandingOrderResponse UpdateStandingOrder(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                UpdateStandingOrderRequest body)
        {
            var t = UpdateStandingOrderAsync(accountUid, categoryUid, paymentOrderUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <param name="body">Required parameter: Standing order update request.</param>
        /// <return>Returns the Models.UpdateStandingOrderResponse response from the API call</return>
        public async Task<UpdateStandingOrderResponse> UpdateStandingOrderAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                UpdateStandingOrderRequest body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "paymentOrderUid", paymentOrderUid }
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
                return APIHelper.JsonDeserialize<UpdateStandingOrderResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteCancelStandingOrder(Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
        {
            var t = DeleteCancelStandingOrderAsync(accountUid, categoryUid, paymentOrderUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteCancelStandingOrderAsync(Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "paymentOrderUid", paymentOrderUid }
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
        /// N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <param name="count">Optional parameter: Number of next payment dates to retrieve, between 1 and 100. If count is greater than the number of future payments all future payments will be returned. Defaults to 10.</param>
        /// <return>Returns the Models.NextPaymentDatesResponse response from the API call</return>
        public NextPaymentDatesResponse ListNextPaymentDates(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                int? count = null)
        {
            var t = ListNextPaymentDatesAsync(accountUid, categoryUid, paymentOrderUid, count);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="paymentOrderUid">Required parameter: Payment Order uid</param>
        /// <param name="count">Optional parameter: Number of next payment dates to retrieve, between 1 and 100. If count is greater than the number of future payments all future payments will be returned. Defaults to 10.</param>
        /// <return>Returns the Models.NextPaymentDatesResponse response from the API call</return>
        public async Task<NextPaymentDatesResponse> ListNextPaymentDatesAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid paymentOrderUid,
                int? count = null)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/account/{accountUid}/category/{categoryUid}/standing-orders/{paymentOrderUid}/upcoming-payments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "paymentOrderUid", paymentOrderUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "count", count }
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
                return APIHelper.JsonDeserialize<NextPaymentDatesResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get the payments associated with a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderPaymentsResponse response from the API call</return>
        public PaymentOrderPaymentsResponse GetPaymentOrderPayments(Guid paymentOrderUid)
        {
            var t = GetPaymentOrderPaymentsAsync(paymentOrderUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the payments associated with a payment order
        /// </summary>
        /// <param name="paymentOrderUid">Required parameter: Payment order uid</param>
        /// <return>Returns the Models.PaymentOrderPaymentsResponse response from the API call</return>
        public async Task<PaymentOrderPaymentsResponse> GetPaymentOrderPaymentsAsync(Guid paymentOrderUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/payments/local/payment-order/{paymentOrderUid}/payments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "paymentOrderUid", paymentOrderUid }
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
                return APIHelper.JsonDeserialize<PaymentOrderPaymentsResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 