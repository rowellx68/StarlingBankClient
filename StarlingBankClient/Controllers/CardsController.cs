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
    public class CardsController: BaseController, ICardsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static readonly object SyncObject = new object();
        private static CardsController _instance;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CardsController Instance
        {
            get
            {
                lock (SyncObject)
                {
                    if (null == _instance)
                    {
                        _instance = new CardsController();
                    }
                }
                return _instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Update gambling payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether gambling payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableGamblingPayments(Guid cardUid, Enabling body)
        {
            var t = UpdateEnableGamblingPaymentsAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update gambling payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether gambling payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableGamblingPaymentsAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/gambling-enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update card present payments (contactless and chip and pin) control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnablePos(Guid cardUid, Enabling body)
        {
            var t = UpdateEnablePosAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update card present payments (contactless and chip and pin) control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnablePosAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/pos-enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update magstripe payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether magstripe payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableMagStripePayment(Guid cardUid, Enabling body)
        {
            var t = UpdateEnableMagStripePaymentAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update magstripe payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether magstripe payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableMagStripePaymentAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/mag-stripe-enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update currency switch payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableCurrencySwitch(Guid cardUid, CurrencyFlag body)
        {
            var t = UpdateEnableCurrencySwitchAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update currency switch payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableCurrencySwitchAsync(Guid cardUid, CurrencyFlag body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/currency-switch");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update card lock
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether the card should be locked. Set to false to lock, true to unlock.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableCard(Guid cardUid, Enabling body)
        {
            var t = UpdateEnableCardAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update card lock
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether the card should be locked. Set to false to lock, true to unlock.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableCardAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update ATM withdrawal control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether ATM withdrawals should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableAtm(Guid cardUid, Enabling body)
        {
            var t = UpdateEnableAtmAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update ATM withdrawal control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether ATM withdrawals should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableAtmAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/atm-enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update online payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether online payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableOnlinePayments(Guid cardUid, Enabling body)
        {
            var t = UpdateEnableOnlinePaymentsAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update online payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether online payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableOnlinePaymentsAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/online-enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Update mobile wallet payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether mobile wallet payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public void UpdateEnableMobileWallet(Guid cardUid, Enabling body)
        {
            var t = UpdateEnableMobileWalletAsync(cardUid, body);
            APIHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// Update mobile wallet payments control
        /// </summary>
        /// <param name="cardUid">Required parameter: Card uid of the targeted card</param>
        /// <param name="body">Required parameter: Whether mobile wallet payments should be allowed. Set to false to block, true to allow.</param>
        /// <return>Returns the void response from the API call</return>
        public async Task UpdateEnableMobileWalletAsync(Guid cardUid, Enabling body)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException(nameof(body), "The parameter \"body\" is a required parameter and cannot be null.");

            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards/{cardUid}/controls/mobile-wallet-enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>
            {
                { "cardUid", cardUid }
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
        /// Get all the cards for an account holder
        /// </summary>
        /// <return>Returns the Models.Cards response from the API call</return>
        public Cards ListCards()
        {
            var t = ListCardsAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all the cards for an account holder
        /// </summary>
        /// <return>Returns the Models.Cards response from the API call</return>
        public async Task<Cards> ListCardsAsync()
        {
            //the base uri for api requests
            var baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            var queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/v2/cards");


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
                return APIHelper.JsonDeserialize<Cards>(response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, context);
            }
        }

    }
} 