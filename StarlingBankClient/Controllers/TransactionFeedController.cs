using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Http.Client;
using StarlingBankClient.Http.Response;
using StarlingBankClient.Models;
using StarlingBankClient.Utilities;

namespace StarlingBankClient.Controllers
{
    public class TransactionFeedController: BaseController, ITransactionFeedController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static TransactionFeedController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TransactionFeedController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new TransactionFeedController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: User Note</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateUserNote(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UserNoteWrapper body)
        {
            var t = UpdateUserNoteAsync(accountUid, categoryUid, feedItemUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: User Note</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateUserNoteAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UserNoteWrapper body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/user-note");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
            });


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetContentRequestHeaders();

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
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="feedItemAttachmentUid">Required parameter: Feed item attachment uid</param>
        /// <return>Returns the Stream response from the API call</return>
        public Stream GetDownloadFeedItemAttachment(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Guid feedItemAttachmentUid)
        {
            var t = GetDownloadFeedItemAttachmentAsync(accountUid, categoryUid, feedItemUid, feedItemAttachmentUid);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="feedItemAttachmentUid">Required parameter: Feed item attachment uid</param>
        /// <return>Returns the Stream response from the API call</return>
        public async Task<Stream> GetDownloadFeedItemAttachmentAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Guid feedItemAttachmentUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/attachments/{feedItemAttachmentUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid },
                { "feedItemAttachmentUid", feedItemAttachmentUid }
            });


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
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.Receipt response from the API call</return>
        public Receipt GetReceipt(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            var t = GetReceiptAsync(accountUid, categoryUid, feedItemUid);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.Receipt response from the API call</return>
        public async Task<Receipt> GetReceiptAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/receipt");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
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
                return APIHelper.JsonDeserialize<Receipt>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

        /// <summary>
        /// Submit a receipt for a feed item
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Receipt</param>
        /// <return>Returns the Models.ReceiptCreationResponse response from the API call</return>
        public ReceiptCreationResponse CreateOrUpdateReceipt(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Receipt body)
        {
            var t = CreateOrUpdateReceiptAsync(accountUid, categoryUid, feedItemUid, body);
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Submit a receipt for a feed item
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Receipt</param>
        /// <return>Returns the Models.ReceiptCreationResponse response from the API call</return>
        public async Task<ReceiptCreationResponse> CreateOrUpdateReceiptAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                Receipt body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/receipt");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
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
                return APIHelper.JsonDeserialize<ReceiptCreationResponse>(response.Body);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Spending category</param>
        /// <return>Returns the void response from the API call</return>
        public void ChangeTransactionCategory(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UpdateSpendingCategory body)
        {
            var t = ChangeTransactionCategoryAsync(accountUid, categoryUid, feedItemUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <param name="body">Required parameter: Spending category</param>
        /// <return>Returns the void response from the API call</return>
        public async Task ChangeTransactionCategoryAsync(
                Guid accountUid,
                Guid categoryUid,
                Guid feedItemUid,
                UpdateSpendingCategory body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/spending-category");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
            });


            //validate and preprocess url
            var queryUrl = APIHelper.CleanUrl(queryBuilder);

            //append request with appropriate headers and parameters
            var headers = APIHelper.GetContentRequestHeaders();

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
        /// Categories are subdivisions within an account.
        /// The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        /// Other categories are used for Savings Goals.
        /// </summary>
        /// <param name="accountUid">Required parameter: Account uid</param>
        /// <param name="categoryUid">Required parameter: Category uid</param>
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItem response from the API call</return>
        public FeedItem GetFeedItem(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            var t = GetFeedItemAsync(accountUid, categoryUid, feedItemUid);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItem response from the API call</return>
        public async Task<FeedItem> GetFeedItemAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
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
                return APIHelper.JsonDeserialize<FeedItem>(response.Body);
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
        /// <param name="changesSince">Required parameter: Items which have changed since</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        public FeedItems GetQueryFeedItems(Guid accountUid, Guid categoryUid, DateTime changesSince)
        {
            var t = GetQueryFeedItemsAsync(accountUid, categoryUid, changesSince);
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
        /// <param name="changesSince">Required parameter: Items which have changed since</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        public async Task<FeedItems> GetQueryFeedItemsAsync(Guid accountUid, Guid categoryUid, DateTime changesSince)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                // ReSharper disable once StringLiteralTypo
                { "changesSince", changesSince.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") }
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
                return APIHelper.JsonDeserialize<FeedItems>(response.Body);
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
        /// <param name="minTransactionTimestamp">Required parameter: Minimum transaction timestamp</param>
        /// <param name="maxTransactionTimestamp">Required parameter: Maximum transaction timestamp</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        public FeedItems GetQueryFeedItemsWithTransactionTimesBetween(
                Guid accountUid,
                Guid categoryUid,
                DateTime minTransactionTimestamp,
                DateTime maxTransactionTimestamp)
        {
            var t = GetQueryFeedItemsWithTransactionTimesBetweenAsync(accountUid, categoryUid, minTransactionTimestamp, maxTransactionTimestamp);
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
        /// <param name="minTransactionTimestamp">Required parameter: Minimum transaction timestamp</param>
        /// <param name="maxTransactionTimestamp">Required parameter: Maximum transaction timestamp</param>
        /// <return>Returns the Models.FeedItems response from the API call</return>
        public async Task<FeedItems> GetQueryFeedItemsWithTransactionTimesBetweenAsync(
                Guid accountUid,
                Guid categoryUid,
                DateTime minTransactionTimestamp,
                DateTime maxTransactionTimestamp)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/transactions-between");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(queryBuilder, new Dictionary<string, object>
            {
                // ReSharper disable StringLiteralTypo
                { "minTransactionTimestamp", minTransactionTimestamp.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") },
                { "maxTransactionTimestamp", maxTransactionTimestamp.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") }
                // ReSharper restore StringLiteralTypo
            }, ArrayDeserializationFormat,ParameterSeparator);


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
                return APIHelper.JsonDeserialize<FeedItems>(response.Body);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItemAttachments response from the API call</return>
        public FeedItemAttachments GetFeedItemAttachments(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            var t = GetFeedItemAttachmentsAsync(accountUid, categoryUid, feedItemUid);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.FeedItemAttachments response from the API call</return>
        public async Task<FeedItemAttachments> GetFeedItemAttachmentsAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/attachments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
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
                return APIHelper.JsonDeserialize<FeedItemAttachments>(response.Body);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.MastercardFeedItem response from the API call</return>
        public MastercardFeedItem GetMastercardFeedItem(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            var t = GetMastercardFeedItemAsync(accountUid, categoryUid, feedItemUid);
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
        /// <param name="feedItemUid">Required parameter: Feed item uid</param>
        /// <return>Returns the Models.MastercardFeedItem response from the API call</return>
        public async Task<MastercardFeedItem> GetMastercardFeedItemAsync(Guid accountUid, Guid categoryUid, Guid feedItemUid)
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/feed/account/{accountUid}/category/{categoryUid}/{feedItemUid}/mastercard");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "accountUid", accountUid },
                { "categoryUid", categoryUid },
                { "feedItemUid", feedItemUid }
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
                return APIHelper.JsonDeserialize<MastercardFeedItem>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 