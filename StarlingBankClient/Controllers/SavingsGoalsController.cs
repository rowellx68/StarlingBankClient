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
    public class SavingsGoalsController: BaseController, ISavingsGoalsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static SavingsGoalsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SavingsGoalsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new SavingsGoalsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalV2 response from the API call</return>
        public SavingsGoalV2 GetSavingsGoal(Guid accountUid, Guid savingsGoalUid)
        {
            var t = GetSavingsGoalAsync(accountUid, savingsGoalUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalV2 response from the API call</return>
        public async Task<SavingsGoalV2> GetSavingsGoalAsync(Guid accountUid, Guid savingsGoalUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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
                return APIHelper.JsonDeserialize<SavingsGoalV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        public CreateOrUpdateSavingsGoalResponseV2 UpdateSavingsGoal(Guid accountUid, Guid savingsGoalUid, SavingsGoalRequestV2 body)
        {
            var t = UpdateSavingsGoalAsync(accountUid, savingsGoalUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        public async Task<CreateOrUpdateSavingsGoalResponseV2> UpdateSavingsGoalAsync(Guid accountUid, Guid savingsGoalUid, SavingsGoalRequestV2 body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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
                return APIHelper.JsonDeserialize<CreateOrUpdateSavingsGoalResponseV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Delete a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteSavingsGoal(Guid accountUid, Guid savingsGoalUid)
        {
            var t = DeleteSavingsGoalAsync(accountUid, savingsGoalUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteSavingsGoalAsync(Guid accountUid, Guid savingsGoalUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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
        /// Get all savings goals
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.SavingsGoalsV2 response from the API call</return>
        public SavingsGoalsV2 GetSavingsGoals(Guid accountUid)
        {
            var t = GetSavingsGoalsAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all savings goals
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.SavingsGoalsV2 response from the API call</return>
        public async Task<SavingsGoalsV2> GetSavingsGoalsAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals");

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
                return APIHelper.JsonDeserialize<SavingsGoalsV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Create a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        public CreateOrUpdateSavingsGoalResponseV2 CreateSavingsGoal(Guid accountUid, SavingsGoalRequestV2 body)
        {
            var t = CreateSavingsGoalAsync(accountUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="body">Required parameter: Savings goal request</param>
        /// <return>Returns the Models.CreateOrUpdateSavingsGoalResponseV2 response from the API call</return>
        public async Task<CreateOrUpdateSavingsGoalResponseV2> CreateSavingsGoalAsync(Guid accountUid, SavingsGoalRequestV2 body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
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
                return APIHelper.JsonDeserialize<CreateOrUpdateSavingsGoalResponseV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get the photo associated with a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalPhotoV2 response from the API call</return>
        public SavingsGoalPhotoV2 GetSavingsGoalPhoto(Guid accountUid, Guid savingsGoalUid)
        {
            var t = GetSavingsGoalPhotoAsync(accountUid, savingsGoalUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the photo associated with a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.SavingsGoalPhotoV2 response from the API call</return>
        public async Task<SavingsGoalPhotoV2> GetSavingsGoalPhotoAsync(Guid accountUid, Guid savingsGoalUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}/photo");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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
                return APIHelper.JsonDeserialize<SavingsGoalPhotoV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Add money into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Top up request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        public SavingsGoalTransferResponseV2 AddMoney(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                TopUpRequestV2 body)
        {
            var t = AddMoneyAsync(accountUid, savingsGoalUid, transferUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add money into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Top up request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        public async Task<SavingsGoalTransferResponseV2> AddMoneyAsync(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                TopUpRequestV2 body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}/add-money/{transferUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid },
                { "transferUid", transferUid }
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
                return APIHelper.JsonDeserialize<SavingsGoalTransferResponseV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Withdraw money from a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Withdrawal request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        public SavingsGoalTransferResponseV2 UpdateWithdrawMoney(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                WithdrawalRequestV2 body)
        {
            var t = UpdateWithdrawMoneyAsync(accountUid, savingsGoalUid, transferUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Withdraw money from a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="transferUid">Required parameter: Transfer uid, generated by the caller</param>
        /// <param name="body">Required parameter: Withdrawal request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        public async Task<SavingsGoalTransferResponseV2> UpdateWithdrawMoneyAsync(
                Guid accountUid,
                Guid savingsGoalUid,
                Guid transferUid,
                WithdrawalRequestV2 body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}/withdraw-money/{transferUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid },
                { "transferUid", transferUid }
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
                return APIHelper.JsonDeserialize<SavingsGoalTransferResponseV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.ScheduledSavingsPaymentV2 response from the API call</return>
        public ScheduledSavingsPaymentV2 GetRecurringTransfer(Guid accountUid, Guid savingsGoalUid)
        {
            var t = GetRecurringTransferAsync(accountUid, savingsGoalUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the Models.ScheduledSavingsPaymentV2 response from the API call</return>
        public async Task<ScheduledSavingsPaymentV2> GetRecurringTransferAsync(Guid accountUid, Guid savingsGoalUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}/recurring-transfer");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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
                return APIHelper.JsonDeserialize<ScheduledSavingsPaymentV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Create a recurring transfer into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Recurring transfer request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        public SavingsGoalTransferResponseV2 CreateOrUpdateRecurringTransfer(Guid accountUid, Guid savingsGoalUid, ScheduledSavingsPaymentRequestV2 body)
        {
            var t = CreateOrUpdateRecurringTransferAsync(accountUid, savingsGoalUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a recurring transfer into a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <param name="body">Required parameter: Recurring transfer request</param>
        /// <return>Returns the Models.SavingsGoalTransferResponseV2 response from the API call</return>
        public async Task<SavingsGoalTransferResponseV2> CreateOrUpdateRecurringTransferAsync(Guid accountUid, Guid savingsGoalUid, ScheduledSavingsPaymentRequestV2 body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}/recurring-transfer");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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
                return APIHelper.JsonDeserialize<SavingsGoalTransferResponseV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Delete the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteRecurringTransfer(Guid accountUid, Guid savingsGoalUid)
        {
            var t = DeleteRecurringTransferAsync(accountUid, savingsGoalUid);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Delete the recurring transfer of a savings goal
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="savingsGoalUid">Required parameter: Savings goal uid</param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteRecurringTransferAsync(Guid accountUid, Guid savingsGoalUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/account/{accountUid}/savings-goals/{savingsGoalUid}/recurring-transfer");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "savingsGoalUid", savingsGoalUid }
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