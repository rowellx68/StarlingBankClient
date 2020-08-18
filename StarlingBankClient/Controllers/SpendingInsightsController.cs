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
    public class SpendingInsightsController: BaseController, ISpendingInsightsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static SpendingInsightsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SpendingInsightsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new SpendingInsightsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get the spending insights grouped by counter party
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCounterPartySummary response from the API call</return>
        public SpendingCounterPartySummary GetQuerySpendingInsightsByCounterparty(Guid accountUid, string year, MonthEnum month)
        {
            var t = GetQuerySpendingInsightsByCounterpartyAsync(accountUid, year, month);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the spending insights grouped by counter party
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCounterPartySummary response from the API call</return>
        public async Task<SpendingCounterPartySummary> GetQuerySpendingInsightsByCounterpartyAsync(Guid accountUid, string year, MonthEnum month)
        {
            //validating required parameters
            if (null == year)
                throw new ArgumentNullException(nameof(year), "The parameter \"year\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/spending-insights/counter-party");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "year", year },
                { "month", MonthEnumHelper.ToValue(month) }
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
                return APIHelper.JsonDeserialize<SpendingCounterPartySummary>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get the spending insights grouped by spending category
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCategorySummary response from the API call</return>
        public SpendingCategorySummary GetQuerySpendingInsightsBySpendingCategory(Guid accountUid, string year, MonthEnum month)
        {
            var t = GetQuerySpendingInsightsBySpendingCategoryAsync(accountUid, year, month);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the spending insights grouped by spending category
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCategorySummary response from the API call</return>
        public async Task<SpendingCategorySummary> GetQuerySpendingInsightsBySpendingCategoryAsync(Guid accountUid, string year, MonthEnum month)
        {
            //validating required parameters
            if (null == year)
                throw new ArgumentNullException(nameof(year), "The parameter \"year\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/spending-insights/spending-category");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "year", year },
                { "month", MonthEnumHelper.ToValue(month) }
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
                return APIHelper.JsonDeserialize<SpendingCategorySummary>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Get the spending insights grouped by country
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCountrySummary response from the API call</return>
        public SpendingCountrySummary GetQuerySpendingInsightsByCountry(Guid accountUid, string year, MonthEnum month)
        {
            var t = GetQuerySpendingInsightsByCountryAsync(accountUid, year, month);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the spending insights grouped by country
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="year">Required parameter: Year</param>
        /// <param name="month">Required parameter: Month</param>
        /// <return>Returns the Models.SpendingCountrySummary response from the API call</return>
        public async Task<SpendingCountrySummary> GetQuerySpendingInsightsByCountryAsync(Guid accountUid, string year, MonthEnum month)
        {
            //validating required parameters
            if (null == year)
                throw new ArgumentNullException(nameof(year), "The parameter \"year\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/accounts/{accountUid}/spending-insights/country");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                { "year", year },
                { "month", MonthEnumHelper.ToValue(month) }
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
                return APIHelper.JsonDeserialize<SpendingCountrySummary>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 