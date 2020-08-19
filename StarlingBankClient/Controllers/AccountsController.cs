using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using StarlingBank.Exceptions;
using StarlingBank.Http.Client;
using StarlingBank.Http.Response;
using StarlingBank.Models;
using StarlingBank.Utilities;

namespace StarlingBank.Controllers
{
    public class AccountsController: BaseController, IAccountsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static AccountsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AccountsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new AccountsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint lists an account holder's bank accounts.
        /// An account holder, such as a PCA (a *personal current account* - which should really be thought of as a *personal current account holder*), may have many accounts, such as a personal GBP and personal EUR account.
        /// This is different from the idea of an individual (a human/natural person), and is different from a person (a natural (human)/legal (company) person).
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <return>Returns the Models.Accounts response from the API call</return>
        public Accounts GetAccounts()
        {
            var t = GetAccountsAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// This endpoint lists an account holder's bank accounts.
        /// An account holder, such as a PCA (a *personal current account* - which should really be thought of as a *personal current account holder*), may have many accounts, such as a personal GBP and personal EUR account.
        /// This is different from the idea of an individual (a human/natural person), and is different from a person (a natural (human)/legal (company) person).
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <return>Returns the Models.Accounts response from the API call</return>
        public async Task<Accounts> GetAccountsAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts");


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
                return APIHelper.JsonDeserialize<Accounts>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get list of statement periods which are available for an account
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.AccountStatementPeriods response from the API call</return>
        public AccountStatementPeriods GetAvailablePeriods(Guid accountUid)
        {
            var t = GetAvailablePeriodsAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get list of statement periods which are available for an account
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <return>Returns the Models.AccountStatementPeriods response from the API call</return>
        public async Task<AccountStatementPeriods> GetAvailablePeriodsAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/statement/available-periods");

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
                return APIHelper.JsonDeserialize<AccountStatementPeriods>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Identifiers come in pairs:
        /// * A bank identifier, which identifies the bank
        /// * An account identifier, which identifiers the account at the bank
        /// Identifiers can be:
        /// * Sort code and account number for domestic UK payments
        /// * BIC and IBAN for international payments
        /// * ABA and ACH routing numbers for domestic US payments
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.AccountIdentifiers response from the API call</return>
        public AccountIdentifiers GetAccountIdentifiers(Guid accountUid)
        {
            var t = GetAccountIdentifiersAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Identifiers come in pairs:
        /// * A bank identifier, which identifies the bank
        /// * An account identifier, which identifiers the account at the bank
        /// Identifiers can be:
        /// * Sort code and account number for domestic UK payments
        /// * BIC and IBAN for international payments
        /// * ABA and ACH routing numbers for domestic US payments
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.AccountIdentifiers response from the API call</return>
        public async Task<AccountIdentifiers> GetAccountIdentifiersAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/identifiers");

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
                return APIHelper.JsonDeserialize<AccountIdentifiers>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        /// * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
        /// * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
        /// Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
        /// To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.BalanceV2 response from the API call</return>
        public BalanceV2 GetAccountBalance(Guid accountUid)
        {
            var t = GetAccountBalanceAsync(accountUid);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        /// * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
        /// * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
        /// Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
        /// To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <return>Returns the Models.BalanceV2 response from the API call</return>
        public async Task<BalanceV2> GetAccountBalanceAsync(Guid accountUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/balance");

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
                return APIHelper.JsonDeserialize<BalanceV2>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get whether there are available funds for a requested amount
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="targetAmountInMinorUnits">Required parameter: Target amount in minor units</param>
        /// <return>Returns the Models.ConfirmationOfFundsResponse response from the API call</return>
        public ConfirmationOfFundsResponse GetConfirmationOfFunds(Guid accountUid, long targetAmountInMinorUnits)
        {
            var t = GetConfirmationOfFundsAsync(accountUid, targetAmountInMinorUnits);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get whether there are available funds for a requested amount
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="targetAmountInMinorUnits">Required parameter: Target amount in minor units</param>
        /// <return>Returns the Models.ConfirmationOfFundsResponse response from the API call</return>
        public async Task<ConfirmationOfFundsResponse> GetConfirmationOfFundsAsync(Guid accountUid, long targetAmountInMinorUnits)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/confirmation-of-funds");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "targetAmountInMinorUnits", targetAmountInMinorUnits }
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
                return APIHelper.JsonDeserialize<ConfirmationOfFundsResponse>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="yearMonth">Required parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream GetDownloadCsvStatement(Guid accountUid, string yearMonth)
        {
            var t = GetDownloadCsvStatementAsync(accountUid, yearMonth);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="yearMonth">Required parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> GetDownloadCsvStatementAsync(Guid accountUid, string yearMonth)
        {
            //validating required parameters
            if (null == yearMonth)
                throw new ArgumentNullException(nameof(yearMonth), "The parameter \"yearMonth\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/statement/download");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "yearMonth", yearMonth }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders(true,true);

            //prepare the API call request to fetch the response
            var request = ClientInstance.Get(queryUrl,headers);

            //invoke request and get response
            var response = await ClientInstance.ExecuteAsBinaryAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

            try
            {
                return response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="start">Required parameter: Example: </param>
        /// <param name="end">Optional parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream GetDownloadCsvStatementForDateRange(Guid accountUid, DateTime start, DateTime? end = null)
        {
            var t = GetDownloadCsvStatementForDateRangeAsync(accountUid, start, end);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'
        /// </summary>
        /// <param name="accountUid">Required parameter: Example: </param>
        /// <param name="start">Required parameter: Example: </param>
        /// <param name="end">Optional parameter: Example: </param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> GetDownloadCsvStatementForDateRangeAsync(Guid accountUid, DateTime start, DateTime? end = null)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/statement/downloadForDateRange");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "start", start.ToString("yyyy'-'MM'-'dd") },
                { "end", end?.ToString("yyyy'-'MM'-'dd") }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetRequestHeaders(true,true);

            //prepare the API call request to fetch the response
            var request = ClientInstance.Get(queryUrl,headers);

            //invoke request and get response
            var response = await ClientInstance.ExecuteAsBinaryAsync(request).ConfigureAwait(false);
            var context = new HTTPContext(request,response);

            //handle errors
            ValidateResponse(response, context);

            try
            {
                return response.RawBody;
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 