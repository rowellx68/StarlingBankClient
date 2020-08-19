using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBank.Controllers;
using StarlingBank.Exceptions;
using StarlingBank.Models;
using StarlingBank.Tests.Helpers;

namespace StarlingBank.Tests
{
    [TestFixture]
    public class AccountsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static IAccountsController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().Accounts;
        }

        /// <summary>
        /// This endpoint lists an account holder's bank accounts.
        ///An account holder, such as a PCA (a *personal current account* - which should really be thought of as a *personal current account holder*), may have many accounts, such as a personal GBP and personal EUR account.
        ///This is different from the idea of an individual (a human/natural person), and is different from a person (a natural (human)/legal (company) person).
        ///
        ///Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestGetAccounts() 
        {

            // Perform API call
            Accounts result = null;

            try
            {
                result = await _controller.GetAccountsAsync();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// Get list of statement periods which are available for an account 
        /// </summary>
        [Test]
        public async Task TestAvailablePeriods() 
        {
            var accountUid = GetAccountId();

            // Perform API call
            AccountStatementPeriods result = null;

            try
            {
                result = await _controller.GetAvailablePeriodsAsync(accountUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// Identifiers come in pairs:
        ///
        ///* A bank identifier, which identifies the bank
        ///* An account identifier, which identifiers the account at the bank
        ///
        ///Identifiers can be:
        ///* Sort code and account number for domestic UK payments
        ///* BIC and IBAN for international payments
        ///* ABA and ACH routing numbers for domestic US payments 
        /// </summary>
        [Test]
        public async Task TestGetAccountIdentifiers() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();

            // Perform API call
            AccountIdentifiers result = null;

            try
            {
                result = await _controller.GetAccountIdentifiersAsync(accountUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
        ///* The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
        ///* The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
        ///
        ///Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
        ///
        ///To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead. 
        /// </summary>
        [Test]
        public async Task TestGetAccountBalance() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();

            // Perform API call
            BalanceV2 result = null;

            try
            {
                result = await _controller.GetAccountBalanceAsync(accountUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv' 
        /// </summary>
        [Test]
        public async Task TestDownloadCsvStatement() 
        {
            var accountUid = GetAccountId();

            var yearMonth = "2020-08";

            // Perform API call
            Stream result = null;

            try
            {
                result = await _controller.GetDownloadCsvStatementAsync(accountUid, yearMonth);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>
            {
                {"Content-Type", "application/pdf"}
            };

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv' 
        /// </summary>
        [Test]
        public async Task TestDownloadCsvStatementForDateRange() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var start = DateTime.ParseExact("2020-08-17", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
            DateTime? end = DateTime.ParseExact("2020-08-17", "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            Stream result = null;

            try
            {
                result = await _controller.GetDownloadCsvStatementForDateRangeAsync(accountUid, start, end);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/pdf");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}