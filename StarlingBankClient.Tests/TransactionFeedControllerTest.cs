using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;
using StarlingBankClient.Controllers;
using StarlingBankClient.Exceptions;
using StarlingBankClient.Models;
using StarlingBankClient.Tests.Helpers;

namespace StarlingBankClient.Tests
{
    [TestFixture]
    public class TransactionFeedControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ITransactionFeedController _controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            _controller = GetClient().TransactionFeed;
        }

        /// <summary>
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestDownloadFeedItemAttachment() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var feedItemUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var feedItemAttachmentUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            Stream result = null;

            try
            {
                result = await _controller.GetDownloadFeedItemAttachmentAsync(accountUid, categoryUid, feedItemUid, feedItemAttachmentUid);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, HTTPCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "*/*");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, HTTPCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestGetReceipt() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var feedItemUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            Receipt result = null;

            try
            {
                result = await _controller.GetReceiptAsync(accountUid, categoryUid, feedItemUid);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestGetFeedItem() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var feedItemUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            FeedItem result = null;

            try
            {
                result = await _controller.GetFeedItemAsync(accountUid, categoryUid, feedItemUid);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestQueryFeedItems() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var changesSince = DateTime.ParseExact("2020-01-01T12:34:56.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            FeedItems result = null;

            try
            {
                result = await _controller.GetQueryFeedItemsAsync(accountUid, categoryUid, changesSince);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestQueryFeedItemsWithTransactionTimesBetween() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var minTransactionTimestamp = DateTime.ParseExact("2020-06-01T12:34:56.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
            var maxTransactionTimestamp = DateTime.ParseExact("2020-07-01T12:34:56.000Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);

            // Perform API call
            FeedItems result = null;

            try
            {
                result = await _controller.GetQueryFeedItemsWithTransactionTimesBetweenAsync(accountUid, categoryUid, minTransactionTimestamp, maxTransactionTimestamp);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestGetFeedItemAttachments() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var feedItemUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            FeedItemAttachments result = null;

            try
            {
                result = await _controller.GetFeedItemAttachmentsAsync(accountUid, categoryUid, feedItemUid);
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
        /// Categories are subdivisions within an account.
        ///The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
        ///Other categories are used for Savings Goals. 
        /// </summary>
        [Test]
        public async Task TestGetMastercardFeedItem() 
        {
            // Parameters for the API call
            var accountUid = GetAccountId();
            var categoryUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");
            var feedItemUid = Guid.Parse("aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa");

            // Perform API call
            MastercardFeedItem result = null;

            try
            {
                result = await _controller.GetMastercardFeedItemAsync(accountUid, categoryUid, feedItemUid);
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

    }
}