using System;
using System.Linq;
using NUnit.Framework;
using StarlingBank.Exceptions;
using StarlingBank.Models;
using StarlingBank.Tests.Helpers;

namespace StarlingBank.Tests
{
    [TestFixture]
    public class ControllerTestBase
    {
        //Test setup
        public const int RequestTimeout = 60;
        protected const double AssertPrecision = 0.1;
        public TimeSpan GlobalTimeout = TimeSpan.FromSeconds(RequestTimeout);

        //Test Credentials
        public static Configuration.Environments Environment;
        public static string OAuthAccessToken;


        protected HttpCallBackEventsHandler HTTPCallBackHandler = new HttpCallBackEventsHandler();

        [SetUp]
        public void SetUp()
        {
            //hooking events for catching http requests and responses
            GetClient().SharedHTTPClient.OnBeforeHttpRequestEvent += HTTPCallBackHandler.OnBeforeHttpRequestEventHandler;
            GetClient().SharedHTTPClient.OnAfterHttpResponseEvent += HTTPCallBackHandler.OnAfterHttpResponseEventHandler;

        }

        // Singleton instance of client for all test classes
        private static Client _client;
        private static readonly object ClientSync = new object();

        /// <summary>
        /// Get client instance
        /// </summary>
        /// <returns></returns>
        public static Client GetClient()
        {
            if (OAuthAccessToken == null)
            {
                Environment = Configuration.Environments.SANDBOX;
                OAuthAccessToken = "";
            }
            lock (ClientSync)
            {
                return _client ?? (_client = new Client(Environment, OAuthAccessToken));
            }
        }

        public static Guid GetAccountId()
        {
            Accounts accountResult = null;
            var controller = GetClient().Accounts;
            try
            {
                accountResult = controller.GetAccounts();
            }
            catch (APIException) { };

            Assert.IsTrue(accountResult != null);
            Assert.IsTrue(accountResult.AccountsProp.Count > 0);
            return (Guid)accountResult.AccountsProp.First().AccountUid;
        }

        public static Guid GetMandateId()
        {
            DirectDebitMandatesV2 mandatesResult = null;
            var controller = GetClient().DirectDebitMandates;
            try
            {
                mandatesResult = controller.ListMandates();
            }
            catch (APIException) { };

            Assert.IsTrue(mandatesResult != null);
            Assert.IsTrue(mandatesResult.Mandates.Count > 0);
            return (Guid)mandatesResult.Mandates.First().Uid;
        }

        public static Guid GetPayeeId()
        {
            Payees payees = null;
            var controller = GetClient().Payees;
            try
            {
                payees = controller.GetPayees();

            }
            catch (APIException) { };

            Assert.IsTrue(payees != null);
            Assert.IsTrue(payees.PayeesProp.Count > 0);
            return (Guid)payees.PayeesProp.First().PayeeUid;
        }
    }
}